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
    public partial class LoaiSPGUI : Form
    {
        public LoaiSPGUI()
        {
            InitializeComponent();
        }
        LoaiSP lsp = new LoaiSP();
        private void mnuthem_Click(object sender, EventArgs e)
        {
            txtma.Clear();
            txtten.Clear();
            mnuthem.Enabled = false;
            mnuluu.Enabled = txtten.Enabled = txtma.Enabled = true;
            mnuxoa.Enabled = mnusua.Enabled = false;
        }

        private void LoaiSP_GUI_Load(object sender, EventArgs e)
        {
            mnuthem.Enabled = true;
            txtma.Clear();
            txtten.Clear();
            txtma.Enabled = txtten.Enabled = false;
            mnusua.Enabled = mnuxoa.Enabled = mnuluu.Enabled = false;
            dgvloaisp.ReadOnly = true;
            dgvloaisp.DataSource = lsp.getLoaiSP();
        }

        private void mnuluu_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txtma.Text == string.Empty || txtten.Text == string.Empty)
                {
                    MessageBox.Show("Mời bạn nhập dữ liệu");
                    return;
                }
                if (txtma.Enabled)
                {
                    if (lsp.Insert(txtma.Text, txtten.Text))
                    {
                        MessageBox.Show("Thêm thành công");
                        LoaiSP_GUI_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Khóa ngoại hoặc khóa chính chưa ok lắm");
                    }
                }
                else
                {
                    if(lsp.Update(txtma.Text,txtten.Text))
                    {
                        MessageBox.Show("Sửa Thành Công");
                        LoaiSP_GUI_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thất Bại");
                    }
                }
            //}
            //catch
            //{
            //    return;
            //} 
        }

        private void mnuxoa_Click(object sender, EventArgs e)
        {
            if (dgvloaisp.SelectedRows == null)
            {
                MessageBox.Show("Mời bạn chọn dòng cần xóa");
            }
            else
            {
                if(lsp.Delete(txtma.Text))
                {
                    MessageBox.Show("Xóa Thành Công");
                    LoaiSP_GUI_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không thể xóa được ");
                }
            }
        }

        private void dgvloaisp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dgvloaisp.CurrentRow.Cells[0].Value.ToString();
            txtten.Text = dgvloaisp.CurrentRow.Cells[1].Value.ToString();
            mnuxoa.Enabled = mnusua.Enabled = mnuthem.Enabled = true;
        }

        private void mnusua_Click(object sender, EventArgs e)
        {
            if (dgvloaisp.SelectedRows == null)
            {
                MessageBox.Show("Mời bạn chọn dòng cần xóa");
            }
            else
            {
                mnuluu.Enabled = true;
                mnuthem.Enabled = true;
                mnusua.Enabled = false;
                txtten.Enabled = true;
            }
        }

        private void mnuDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
