using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ThuVien;

namespace DoAnThoiTrang
{
    public partial class DatHangGUI : Form
    {
       
        public DatHangGUI()
        {
            InitializeComponent();
            list = new List<DonDatHang>();
        }
        List<DonDatHang> list;
        DatHang dh = new DatHang();
        SanPham sp = new SanPham();
        BangGia bg = new BangGia();
        CT_DatHang ct = new CT_DatHang();
        NhaCungCap ncc = new NhaCungCap();
        NhanVien nv = new NhanVien();
        TinhTongTien tt = new TinhTongTien();
        ChuyenDoiNgay cd = new ChuyenDoiNgay();

        private void DatHangGUI_Load(object sender, EventArgs e)
        {
            cbbncc.DataSource = ncc.getNCC();
            cbbncc.DisplayMember = "TenNCC";
            cbbncc.ValueMember = "MaNCC";          
            cbbNhanVien.DataSource = nv.getNhanVien();
            cbbNhanVien.DisplayMember = "TenNV";
            cbbNhanVien.ValueMember = "MANV";
            cbbNhanVien.SelectedValue = Home.TenDN;
            txtngaydat.Text = DateTime.Parse(DateTime.Now.ToString()).ToString("dd/MM/yyyy"); ;
            if (dh.LayMaDHMax() == null)
                txtMaDH.Text = "MADH01";
            else
            {
                int ma = int.Parse(dh.LayMaDHMax().ToString());
                int kq = ma + 1;
                txtMaDH.Text = "MADH0" + kq;

            }
            addTreeView(dh.LayDatHangNgay(DateTime.Parse(cd.CDxuoiu(txtngaydat.Text))));
            btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnThemMoi.Enabled = true;
            txtTongTien.Clear();
        }
        public void addTreeView(DataTable dt)
        {
            TreeNode tn1;

            foreach (DataRow dr in dt.Rows)
            {
                tn1 = new TreeNode();
                tn1.Text = dr["MADH"].ToString();
                treeView1.Nodes.Add(tn1);                
            }
        }

        private void cbbncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbbTensp.DataSource = sp.LaySanPhamTheoNCC(cbbncc.SelectedValue.ToString());
                cbbTensp.DisplayMember = "TENSP";
                cbbTensp.ValueMember = "MASP";
            }
            catch
            {
                return;
            }
        }

        private void cbbTensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow dr in bg.GetGia(cbbTensp.SelectedValue.ToString()).Rows)
            {
                txtGiaDat.Text = dr["GiaNhap"].ToString();
            }
        }

        private void txtsldat_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtthanhtien.Text = (int.Parse(txtGiaDat.Text) * int.Parse(txtsldat.Text)).ToString();
            }
            catch
            {
                return;
            }
        }
        int index = -1;
        int sl = 0;
        int ttm = 0;
        public int KiemTraTrung(string tensp)
        {

            for (int i = 0; i < dgvDatHang.RowCount; i++)
            {
                if (dgvDatHang.Rows[i].Cells[1].Value.ToString() == tensp)
                {
                    sl = int.Parse(dgvDatHang.Rows[i].Cells[2].Value.ToString());
                    index = i;
                    ttm = int.Parse(dgvDatHang.Rows[i].Cells[4].Value.ToString());
                    return 1;
                }
            }
            return 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DonDatHang ddh = new DonDatHang();
            btnThemMoi.Enabled = btnLuu.Enabled = true;
            if (DateTime.Parse(cd.CDxuoiu(txtngaydat.Text)) > DateTime.Parse(cd.CDxuoiu(txtngaygiao.Text)))
            {
                string message = "Hãy kiểm tra lại ngày giao.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            if (KiemTraTrung(cbbTensp.Text) == 1)
            {
                list.RemoveAt(index);
                ddh.Msp = cbbTensp.SelectedValue.ToString();
                ddh.Tsp = cbbTensp.Text;
                ddh.Sld = int.Parse(txtsldat.Text) + sl;
                ddh.Gn = int.Parse(txtGiaDat.Text);
                ddh.Tt = int.Parse(txtthanhtien.Text) + ttm;

                list.Add(ddh);
                dgvDatHang.DataSource = null;
                setupColumDGV();
                dgvDatHang.DataSource = list;
                txtTongTien.Text = tt.tinhTongTien(dgvDatHang, 4).ToString();
                cbbncc.Enabled = txtngaydat.Enabled = txtngaygiao.Enabled = false;
                txtMaDH.Enabled = false;
                cbbTensp.ResetText();
                txtGiaDat.Clear();
                txtsldat.Clear();
                txtthanhtien.Clear();
            }
            else
            {
                ddh.Msp = cbbTensp.SelectedValue.ToString();
                ddh.Tsp = cbbTensp.Text;
                ddh.Sld = int.Parse(txtsldat.Text);
                ddh.Gn = int.Parse(txtGiaDat.Text);
                ddh.Tt = int.Parse(txtthanhtien.Text);
                list.Add(ddh);
                dgvDatHang.DataSource = null;
                setupColumDGV();
                dgvDatHang.DataSource = list;
                txtTongTien.Text = tt.tinhTongTien(dgvDatHang, 4).ToString();
                cbbncc.Enabled = txtngaydat.Enabled = txtngaygiao.Enabled = false;
                txtMaDH.Enabled = false;
                cbbTensp.ResetText();
                txtGiaDat.Clear();
                txtsldat.Clear();
                txtthanhtien.Clear();
            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            ChuyenDoiTienChu cd = new ChuyenDoiTienChu();
            label10.Text = cd.ChuyenSo(txtTongTien.Text);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled)
            {
                if (dh.insert(txtMaDH.Text, cbbNhanVien.SelectedValue.ToString(), cbbncc.SelectedValue.ToString(), DateTime.Parse(cd.CDxuoiu(txtngaydat.Text)), DateTime.Parse(cd.CDxuoiu(txtngaygiao.Text)), int.Parse(txtTongTien.Text), "Chưa Giao Hàng"))
                {
                    int n = dgvDatHang.Rows.Count;
                    string madh = txtMaDH.Text;
                    int flag = 0;
                    for (int i = 0; i < n; i++)
                    {
                        string masp = sp.layMaSP(dgvDatHang.Rows[i].Cells[1].Value.ToString());
                        int sl = int.Parse(dgvDatHang.Rows[i].Cells[2].Value.ToString());
                        int Gia = int.Parse(dgvDatHang.Rows[i].Cells[3].Value.ToString());
                        int thanhtien = int.Parse(dgvDatHang.Rows[i].Cells[4].Value.ToString());
                        string gc = "";
                        if (ct.insert(madh, masp, sl, Gia, thanhtien, gc))
                        {
                            masp = "";
                            sl = 0;
                            Gia = 0;
                            thanhtien = 0;
                            flag = 1;
                        }
                        else
                        {
                            flag = 0;
                        }
                    }
                    if(flag==1)
                    {
                        string message = "Thêm thành công.";
                        MessageBoxThanhCong frm = new MessageBoxThanhCong();
                        frm.message(message);
                        frm.ShowDialog();
                        treeView1.Nodes.Clear();
                        DatHangGUI_Load(sender, e);

                        txtMaDH.Enabled = cbbncc.Enabled = txtngaydat.Enabled = txtngaygiao.Enabled = true;
                        btnLuu.Enabled = btnThem.Enabled = false;
                    }
                    else
                    {
                        string message = "Thêm thất bại.";
                        MessageBoxCustom frm = new MessageBoxCustom();
                        frm.message(message);
                        frm.ShowDialog();
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
            else
            {
                //if (treeView1.SelectedNode == null)
                //{
                //    MessageBox.Show("Mời bạn chọn hóa đơn cần sửa");
                //    return;
                //}
                if (dgvDatHang.SelectedRows == null)
                {
                    string message = "Mời bạn chọn sản phẩm cần sửa.";
                    MessageBoxCustom frm = new MessageBoxCustom();
                    frm.message(message);
                    frm.ShowDialog();
                    return;
                }
                string masp = sp.layMaSP(cbbTensp.Text).ToString();
                int sl = int.Parse(txtsldat.Text);
                int Gia = int.Parse(txtGiaDat.Text);
                int thanhtien = int.Parse(txtthanhtien.Text);

                int mactdh = ct.LayMaCTDH(txtMaDH.Text, masp);
                if (ct.update(mactdh, sl, thanhtien))
                {

                    //dgvDatHang.Rows.Clear();
                    dgvDatHang.DataSource = ct.loadctdh(txtMaDH.Text);
                    txtTongTien.Text = tt.tinhTongTien(dgvDatHang, 4).ToString();
                    string message1 = "Sửa thành công.";
                    MessageBoxThanhCong frm1 = new MessageBoxThanhCong();
                    frm1.message(message1);
                    frm1.ShowDialog();
                    if (dh.SuaTongTienDat(txtMaDH.Text, int.Parse(txtTongTien.Text)))
                    {
                        string message = "Cập nhật thành công.";
                        MessageBoxThanhCong frm = new MessageBoxThanhCong();
                        frm.message(message);
                        frm.ShowDialog();
                    }
                    else
                    {
                        string message = "Cập nhật thất bại.";
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
        }
        public void loadCTHD()
        {
            dgvDatHang.DataSource = ct.loadctdh(treeView1.SelectedNode.Text.Substring(0, 7).Trim());
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtMaDH.Enabled = cbbncc.Enabled = false;
            txtngaygiao.Enabled = txtngaydat.Enabled = true;
            btnThemMoi.Enabled = true;
            btnThem.Enabled = false;
            dgvDatHang.DataSource = ct.loadctdh(treeView1.SelectedNode.Text.Substring(0, 7).Trim());
            txtMaDH.Text = treeView1.SelectedNode.Text.Substring(0, 8).Trim();
            cbbncc.SelectedValue = dh.LayMaNCC(treeView1.SelectedNode.Text.Substring(0, 8).Trim());
            foreach (DataRow dr in dh.loadData(treeView1.SelectedNode.Text.Substring(0, 8).Trim()).Rows)
            {

                cbbncc.Text = dr["TENNCC"].ToString();
                txtngaydat.Text = DateTime.Parse(dr["NGAYDAT"].ToString()).ToString("dd/MM/yyyy");
                txtngaygiao.Text = dr["NGAYGIAO"].ToString();
            }
            txtTongTien.Text = tt.tinhTongTien(dgvDatHang, 4).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (treeView1.SelectedNode == null)
            //{
            //    MessageBox.Show("Mời bạn chọn hóa đơn cần xóa");
            //    return;
            //}
            if (dgvDatHang.SelectedRows == null)
            {
                string message = "Mời bạn chọn sản phẩm cần xóa.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }

            string masp = dgvDatHang.CurrentRow.Cells[0].Value.ToString();
            int mactdh = ct.LayMaCTDH(txtMaDH.Text, masp);

            if (ct.delete(mactdh))
            {
                string message1 = "Xóa thành công.";
                MessageBoxThanhCong frm1 = new MessageBoxThanhCong();
                frm1.message(message1);
                frm1.ShowDialog();

                dgvDatHang.DataSource = ct.loadctdh(txtMaDH.Text);
                txtTongTien.Text = tt.tinhTongTien(dgvDatHang, 4).ToString();
                if (dh.SuaTongTienDat(txtMaDH.Text, int.Parse(txtTongTien.Text)))
                {
                    string message = "Cập nhật thành công.";
                    MessageBoxThanhCong frm = new MessageBoxThanhCong();
                    frm.message(message);
                    frm.ShowDialog();
                }
                else
                {
                    string message = "Cập nhật thất bại.";
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            //if (treeView1.SelectedNode == null)
            //    MessageBox.Show("Mời bạn chọn hóa đơn cần sửa");
            //else
            //{
            if (dgvDatHang.SelectedRows == null)
            {
                string message = "Mời bạn chọn sản phẩm cần sửa.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            txtngaygiao.Enabled = txtngaydat.Enabled = true;
                txtsldat.Enabled = true;
                btnSua.Enabled = false;
                btnLuu.Enabled = true;
            //}
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (!btnThem.Enabled)
            {
                dgvDatHang.DataSource = null;
                setupColumDGV();
                list.Clear();
                treeView1.Nodes.Clear();
                DatHangGUI_Load(sender, e);
                btnThem.Enabled = true;
                txtGiaDat.Enabled = txtMaDH.Enabled = txtngaydat.Enabled = txtngaygiao.Enabled = txtsldat.Enabled = cbbTensp.Enabled = txtthanhtien.Enabled = true;
                txtngaygiao.ResetText();
                cbbTensp.ResetText();
                txtsldat.ResetText();
                txtthanhtien.ResetText();
                txtGiaDat.ResetText();
                txtTongTien.Clear();
                cbbncc.Enabled = true;
            }
            else
            {

                string message = "Vui lòng thanh toán hóa đơn.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                cbbTensp.Text = dgvDatHang.CurrentRow.Cells[1].Value.ToString();
                txtsldat.Text = dgvDatHang.CurrentRow.Cells[2].Value.ToString();
                txtGiaDat.Text = dgvDatHang.CurrentRow.Cells[3].Value.ToString();
                txtthanhtien.Text = dgvDatHang.CurrentRow.Cells[4].Value.ToString();
                btnSua.Enabled = btnXoa.Enabled = btnThemMoi.Enabled = true;
                btnThem.Enabled = false;
                txtGiaDat.Enabled = txtMaDH.Enabled = txtngaydat.Enabled = txtngaygiao.Enabled = txtsldat.Enabled = cbbTensp.Enabled = txtthanhtien.Enabled = false;
          
        }
        DataGridViewTextBoxColumn hd1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd2 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd3 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd4 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd5 = new DataGridViewTextBoxColumn();
        private void setupColumDGV()
        {
            dgvDatHang.Columns.Clear();
            // Column1
            // 
            hd1.DataPropertyName = "msp";
            hd1.HeaderText = "Mã Sản Phẩm";
            hd1.Name = "Column1";
            hd1.DisplayIndex = 1;
            hd1.Width = 150;
            hd1.ReadOnly = true;
            // 
            // Column2
            // 
            hd2.DataPropertyName = "tsp";
            hd2.HeaderText = "Tên Sản Phẩm";
            hd2.Name = "Column2";
            hd2.DisplayIndex = 2;
            hd2.Width = 300;
            hd2.ReadOnly = true;
            // 
            // Column3
            // 
            hd3.DataPropertyName = "sld";
            hd3.HeaderText = "Số Lượng Đặt";
            hd3.Name = "Column3";
            hd3.DisplayIndex = 3;
            hd3.ReadOnly = true;
            hd3.Width = 150;
            // 
            // Column4
            // 
            hd4.DataPropertyName = "gn";
            hd4.HeaderText = "Giá Đặt";
            hd4.Name = "Column4";
            hd4.DisplayIndex = 4;
            hd4.ReadOnly = true;
            hd4.Width = 150;
            //
            // Column5
            // 
            hd5.DataPropertyName = "tt";
            hd5.HeaderText = "Thành Tiền";
            hd5.Name = "Column5";
            hd5.DisplayIndex = 5;
            hd5.ReadOnly = true;
            hd5.Width = 150;
            //
            dgvDatHang.Columns.Add(hd1);
            dgvDatHang.Columns.Add(hd2);
            dgvDatHang.Columns.Add(hd3);
            dgvDatHang.Columns.Add(hd4);
            dgvDatHang.Columns.Add(hd5);
            //
        }

        int dem = 0;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dem++;

            if (dem % 2 != 0)
            {
                txtMaDH.Clear();
                btnThem.Enabled = false;
            }
            else
            {
                treeView1.Nodes.Clear();
                DatHangGUI_Load(sender, e);
            }
        }

        private void txtMaDH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDatHang.DataSource = ct.loadctdh(txtMaDH.Text);
                cbbncc.SelectedValue = dh.LayMaNCC(txtMaDH.Text);
                foreach (DataRow dr in dh.loadData(txtMaDH.Text).Rows)
                {

                    cbbncc.Text = dr["TENNCC"].ToString();
                    txtngaydat.Text = DateTime.Parse(dr["NGAYDAT"].ToString()).ToString("dd/MM/yyyy");
                    txtngaygiao.Text = dr["NGAYGIAO"].ToString();
                }
                txtTongTien.Text = tt.tinhTongTien(dgvDatHang, 4).ToString();
            }
            catch
            {
                return;
            }
        }
    }
}