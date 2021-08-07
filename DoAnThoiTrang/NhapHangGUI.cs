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
    public partial class NhapHangGUI : Form
    {
        public NhapHangGUI()
        {
            InitializeComponent();
        }
        PhieuNhap pn = new PhieuNhap();
        CT_PhieuNhap ctpn = new CT_PhieuNhap();
        NhaCungCap ncc = new NhaCungCap();
        CT_DatHang ctdh = new CT_DatHang();
        DatHang dh = new DatHang();
        NhanVien nv = new NhanVien();
        private void NhapHangGUI_Load(object sender, EventArgs e)
        {
            cbbNcc.DataSource = ncc.getNCC();
            cbbNcc.DisplayMember = "TENNCC";
            cbbNcc.ValueMember = "MANCC";
            cbbNhanVien.DataSource = nv.getNhanVien();
            cbbNhanVien.DisplayMember = "TENNV";
            cbbNhanVien.ValueMember = "MANV";
            //cbbNhanVien.SelectedValue = Home.TenDN;
            txtNgayNhap.Text = DateTime.Now.ToShortDateString();
            txtNgayNhap.Enabled = false;
        }

        private void cbbNcc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        void loctrv()
        {
            foreach (DataRow dr in dh.GetMaDH(cbbNcc.SelectedValue.ToString()).Rows)
            {
                //MessageBox.Show(dr["MADH"].ToString());
                trvDonDatHang.Nodes.Add(dr["MADH"].ToString());
            }
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            trvDonDatHang.Nodes.Clear();
            loctrv();

        }
        TinhTongTien tt = new TinhTongTien();
        public void loadCTDH()
        {
            dgvNhapHang.DataSource = ctdh.LoadDatHang(trvDonDatHang.SelectedNode.Text);
        }
        string madh = "";
        private void trvDonDatHang_AfterSelect(object sender, TreeViewEventArgs e)
        {
            loadCTDH();
            madh = trvDonDatHang.SelectedNode.Text.Substring(0, 7).Trim();
            txtTongTien.Text = tt.tinhTongTien(dgvNhapHang, 4).ToString();
        }


        public string layMaMax()
        {
            string kq = "";

            if (pn.loadMaPNMax().ToString() == null)
                kq = "MAPN01";
            else
            {
                int ma = int.Parse(layMaMax().ToString());
                int ht = ma + 1;
                kq = "MAPN0" + ht;
            }
            return kq;

        }
        private void TinhTongTienNhap()
        {
            string x = dgvNhapHang.Rows[1].Cells[5].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (trvDonDatHang.SelectedNode == null)
            {
                string message = "Mời bạn nhập phiếu đặt hàng cần nhập.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            string MaPN = "";
            if (pn.loadMaPNMax() == string.Empty)
            {
                MaPN = "PN01";
            }
            else
            {
                int kq = int.Parse(pn.loadMaPNMax()) + 1;
                MaPN = "PN0" + kq.ToString();
            }
            if (pn.Insert(MaPN, trvDonDatHang.SelectedNode.Text, DateTime.Parse(txtNgayNhap.Text), int.Parse(txtTongTien.Text),cbbNhanVien.SelectedValue.ToString()))
            {
                for(int i=0;i<dgvNhapHang.RowCount;i++)
                {
                    string Masp = dgvNhapHang.Rows[i].Cells[0].Value.ToString();
                    int sl= int.Parse(dgvNhapHang.Rows[i].Cells[2].Value.ToString());
                    int gb = int.Parse(dgvNhapHang.Rows[i].Cells[3].Value.ToString());
                    int tt = int.Parse(dgvNhapHang.Rows[i].Cells[4].Value.ToString());
                    string ghichu= dgvNhapHang.Rows[i].Cells[5].Value.ToString();
                    if(ctpn.insert(MaPN,Masp,sl,gb,tt,ghichu))
                    {
                        string message = "Thêm thành công.";
                        MessageBoxThanhCong frm = new MessageBoxThanhCong();
                        frm.message(message);
                        frm.ShowDialog();
                        Masp = ghichu = "";
                        sl = gb = tt = 0;
                    }
                }
                if(dh.UpdateTT(trvDonDatHang.SelectedNode.Text))
                {
                    string message = "Đã cập nhật đơn đặt hàng.";
                    MessageBoxThanhCong frm = new MessageBoxThanhCong();
                    frm.message(message);
                    frm.ShowDialog();
                    trvDonDatHang.Nodes.Clear();
                    loctrv();
                }
                else
                {
                    string message = "Thất bại.";
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

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvNhapHang.ReadOnly = false;
            
            //MessageBox.Show(dgvNhapHang.CurrentRow.Cells[5].Value.ToString());
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            ChuyenDoiTienChu chuyenDoi = new ChuyenDoiTienChu();
            txtTienChu.Text = chuyenDoi.ChuyenSo(txtTongTien.Text.Trim());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvNhapHang.Rows.RemoveAt(dgvNhapHang.CurrentRow.Index);
            txtTongTien.Text = tt.tinhTongTien(dgvNhapHang, 4).ToString();
        }

        private void dgvNhapHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //string GhiChu = dgvNhapHang.CurrentRow.Cells[5].Value.ToString();
            //int sl = int.Parse(dgvNhapHang.CurrentRow.Cells[2].Value.ToString());
            //int gb = int.Parse(dgvNhapHang.CurrentRow.Cells[3].Value.ToString());
            //int tt = int.Parse(dgvNhapHang.CurrentRow.Cells[4].Value.ToString());
            ////            dgvNhapHang.CurrentRow.Cells[4].Value= (sl * gb).ToString();
            //if (GhiChu == "Thiếu")
            //{
            //    //groupBox4.Visible = true;
            //}
        }
        int dem = 0;    
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dem++;
            if(dem%2!=0)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
                dgvNhapHang.Rows.Clear();
                txtTongTien.Clear();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ctpn.LoadCTPN(dgvNhapHang, txtMaPN.Text);
            txtTongTien.Text = tt.tinhTongTien(dgvNhapHang, 4).ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
        DataGridViewTextBoxColumn hd1 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd2 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd3 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd4 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd5 = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn hd6 = new DataGridViewTextBoxColumn();
        private void setupColumDGV()
        {
            dgvNhapHang.Columns.Clear();
            // Column1
            // 
            hd1.DataPropertyName = "msp";
            hd1.HeaderText = "Mã Sản Phẩm";
            hd1.Name = "Column1";
            hd1.DisplayIndex = 1;
            //hd1.Width = 100;
            hd1.ReadOnly = true;
            // 
            // Column2
            // 
            hd2.DataPropertyName = "tsp";
            hd2.HeaderText = "Tên Sản Phẩm";
            hd2.Name = "Column2";
            hd2.DisplayIndex = 2;
            //hd2.Width = 250;
            hd2.ReadOnly = true;
            // 
            // Column3
            // 
            hd3.DataPropertyName = "sld";
            hd3.HeaderText = "Số Lượng";
            hd3.Name = "Column3";
            hd3.DisplayIndex = 3;
            hd3.ReadOnly = true;
            //hd3.Width = 100;
            // 
            // Column4
            // 
            hd4.DataPropertyName = "gn";
            hd4.HeaderText = "Giá Nhập";
            hd4.Name = "Column4";
            hd4.DisplayIndex = 4;
            hd4.ReadOnly = true;
            //hd4.Width = 100;
            //
            // Column5
            // 
            hd5.DataPropertyName = "tt";
            hd5.HeaderText = "Thành Tiền";
            hd5.Name = "Column5";
            hd5.DisplayIndex = 5;
            hd5.ReadOnly = true;
            //hd5.Width = 100;
            //
            // Column5
            // 
            hd6.DataPropertyName = "gc";
            hd6.HeaderText = "Ghi Chú";
            hd6.Name = "Column6";
            hd6.DisplayIndex = 6;
            hd6.ReadOnly = true;
            //hd6.Width = 100;
            //
            dgvNhapHang.Columns.Add(hd1);
            dgvNhapHang.Columns.Add(hd2);
            dgvNhapHang.Columns.Add(hd3);
            dgvNhapHang.Columns.Add(hd4);
            dgvNhapHang.Columns.Add(hd5);
            dgvNhapHang.Columns.Add(hd6);
            //
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvNhapHang.DataSource = null;
            setupColumDGV();
            txtTongTien.Clear();
            txtTienChu.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
