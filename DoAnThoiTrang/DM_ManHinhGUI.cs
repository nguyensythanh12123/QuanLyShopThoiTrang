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
    public partial class DM_ManHinhGUI : Form
    {
        public DM_ManHinhGUI()
        {
            InitializeComponent();
        }
        DM_ManHinh mh = new DM_ManHinh();
        private void DM_ManHinhGUI_Load(object sender, EventArgs e)
        {
            dgvmanhinh.DataSource = mh.getMH();
            btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaMH.Clear();
            txtTenMH.Clear();
            txtMaMH.Enabled = txtTenMH.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaMH.Text==string.Empty || txtTenMH.Text==string.Empty )
            {
                MessageBox.Show("Mời bạn nhập dữ liệu");
                return;
            }
            if (btnThem.Enabled)
            {
                if (mh.Insert(txtMaMH.Text, txtTenMH.Text))
                {
                    MessageBox.Show("Lưu thành công");
                    txtMaMH.Enabled = txtTenMH.Enabled = false;
                    dgvmanhinh.DataSource = mh.getMH();
                }
                else
                {
                    MessageBox.Show("Lưu Thất Bại");
                }
            }
            else
            {
                
                if(mh.Update(txtMaMH.Text,txtTenMH.Text))
                {
                    MessageBox.Show("Sửa Thành Công");
                    dgvmanhinh.DataSource = mh.getMH();
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void dgvmanhinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dgvmanhinh.CurrentRow.Cells[0].Value.ToString();
            txtTenMH.Text = dgvmanhinh.CurrentRow.Cells[1].Value.ToString();
            btnSua.Enabled = btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvmanhinh.SelectedRows==null)
            {
                MessageBox.Show("Mời bạn chọn dòng cần xóa");
                return;
            }
            if(mh.Delete(txtMaMH.Text))
            {
                MessageBox.Show("Xóa thành công");
                dgvmanhinh.DataSource = mh.getMH();
                txtMaMH.Clear();
                txtTenMH.Clear();
                btnXoa.Enabled = false;

            }
            else
            {
                MessageBox.Show("Xóa Thất Bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvmanhinh.SelectedRows == null)
            {
                MessageBox.Show("Mời bạn chọn dòng cần xóa");
                return;
            }
            btnLuu.Enabled = true;
            txtMaMH.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
