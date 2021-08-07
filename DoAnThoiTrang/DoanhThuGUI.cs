using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ThuVien;

namespace DoAnThoiTrang
{
    public partial class DoanhThuGUI : Form
    {
        public DoanhThuGUI()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        HoaDon hd = new HoaDon();
        TinhTongTien tt = new TinhTongTien();
        CT_HoaDon cthd = new CT_HoaDon();
        ChuyenDoiTienChu ct = new ChuyenDoiTienChu();
        private void DoanhThuGUI_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnLoc_Click(object sender, EventArgs e)
        {
            hd.LoadDT(dgvHoaDon, DateTime.Parse(txtNgay1.Text), DateTime.Parse(txtNgay2.Text));
            txtTongTien.Text = tt.tinhTongTien(dgvHoaDon, 3).ToString();
            txtsumsl.Text = tt.tinhSoLuong(dgvHoaDon, 0).ToString();
            foreach (DataGridViewRow dgv in dgvHoaDon.Rows)
            {
                chartDTngay.Series["ChartDoanhThu"].Points.AddXY(dgv.Cells[2].Value.ToString(), dgv.Cells[3].Value.ToString());
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int mahd = int.Parse(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());
            dgvcthd.DataSource = cthd.loadCTHDBLL(mahd);
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            //lblTongTien.Text = ct.ChuyenSo(txtTongTien.Text);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Word_Export we = new Word_Export();
            ChuyenDoiTienChu cd = new ChuyenDoiTienChu();
            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();
            string ngay1 = txtNgay1.Value.Day.ToString();
            string thang1 = txtNgay1.Value.Month.ToString();
            string nam1 = txtNgay1.Value.Year.ToString();
            string ngay2 = txtNgay2.Value.Day.ToString();
            string thang2 = txtNgay2.Value.Month.ToString();
            string nam2 = txtNgay2.Value.Year.ToString();
            string TongHD = dgvHoaDon.RowCount.ToString();
            string TongDt = txtTongTien.Text;
            string tienchu = cd.ChuyenSo(txtTongTien.Text); 
            string nguoilap = nv.layTenNV(Home.TenDN);
            we.BaoCaoDoanhThu(ngay, thang, nam, ngay1, thang1, nam1, ngay2, thang2, nam2, TongHD, TongDt, tienchu, nguoilap);
        }
    }
}
