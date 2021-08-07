using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;
using BLL;

namespace DoAnThoiTrang
{
    public partial class BanHangGUI : Form
    {

        List<DonBanHang> list;
        public BanHangGUI()
        {
            InitializeComponent();
            list = new List<DonBanHang>();
        }
        SanPham sp = new SanPham();
        HoaDon hd = new HoaDon();
        CT_HoaDon cthd = new CT_HoaDon();
        NhanVien nv = new NhanVien();
        ChuyenDoiNgay cd = new ChuyenDoiNgay();
        private void BanHangGUI_Load(object sender, EventArgs e)
        {          
            cbbNhanVien.DataSource = nv.getNhanVien();
            cbbNhanVien.DisplayMember = "TENNV";
            cbbNhanVien.ValueMember = "MANV";
            txtNgayLap.Text = DateTime.Parse(DateTime.Now.ToString()).ToString("dd/MM/yyyy hh:mm");
            addTreeView(hd.LoadHDTheoNgay(DateTime.Now.ToShortDateString()));
            //cbbNhanVien.Enabled = txtNgayLap.Enabled = false;
            cbbNhanVien.SelectedValue = Home.TenDN;
            
        }
        public void addTreeView(DataTable dt)
        {
            TreeNode tn;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["NGAYTAO"].ToString().Substring(0, 10) == DateTime.Parse(DateTime.Now.ToString()).ToString("yyyy/MM/dd"))
                {
                    tn = new TreeNode();
                    tn.Text = "HD0" + dr["MAHD"].ToString();
                    treeView1.Nodes.Add(tn);
                }
            }
        }
        //sao cái danh sách hóa đơn nó ko hiện ta
        int index = -1;
        int slm = 0;
        int ttm = 0;

        public int kttrungdgv(string masp)
        {
            for (int i = 0; i < dgvbanhang.Rows.Count; i++)
            {
                if (masp == dgvbanhang.Rows[i].Cells[0].Value.ToString())
                {
                    index = i;
                    slm = int.Parse(dgvbanhang.Rows[i].Cells[2].Value.ToString());
                    ttm = int.Parse(dgvbanhang.Rows[i].Cells[4].Value.ToString());
                    return 1;
                }
            }
            return 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DonBanHang dbh = new DonBanHang();
            //SANPHAMTableAdapter da = new SANPHAMTableAdapter();
            
            if (string.IsNullOrEmpty(txtMasp.Text))
            {
                string message = "Mời bạn nhập dữ liệu.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            if (string.IsNullOrEmpty(txtsl.Text))
            {
                string message = "Mời bạn nhập dữ liệu.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            if (string.IsNullOrEmpty(txtTensp.Text))
            {
                string message = "Mời bạn nhập dữ liệu.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            if (string.IsNullOrEmpty(txtGia.Text))
            {
                string message = "Mời bạn nhập dữ liệu.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            int slt = int.Parse(sp.laySLTon(txtMasp.Text).ToString());
            if (slt < int.Parse(txtsl.Text))
            {
                string message = "Không đủ hàng.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }

            TinhTongTien tt = new TinhTongTien();
            if (kttrungdgv(txtMasp.Text) == 1)
            {
                list.RemoveAt(index);
                dbh.ma = txtMasp.Text;
                dbh.ten = txtTensp.Text;
                dbh.sl = int.Parse(txtsl.Text) + slm;
                dbh.gb = int.Parse(txtGia.Text);
                dbh.tt = int.Parse(txtThanhTien.Text) + ttm;
                list.Add(dbh);
                dgvbanhang.DataSource = null;
                setupColumDGV();
                dgvbanhang.DataSource = list;
                txttongtien.Text = tt.tinhTongTien(dgvbanhang, 4).ToString();
                txtMasp.Text = "";
                txtGia.Text = "";
                txtsl.Text = "";
                txtTensp.Text = "";
                txtThanhTien.Text = "";

            }
            else
            {
                dbh.ma = txtMasp.Text;
                dbh.ten = txtTensp.Text;
                dbh.sl = int.Parse(txtsl.Text);
                dbh.gb = int.Parse(txtGia.Text);
                dbh.tt = int.Parse(txtThanhTien.Text);
                list.Add(dbh);
                dgvbanhang.DataSource = null;
                setupColumDGV();
                dgvbanhang.DataSource = list;
                txttongtien.Text = tt.tinhTongTien(dgvbanhang, 4).ToString();
                txtMasp.Text = "";
                txtGia.Text = "";
                txtsl.Text = "";
                txtTensp.Text = "";
                txtThanhTien.Text = "";
            }
        }

        private void txtMasp_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtMasp.Text == string.Empty)
                {
                    txtMasp.Text = "";
                    txtGia.Text = "";
                    txtsl.Text = "";
                    txtTensp.Text = "";
                    txtThanhTien.Text = "";
                }
                else
                {

                    txtTensp.Text = sp.LayTenSPbll(txtMasp.Text).ToString();
                    txtGia.Text = sp.LayGiaSPBLL(txtMasp.Text).ToString().Trim();
                }

            }
            catch
            {
                return;
            }
        }

        private void txtsl_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int sl = 0;
                sl = int.Parse(txtsl.Text);
                int gia = int.Parse(txtGia.Text);
                txtThanhTien.Text = (sl * gia).ToString();
            }
            catch
            {
                return;
            }
        }

        private void dgvbanhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasp.Text = dgvbanhang.CurrentRow.Cells[0].Value.ToString();
            txtTensp.Text = dgvbanhang.CurrentRow.Cells[1].Value.ToString();
            txtsl.Text = dgvbanhang.CurrentRow.Cells[2].Value.ToString();
            txtGia.Text = dgvbanhang.CurrentRow.Cells[3].Value.ToString();
            txtThanhTien.Text = dgvbanhang.CurrentRow.Cells[4].Value.ToString();
            txtMasp.Enabled = txtTensp.Enabled = txtThanhTien.Enabled = txtsl.Enabled = txtGia.Enabled = false;

        }


        private void txttongtien_TextChanged(object sender, EventArgs e)
        {
            ChuyenDoiTienChu cd = new ChuyenDoiTienChu();
            txttienbangchu.Text = cd.ChuyenSo(txttongtien.Text);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            TinhTongTien tt = new TinhTongTien();
            //if (treeView1.SelectedNode == null)
            //{
            //    string message = "Mời bạn chọn hóa đơn cần xóa.";
            //    MessageBoxCustom frm = new MessageBoxCustom();
            //    frm.message(message);
            //    frm.ShowDialog();
            //    return;
            //}
            if (dgvbanhang.SelectedRows == null)
            {
                string message = "Mời bạn chọn sản phẩm cần xóa.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }

            int mahd = 0;
            if (txtMaHD.Text != string.Empty)
            {
                mahd = int.Parse(txtMaHD.Text.Substring(3));
            }
            else
            {
                mahd = int.Parse(treeView1.SelectedNode.Text.Substring(2, 5).Trim());
            }
            int macthd = cthd.layMCTHD(mahd, txtMasp.Text);
            if (cthd.delete(macthd))
            {
                string message1 = "Xóa thành công.";
                MessageBoxThanhCong frm1 = new MessageBoxThanhCong();
                frm1.message(message1);
                frm1.ShowDialog();
                cthd.LoadCTHD(dgvbanhang, mahd);
                txttongtien.Text = tt.tinhTongTien(dgvbanhang, 4).ToString();
                if (hd.UpdateTongTien(mahd, int.Parse(txttongtien.Text),cbbNhanVien.SelectedValue.ToString()))
                {
                    string message2 = "Cập nhật tổng tiền thành công.";
                    MessageBoxThanhCong frm2 = new MessageBoxThanhCong();
                    frm2.message(message2);
                    frm2.ShowDialog();
                }
                else
                {
                    string message = "Cập nhật tổng tiền thất bại.";
                    MessageBoxCustom frm = new MessageBoxCustom();
                    frm.message(message);
                    frm.ShowDialog();
                }
            }
            else
            {
                string message = "Xóa thất bại.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
            }
        }
        DataGridViewTextBoxColumn hd1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd2 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd3 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd4 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd5 = new DataGridViewTextBoxColumn();
        private void setupColumDGV()
        {
            dgvbanhang.Columns.Clear();
            // Column1
            // 
            hd1.DataPropertyName = "ma";
            hd1.HeaderText = "Mã Sản Phẩm";
            hd1.Name = "Column1";
            hd1.DisplayIndex = 1;
            hd1.Width = 100;
            hd1.ReadOnly = true;
            // 
            // Column2
            // 
            hd2.DataPropertyName = "ten";
            hd2.HeaderText = "Tên Sản Phẩm";
            hd2.Name = "Column2";
            hd2.DisplayIndex = 2;
            hd2.Width = 250;
            hd2.ReadOnly = true;
            // 
            // Column3
            // 
            hd3.DataPropertyName = "sl";
            hd3.HeaderText = "Số Lượng";
            hd3.Name = "Column3";
            hd3.DisplayIndex = 3;
            hd3.ReadOnly = true;
            hd3.Width = 100;
            // 
            // Column4
            // 
            hd4.DataPropertyName = "gb";
            hd4.HeaderText = "Giá Bán";
            hd4.Name = "Column4";
            hd4.DisplayIndex = 4;
            hd4.ReadOnly = true;
            hd4.Width = 100;
            //
            // Column5
            // 
            hd5.DataPropertyName = "tt";
            hd5.HeaderText = "Thành Tiền";
            hd5.Name = "Column5";
            hd5.DisplayIndex = 5;
            hd5.ReadOnly = true;
            hd5.Width = 100;
            //
            dgvbanhang.Columns.Add(hd1);
            dgvbanhang.Columns.Add(hd2);
            dgvbanhang.Columns.Add(hd3);
            dgvbanhang.Columns.Add(hd4);
            dgvbanhang.Columns.Add(hd5);
            //
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int kq;
            if (txttongtien.Text == string.Empty)
                kq = 0;
            else
                kq = int.Parse(txttongtien.Text);

            if (hd.Them(1, cbbNhanVien.SelectedValue.ToString(), DateTime.Now, kq, "Đã Thanh Toán"))
            {
                int mahd = hd.LayHDMax();
                int n = dgvbanhang.Rows.Count;

                for (int i = 0; i < n; i++)
                {
                    string masp = dgvbanhang.Rows[i].Cells[0].Value.ToString();
                    int sl = int.Parse(dgvbanhang.Rows[i].Cells[2].Value.ToString());
                    int giaban = int.Parse(dgvbanhang.Rows[i].Cells[3].Value.ToString());
                    int thanhtien = int.Parse(dgvbanhang.Rows[i].Cells[4].Value.ToString());
                    //bool kqt = cthd.insert(mahd, masp, sl, giaban, thanhtien);
                    if (cthd.insert(mahd, masp, sl, giaban, thanhtien))
                    {
                        string message = "Thêm thành công.";
                        MessageBoxThanhCong frm = new MessageBoxThanhCong();
                        frm.message(message);
                        frm.ShowDialog();
                        masp = "";
                        sl = 0;
                        giaban = 0;
                        thanhtien = 0;
                        treeView1.Nodes.Clear();
                        addTreeView(hd.LoadHDTheoNgay(DateTime.Now.ToShortDateString()));
                        btnThanhToan.Enabled = false;

                    }
                    else
                    {
                        string message = "Thêm thất bại.";
                        MessageBoxCustom frm = new MessageBoxCustom();
                        frm.message(message);
                        frm.ShowDialog();
                    }
                }

            }
            else
            {
                string message = "Thêm thất bại.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            cthd.LoadCTHD(dgvbanhang, int.Parse(treeView1.SelectedNode.Text.Substring(2).Trim()));
            btnThanhToan.Enabled = btnThem.Enabled = false;
            txttongtien.Text = ttt.tinhTongTien(dgvbanhang, 4).ToString();
            //MessageBox.Show(treeView1.SelectedNode.Text.Substring(2, 3).Trim());
        }

        private void txttiendua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int tongtien = int.Parse(txttongtien.Text);
                int tongdua = int.Parse(txttiendua.Text);
                if (tongdua > tongtien)
                    txttienthoi.Text = (tongdua - tongtien).ToString();
            }
            catch
            {
                return;
            }
        }

        TinhTongTien ttt = new TinhTongTien();
        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            int mahd = 0;
            if (txtMaHD.Text!=string.Empty)
            {
                mahd = int.Parse(txtMaHD.Text);
            }
            else
            {
                mahd = int.Parse(treeView1.SelectedNode.Text.Substring(2, 5).Trim());
            }
            int macthd = cthd.layMCTHD(mahd, txtMasp.Text);
            int gia = int.Parse(txtGia.Text);
            int tt = int.Parse(txtThanhTien.Text);
            if (cthd.update(int.Parse(txtsl.Text), gia, tt, macthd))
            {
                string message1 = "Sửa thành công.";
                MessageBoxThanhCong frm1 = new MessageBoxThanhCong();
                frm1.message(message1);
                frm1.ShowDialog();
                cthd.LoadCTHD(dgvbanhang, mahd);
                txttongtien.Text = ttt.tinhTongTien(dgvbanhang, 4).ToString();
                if(hd.UpdateTongTien(mahd,int.Parse(txttongtien.Text),cbbNhanVien.SelectedValue.ToString()))
                {
                    string message2 = "Cập nhật tổng tiền thành công.";
                    MessageBoxThanhCong frm2 = new MessageBoxThanhCong();
                    frm2.message(message2);
                    frm2.ShowDialog();
                }
                else
                {
                    string message = "Cập nhật tổng tiền thất bại.";
                    MessageBoxCustom frm = new MessageBoxCustom();
                    frm.message(message);
                    frm.ShowDialog();
                }
            }
            else
            {
                string message = "Sửa thất bại.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
            }
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgvbanhang.SelectedRows == null)
            {
                string message = "Mời bạn chọn sản phẩm cần sửa.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            txtsl.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                int mahd = int.Parse(txtMaHD.Text.Substring(2));
                cthd.LoadCTHD(dgvbanhang, mahd);
                foreach (DataRow dr in hd.getSearch(mahd).Rows)
                {
                    txtNgayLap.Text = DateTime.Parse(dr["NGAYTAO"].ToString()).ToString("dd/MM/yyyy hh:mm");
                }
                btnThem.Enabled = btnThanhToan.Enabled = false;
            }
            catch
            {
                return;
            }
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            if (btnThanhToan.Enabled)
            {
                string message = "Bạn chưa thanh toán hóa đơn mới.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
            }
            else
            {
                if (treeView1.SelectedNode != null)
                {
                    dgvbanhang.Rows.Clear();
                    txtGia.Enabled = txtMasp.Enabled = txtsl.Enabled = txtTensp.Enabled = txtThanhTien.Enabled = true;
                    txtGia.Text = txtMasp.Text = txtsl.Text = txtTensp.Text = txtThanhTien.Text = "";
                    btnThem.Enabled = btnThanhToan.Enabled = true;
                    txtMaHD.Clear();
                    treeView1.Nodes.Clear();
                    BanHangGUI_Load(sender, e);
                }
                else
                {
                    dgvbanhang.DataSource = null;
                    setupColumDGV();
                    txtGia.Enabled = txtMasp.Enabled = txtsl.Enabled = txtTensp.Enabled = txtThanhTien.Enabled = true;
                    txttongtien.Text = txttienbangchu.Text = txttienthoi.Text = txttiendua.Text = txtGia.Text = txtMasp.Text = txtsl.Text = txtTensp.Text = txtThanhTien.Text = "";
                    btnThem.Enabled = btnThanhToan.Enabled = true;
                    txtMaHD.Clear();
                    treeView1.Nodes.Clear();
                    BanHangGUI_Load(sender, e);
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Excel_Export excel = new Excel_Export();
            SaveFileDialog saveFile = new SaveFileDialog();
            if (dgvbanhang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất");
                return;
            }
            List<HoaDonBanHang> pListHoaDonBanHang = new List<HoaDonBanHang>();
            // Đổ dữ liệu vào danh sách

            for (int i = 0; i < dgvbanhang.RowCount; i++)
            {
                HoaDonBanHang ii = new HoaDonBanHang();
                ii.TenSP = dgvbanhang.Rows[i].Cells[1].Value.ToString();
                ii.SoLuong = int.Parse(dgvbanhang.Rows[i].Cells[2].Value.ToString());
                ii.GiaBan = int.Parse(dgvbanhang.Rows[i].Cells[3].Value.ToString());
                ii.ThanhTien = int.Parse(dgvbanhang.Rows[i].Cells[4].Value.ToString());
                pListHoaDonBanHang.Add(ii);
            }

            string path = string.Empty;
            excel.ExportHoaDonBanHang(pListHoaDonBanHang, ref path, false);
            // Confirm for open file was exported
            if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?", "Thôngtin",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }
        }
    }
}
