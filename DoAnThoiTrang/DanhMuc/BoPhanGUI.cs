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

namespace DoAnThoiTrang.DanhMuc
{
    public partial class BoPhanGUI : Form
    {
        public BoPhanGUI()
        {
            InitializeComponent();
        }
        BoPhan bp = new BoPhan();
        private void BoPhanGUI_Load(object sender, EventArgs e)
        {
            mnuluu.Enabled = mnusua.Enabled = mnuxoa.Enabled = false;
            mnuthem.Enabled = true;
            txtMaBP.Text = txtTenBP.Text = "";
            dgvBoPhan.DataSource = bp.GetBoPhan();
            txtMaBP.Enabled = txtTenBP.Enabled = false;
        }

        private void mnuthem_Click(object sender, EventArgs e)
        {
            mnuthem.Enabled = false;
            txtMaBP.Text = txtTenBP.Text = "";
            txtMaBP.Enabled = txtTenBP.Enabled = true;
            mnuluu.Enabled = true;
        }

        private void mnuluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaBP.Text == string.Empty || txtTenBP.Text == string.Empty)
                {
                    string message = "Hãy điền dữ liệu đầy đủ";
                    MessageBoxCustom frm = new MessageBoxCustom();
                    frm.message(message);
                    frm.ShowDialog();
                    return;
                }
                if (txtMaBP.Enabled)
                {
                    if(bp.ktkc(txtMaBP.Text) == 0)
                    {
                        if (bp.Insert(txtMaBP.Text, txtTenBP.Text))
                        {
                            string message = "Thêm thành công.";
                            MessageBoxThanhCong frm = new MessageBoxThanhCong();
                            frm.message(message);
                            frm.ShowDialog();
                            BoPhanGUI_Load(sender, e);
                        }
                        else
                        {
                            string message = "Tên bộ phận đã tồn tại.";
                            MessageBoxCustom frm = new MessageBoxCustom();
                            frm.message(message);
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        string message = "Mã bộ phận đã tồn tại.";
                        MessageBoxCustom frm = new MessageBoxCustom();
                        frm.message(message);
                        frm.ShowDialog();
                    }
                }
                else
                {
                    if (bp.Update(txtMaBP.Text, txtTenBP.Text))
                    {
                        string message = "Sửa thành công.";
                        MessageBoxThanhCong frm = new MessageBoxThanhCong();
                        frm.message(message);
                        frm.ShowDialog();
                        BoPhanGUI_Load(sender, e);
                    }
                    else
                    {
                        string message = "Tên bộ phận đã tồn tại.";
                        MessageBoxCustom frm = new MessageBoxCustom();
                        frm.message(message);
                        frm.ShowDialog();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tên bộ phận đã tồn tại");
            }
            
        }

        private void mnusua_Click(object sender, EventArgs e)
        {
            mnuluu.Enabled = true;
            mnusua.Enabled = false;
            txtTenBP.Enabled = true;
        }

        private void dgvBoPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBP.Enabled = txtTenBP.Enabled = false;
            mnusua.Enabled = mnuxoa.Enabled = true;
            txtMaBP.Text = dgvBoPhan.CurrentRow.Cells[0].Value.ToString();
            txtTenBP.Text = dgvBoPhan.CurrentRow.Cells[1].Value.ToString();
        }

        private void mnuxoa_Click(object sender, EventArgs e)
        {
            if (dgvBoPhan.SelectedRows == null)
            {
                string message = "Mời bạn chọn dòng cần xóa.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            if(bp.Delete(txtMaBP.Text))
            {
                string message = "Xóa thành công.";
                MessageBoxThanhCong frm = new MessageBoxThanhCong();
                frm.message(message);
                frm.ShowDialog();
                BoPhanGUI_Load(sender, e);
            }
            else
            {
                string message = "Không thể xóa được.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
            }
        }

        private void mnuDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
