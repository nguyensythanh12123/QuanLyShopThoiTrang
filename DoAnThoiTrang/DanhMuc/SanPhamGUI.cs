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
    public partial class SanPhamGUI : Form
    {
        public SanPhamGUI()
        {
            InitializeComponent();
        }
        NhaCungCap ncc = new NhaCungCap();
        LoaiSP lsp = new LoaiSP();
        SanPham sp = new SanPham();
        string location = @"D:\ITTC\Nam3\HK2\Kiem tra chuc luong phan mem\Do An\DoAnThoiTrang\Image\Image\";
        private void SanPhamGUI_Load(object sender, EventArgs e)
        {
            cbbncc.DataSource = ncc.getNCC();
            cbbncc.DisplayMember = "TENNCC";
            cbbncc.ValueMember = "MANCC";
            cbbloai.DataSource = lsp.getLoaiSP();
            cbbloai.DisplayMember = "TENLOAI";
            cbbloai.ValueMember = "MALOAI";
            sp.getSanPham(dgvSanPham);
            txtmasp.Enabled = txtmota.Enabled = txtsl.Enabled = txttensp.Enabled = cbbloai.Enabled = cbbncc.Enabled  = false;
            mnuluu.Enabled = mnusua.Enabled = mnuxoa.Enabled = false;
            txtmasp.Clear(); txtmota.Clear(); txtsl.Clear(); txttensp.Clear(); cbbloai.ResetText(); cbbncc.ResetText();
            mnuthem.Enabled = true;
        }

        string nameImag = "";
        string nameImagct = "";
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                nameImag = System.IO.Path.GetFileName(filename);
                picAnh.ImageLocation = filename;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Image Files(*.jpg)| *.jpg";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog2.FileName;
                nameImagct = System.IO.Path.GetFileName(filename);
                picanhct.ImageLocation = filename;
            }
        }




        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mnusua.Enabled = mnuxoa.Enabled = true;
                mnuthem.Enabled = true;
                txtmasp.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
                txttensp.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
                txtmota.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
                txtsl.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
                cbbncc.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
                cbbloai.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();
                string img = dgvSanPham.CurrentRow.Cells[7].Value.ToString();
                string imgct = dgvSanPham.CurrentRow.Cells[8].Value.ToString();
                picAnh.ImageLocation = location + img;
                picanhct.ImageLocation = location + imgct;
            }
            catch
            {
                picAnh.ImageLocation = picanhct.ImageLocation = null;
            }
        }

        private void mnuthem_Click(object sender, EventArgs e)
        {
            txtmasp.Enabled = txtmota.Enabled = txtsl.Enabled = txttensp.Enabled = cbbloai.Enabled = cbbncc.Enabled = true;
            mnuluu.Enabled = true;
            mnuthem.Enabled = false;
            txtmasp.Clear(); txtmota.Clear(); txtsl.Clear(); txttensp.Clear();
            cbbloai.ResetText(); cbbncc.ResetText();
            picAnh.ImageLocation = picanhct.ImageLocation = null;

        }

        private void mnuluu_Click(object sender, EventArgs e)
        {
            if (txtmasp.Text == string.Empty || txtmota.Text == string.Empty || txtsl.Text == string.Empty || txttensp.Text == string.Empty || cbbloai.Text == string.Empty
               || cbbncc.Text == string.Empty)
            {
                string message = "Mời bạn nhập thông tin đầy đủ";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            if (txtmasp.Enabled)
            {
                if (sp.Insert(txtmasp.Text, txttensp.Text, txtmota.Text, int.Parse(txtsl.Text), cbbncc.SelectedValue.ToString(), cbbloai.SelectedValue.ToString(), nameImag, nameImagct))
                {
                    string message = "Thêm thành công.";
                    MessageBoxThanhCong frm = new MessageBoxThanhCong();
                    frm.message(message);
                    frm.ShowDialog();
                    sp.getSanPham(dgvSanPham);
                    SanPhamGUI_Load(sender, e);

                }
                else
                {
                    string message = "Mã sản phẩm đã tồn tại.";
                    MessageBoxCustom frm = new MessageBoxCustom();
                    frm.message(message);
                    frm.ShowDialog();
                }
            }
            else
            {
                if (sp.Update(txtmasp.Text, txttensp.Text, txtmota.Text, int.Parse(txtsl.Text), cbbncc.SelectedValue.ToString(), cbbloai.SelectedValue.ToString(), nameImag, nameImagct))
                {
                    string message = "Sửa thành công.";
                    MessageBoxThanhCong frm = new MessageBoxThanhCong();
                    frm.message(message);
                    frm.ShowDialog();
                    SanPhamGUI_Load(sender, e);
                    txtmasp.Clear(); txtmota.Clear(); txtsl.Clear(); txttensp.Clear();
                    cbbloai.ResetText(); cbbncc.ResetText();
                    picAnh.ImageLocation = picanhct.ImageLocation = null;
                }
                else
                {
                    string message = "Sửa thất bại";
                    MessageBoxCustom frm = new MessageBoxCustom();
                    frm.message(message);
                    frm.ShowDialog();
                }
            }
        }

        private void mnusua_Click_1(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows == null)
            {
                string message = "Mời bạn chọn sản phẩm cần sửa";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
            }
            else
            {
                mnuluu.Enabled = true;
                mnusua.Enabled = false;
                txtmota.Enabled = txtsl.Enabled = txttensp.Enabled = cbbloai.Enabled = cbbncc.Enabled = true;
            }
        }

        private void mnuxoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows == null)
            {
                string message = "Mời bạn chọn sản phẩm cần xóa";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
            }
            else
            {
                if (sp.Delete(txtmasp.Text))
                {
                    string message = "Xóa thành công.";
                    MessageBoxThanhCong frm = new MessageBoxThanhCong();
                    frm.message(message);
                    frm.ShowDialog();
                    SanPhamGUI_Load(sender, e);
                    txtmasp.Clear(); txtmota.Clear(); txtsl.Clear(); txttensp.Clear();
                    cbbloai.ResetText(); cbbncc.ResetText();
                    picAnh.ImageLocation = picanhct.ImageLocation = null;
                }
                else
                {
                    string message = "Không xóa được";
                    MessageBoxCustom frm = new MessageBoxCustom();
                    frm.message(message);
                    frm.ShowDialog();
                }
            }
            
        }

        private void mnuDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
