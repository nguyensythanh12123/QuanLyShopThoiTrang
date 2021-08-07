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
    public partial class BangGiaGUI : Form
    {
        public BangGiaGUI()
        {
            InitializeComponent();
        }
        SanPham sp = new SanPham();
        BangGia bg = new BangGia();
        private void mnuthem_Click(object sender, EventArgs e)
        {
            mnuthem.Enabled = false;
            mnuluu.Enabled = true;
            txtgiaban.Enabled = txtgianhap.Enabled = txtNgayCN.Enabled = cbbsp.Enabled = true;
            txtgiaban.ResetText();
            txtgianhap.ResetText();
            //txtNgayCN.ResetText();
            cbbsp.ResetText();
            dgvBangGia.DataSource = bg.getAllGia();
        }

        private void BangGiaGUI_Load(object sender, EventArgs e)
        {
            mnuluu.Enabled = mnusua.Enabled = mnuxoa.Enabled = false;
            mnuthem.Enabled = true;
            txtgiaban.Enabled = txtgianhap.Enabled = txtNgayCN.Enabled = cbbsp.Enabled = false;
            txtgiaban.ResetText();
            txtgianhap.ResetText();
            //txtNgayCN.ResetText();
            cbbsp.DataSource = sp.getSP();
            cbbsp.DisplayMember = "TENSP";
            cbbsp.ValueMember = "MASP";
            txtNgayCN.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm");
            dgvBangGia.DataSource=bg.getAllGia();
            //cbbsp.ResetText();

        }

        private void cbbsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvBangGia.DataSource = bg.getBangGia(cbbsp.SelectedValue.ToString());
        }

        private void mnuluu_Click(object sender, EventArgs e)
        {
            if(cbbsp.Text==string.Empty || txtgiaban.Text==string.Empty ||txtgianhap.Text == string.Empty||txtNgayCN.Text == string.Empty)
            {
                string message = "Mời bạn nhập dữ liệu.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            if(cbbsp.Enabled)
            {
                if(bg.Insert(cbbsp.SelectedValue.ToString(),DateTime.Parse(txtNgayCN.Text),int.Parse(txtgiaban.Text),int.Parse(txtgianhap.Text)))
                {
                    string message1 = "Thêm thành công.";
                    MessageBoxThanhCong frm1 = new MessageBoxThanhCong();
                    frm1.message(message1);
                    frm1.ShowDialog();
                    mnuluu.Enabled = mnusua.Enabled = mnuxoa.Enabled = false;
                    mnuthem.Enabled = true;
                    txtgiaban.Enabled = txtgianhap.Enabled = txtNgayCN.Enabled = cbbsp.Enabled = false;
                    dgvBangGia.DataSource = bg.getBangGia(cbbsp.SelectedValue.ToString());
                    txtNgayCN.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                    if(sp.UpdatePrice(cbbsp.SelectedValue.ToString(),int.Parse(txtgiaban.Text)))
                    {
                        return;
                    }
                    else
                    {
                        string message = "Cập nhật giá thất bại.";
                        MessageBoxCustom frm = new MessageBoxCustom();
                        frm.message(message);
                        frm.ShowDialog();
                    }
                    txtgiaban.ResetText();
                    txtgianhap.ResetText();
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
                if(bg.Update(cbbsp.SelectedValue.ToString(), DateTime.Parse(txtNgayCN.Text), int.Parse(txtgiaban.Text), int.Parse(txtgianhap.Text)))
                {
                   
                    mnuluu.Enabled = mnusua.Enabled = mnuxoa.Enabled = false;
                    mnuthem.Enabled = true;
                    txtgiaban.Enabled = txtgianhap.Enabled = txtNgayCN.Enabled = cbbsp.Enabled = false;

                    dgvBangGia.DataSource = bg.getBangGia(cbbsp.SelectedValue.ToString());
                    txtNgayCN.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                    if (sp.UpdatePrice(cbbsp.SelectedValue.ToString(), int.Parse(txtgiaban.Text)))
                    {
                        string message = "Cập nhật giá thành công.";
                        MessageBoxThanhCong frm = new MessageBoxThanhCong();
                        frm.message(message);
                        frm.ShowDialog();
                    }
                    else
                    {
                        string message1 = "Cập nhật giá thất bại.";
                        MessageBoxCustom frm1 = new MessageBoxCustom();
                        frm1.message(message1);
                        frm1.ShowDialog();
                    }
                    txtgiaban.ResetText();
                    txtgianhap.ResetText();
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

        private void dgvBangGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbsp.Text = dgvBangGia.CurrentRow.Cells[1].Value.ToString();
            txtNgayCN.Text=dgvBangGia.CurrentRow.Cells[2].Value.ToString();
            txtgiaban.Text= dgvBangGia.CurrentRow.Cells[3].Value.ToString();
            txtgianhap.Text= dgvBangGia.CurrentRow.Cells[4].Value.ToString();
            mnusua.Enabled = mnuxoa.Enabled = true;
        }

        private void mnusua_Click(object sender, EventArgs e)
        {
            if(dgvBangGia.SelectedRows==null)
            {
                string message = "Mời bạn chọn dòng cần sửa.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            mnuluu.Enabled = true;
            mnusua.Enabled = false;
            txtgiaban.Enabled = txtgianhap.Enabled = true;
        }

        private void mnuxoa_Click(object sender, EventArgs e)
        {
            if (dgvBangGia.SelectedRows == null)
            {
                string message = "Mời bạn chọn dòng cần sửa.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            if(bg.Delete(cbbsp.SelectedValue.ToString(), DateTime.Parse(txtNgayCN.Text)))
            {
                string message = "Xóa thành công.";
                MessageBoxThanhCong frm = new MessageBoxThanhCong();
                frm.message(message);
                frm.ShowDialog();
                BangGiaGUI_Load(sender, e);
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
