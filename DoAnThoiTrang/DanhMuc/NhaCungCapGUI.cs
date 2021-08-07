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

namespace DoAnThoiTrang.DanhMuc
{
    public partial class NhaCungCapGUI : Form
    {
        public NhaCungCapGUI()
        {
            InitializeComponent();
        }
        NhaCungCap ncc = new NhaCungCap();
        private void NhaCungCapGUI_Load(object sender, EventArgs e)
        {
            txtdiachi.Enabled = txtNhaCC.Enabled = txtsdt.Enabled = txtTenncc.Enabled  = false;
            mnuluu.Enabled = mnusua.Enabled = mnuxoa.Enabled = false;
            mnuthem.Enabled = true;
            dgvncc.DataSource = ncc.getNCC();
            txtdiachi.Text = txtNhaCC.Text = txtsdt.Text = txtTenncc.Text = "";
        }

        private void mnuthem_Click(object sender, EventArgs e)
        {
            txtdiachi.Text = txtNhaCC.Text = txtsdt.Text = txtTenncc.Text = "";
            mnuthem.Enabled = false;
            txtdiachi.Enabled = txtNhaCC.Enabled = txtsdt.Enabled = txtTenncc.Enabled = true;
            mnuluu.Enabled = true;
            mnusua.Enabled = mnuxoa.Enabled = false;
        }

        private void mnuluu_Click(object sender, EventArgs e)
        {
            if(txtdiachi.Text==string.Empty||txtNhaCC.Text == string.Empty||txtsdt.Text == string.Empty||txtTenncc.Text == string.Empty)
            {
                string message = "Mời bạn nhập dữ liệu đầy đủ.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            if(txtNhaCC.Enabled)
            {
                if(ncc.Insert(txtNhaCC.Text,txtTenncc.Text,txtdiachi.Text,txtsdt.Text))
                {
                    string message = "Thêm thành công.";
                    MessageBoxThanhCong frm = new MessageBoxThanhCong();
                    frm.message(message);
                    frm.ShowDialog();
                    NhaCungCapGUI_Load(sender, e);
                }
                else
                {
                    string message = "Lỗi khóa chính.";
                    MessageBoxCustom frm = new MessageBoxCustom();
                    frm.message(message);
                    frm.ShowDialog();
                }
            }
            else
            {
                if(ncc.Update(txtNhaCC.Text, txtTenncc.Text, txtdiachi.Text, txtsdt.Text))
                {
                    string message = "Sửa thành công.";
                    MessageBoxThanhCong frm = new MessageBoxThanhCong();
                    frm.message(message);
                    frm.ShowDialog();
                    NhaCungCapGUI_Load(sender, e);
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

        private void dgvncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mnusua.Enabled = mnuxoa.Enabled = true;
            txtNhaCC.Text = dgvncc.CurrentRow.Cells[0].Value.ToString();
            txtTenncc.Text = dgvncc.CurrentRow.Cells[1].Value.ToString();
            txtdiachi.Text = dgvncc.CurrentRow.Cells[2].Value.ToString();
            txtsdt.Text = dgvncc.CurrentRow.Cells[3].Value.ToString();
        }

        private void mnusua_Click(object sender, EventArgs e)
        {
            if(dgvncc.SelectedRows==null)
            {
                string message = "Mời bạn chọn dòng cần sửa.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
            }
            else
            {
                mnusua.Enabled = false;
                mnuluu.Enabled = true;
                txtdiachi.Enabled = txtsdt.Enabled = txtTenncc.Enabled = true;
            }
        }

        private void mnuxoa_Click(object sender, EventArgs e)
        {
            if (dgvncc.SelectedRows == null)
            {
                string message = "Mời bạn chọn dòng cần xóa.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
            }
            else
            {
                if (ncc.Delete(txtNhaCC.Text))
                {
                    string message = "Xóa thành công.";
                    MessageBoxThanhCong frm = new MessageBoxThanhCong();
                    frm.message(message);
                    frm.ShowDialog();
                    NhaCungCapGUI_Load(sender, e);
                }
                else
                {
                    string message = "Xóa thất bại.";
                    MessageBoxCustom frm = new MessageBoxCustom();
                    frm.message(message);
                    frm.ShowDialog();
                }

            }
        }

        private void txtsdt_Leave(object sender, EventArgs e)
        {
            NhapSoDienThoai ns = new NhapSoDienThoai();    
            if(ns.kiemTraSDT(txtsdt.Text.Trim()))
            {
                return;
            }
            else
            {
                string message = "Số điện thoại không đúng.";
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
