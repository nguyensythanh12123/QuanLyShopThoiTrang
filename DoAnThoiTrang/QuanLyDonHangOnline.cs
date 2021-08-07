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

namespace DoAnThoiTrang
{
    public partial class QuanLyDonHangOnline : Form
    {
        public QuanLyDonHangOnline()
        {
            InitializeComponent();
        }
        HoaDon hd = new HoaDon();
        CT_HoaDon ct = new CT_HoaDon();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyDonHangOnline_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = hd.LoadDataTinhTrang();
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            ct.LoadCTHD(dgvcthd, int.Parse(dgvHoaDon.CurrentRow.Cells[0].Value.ToString()));
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (cbb.SelectedItem.ToString() == string.Empty)
            {
                string message = "Mời bạn chọn tình trạng.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            if (hd.UpdateTinhTrang(int.Parse(dgvHoaDon.CurrentRow.Cells[0].Value.ToString()),cbb.SelectedItem.ToString()))
            {
                string message = "Cập nhật thành công.";
                MessageBoxThanhCong frm = new MessageBoxThanhCong();
                frm.message(message);
                frm.ShowDialog(); 
                dgvHoaDon.DataSource = hd.LoadDataTinhTrang();
            }
            else
            {
                string message = "Cập nhật thất bại.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
            }
        }
    }
}
