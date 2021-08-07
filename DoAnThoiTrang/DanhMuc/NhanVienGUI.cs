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
    public partial class NhanVienGUI : Form
    {
        public NhanVienGUI()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        BoPhan bp = new BoPhan();
        private void NhanVienGUI_Load(object sender, EventArgs e)
        {
            Column7.DataSource = bp.GetBoPhan();
            Column7.DisplayMember = "TENBP";
            Column7.ValueMember = "MABP";
            cbbbophan.DataSource = bp.GetBoPhan();
            cbbbophan.DisplayMember = "TENBP";
            cbbbophan.ValueMember = "MABP";
            mnuluu.Enabled = mnusua.Enabled = mnuxoa.Enabled = false;
            mnuthem.Enabled = true;
            dgvnv.DataSource = nv.getNhanVien();
            txtma.Text = "NV0"+(nv.LayMaMax() + 1).ToString();
            txtten.Text = txtngaysinh.Text = txtsdt.Text = txtmatkhau.Text = txtdiachi.Text = cbbgt.Text = cbbbophan.Text = "";
            txtma.Enabled = txtten.Enabled = txtngaysinh.Enabled = txtsdt.Enabled = txtmatkhau.Enabled = txtdiachi.Enabled = cbbgt.Enabled = cbbbophan.Enabled = chkhd.Enabled = false;
        }


        private void txtsdt_Leave(object sender, EventArgs e)
        {
            NhapSoDienThoai nsdt = new NhapSoDienThoai();
            if(nsdt.kiemTraSDT(txtsdt.Text))
            {
                return;
            }
            else
            {
                //MessageBox.Show("Bạn nhập sai số điện thoại rồi.Hãy kiểm tra lại");
                string message = "Bạn nhập sai số điện thoại rồi.Hãy kiểm tra lại";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                txtsdt.Focus();
            }
        }

        private void mnuDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dgvnv.CurrentRow.Cells[0].Value.ToString();
            txtten.Text = dgvnv.CurrentRow.Cells[1].Value.ToString();
            txtngaysinh.Text = DateTime.Parse(dgvnv.CurrentRow.Cells[2].Value.ToString()).ToString("dd/MM/yyyy");
            txtdiachi.Text = dgvnv.CurrentRow.Cells[3].Value.ToString();
            cbbgt.Text = dgvnv.CurrentRow.Cells[4].Value.ToString();
            txtsdt.Text = dgvnv.CurrentRow.Cells[5].Value.ToString();
            cbbbophan.Text = dgvnv.CurrentRow.Cells[6].Value.ToString();
            txtmatkhau.Text = dgvnv.CurrentRow.Cells[7].Value.ToString();
            chkhd.Checked = Convert.ToBoolean(dgvnv.CurrentRow.Cells[8].Value.ToString());
            chkhd.Enabled = txtma.Enabled = txtten.Enabled = txtngaysinh.Enabled = txtsdt.Enabled = txtmatkhau.Enabled = txtdiachi.Enabled = cbbgt.Enabled = cbbbophan.Enabled = false;
            mnusua.Enabled = mnuxoa.Enabled = mnuthem.Enabled = true;

        }

        private void mnuthem_Click(object sender, EventArgs e)
        {
            mnuluu.Enabled = true;
            mnuthem.Enabled = false;
            label8.Visible = true;
            txtmatkhau.Visible = true;
            txtma.Enabled = txtten.Enabled = txtngaysinh.Enabled = txtsdt.Enabled = txtmatkhau.Enabled = txtdiachi.Enabled = cbbgt.Enabled = cbbbophan.Enabled = true;
            txtten.Clear(); txtngaysinh.Clear(); txtsdt.Clear(); txtmatkhau.Clear(); txtdiachi.Clear(); cbbgt.ResetText(); cbbbophan.ResetText();
        }

        private void mnuluu_Click(object sender, EventArgs e)
        {
            ChuyenDoiNgay cn = new ChuyenDoiNgay();
            if (txtma.Text == string.Empty || txtdiachi.Text == string.Empty || txtmatkhau.Text == string.Empty || txtngaysinh.Text == string.Empty || txtsdt.Text == string.Empty || txtten.Text == string.Empty || cbbbophan.Text == string.Empty || cbbgt.Text == string.Empty)
            {
                string message = "Mời bạn nhập dữ liệu đầy đủ.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            if (txtma.Enabled)
            {
                if (nv.Insert(txtma.Text, txtten.Text, Convert.ToDateTime(cn.CDxuoiu(txtngaysinh.Text)), txtdiachi.Text, cbbgt.Text, txtsdt.Text, cbbbophan.SelectedValue.ToString(), txtmatkhau.Text, Convert.ToBoolean(chkhd.Checked)))
                {
                    string message = "Thêm thành công.";
                    MessageBoxThanhCong frm = new MessageBoxThanhCong();
                    frm.message(message);
                    frm.ShowDialog();
                    label8.Visible = false;
                    txtmatkhau.Visible = false;
                    NhanVienGUI_Load(sender, e);
                }
                else
                {
                    string message = "Thêm thất bại.";
                    MessageBoxCustom frm = new MessageBoxCustom();
                    frm.message(message);
                    frm.ShowDialog();
                    NhanVienGUI_Load(sender, e);
                }
            }
            else
            {
                if (nv.Update(txtma.Text, txtten.Text, cn.CDxuoiu(txtngaysinh.Text), txtdiachi.Text, cbbgt.Text, txtsdt.Text, cbbbophan.SelectedValue.ToString(), txtmatkhau.Text, Convert.ToBoolean(chkhd.Checked)))
                {
                    string message = "Sửa thành công.";
                    MessageBoxThanhCong frm = new MessageBoxThanhCong();
                    frm.message(message);
                    frm.ShowDialog();
                    NhanVienGUI_Load(sender, e);
                }
                else
                {
                    string message = "Sửa thất bại";
                    MessageBoxCustom frm = new MessageBoxCustom();
                    frm.message(message);
                    frm.ShowDialog();
                    NhanVienGUI_Load(sender, e);
                }
            }
        }

        private void mnusua_Click(object sender, EventArgs e)
        {
            if (txtma.Text == string.Empty || txtdiachi.Text == string.Empty || txtmatkhau.Text == string.Empty || txtngaysinh.Text == string.Empty || txtsdt.Text == string.Empty || txtten.Text == string.Empty || cbbbophan.Text == string.Empty || cbbgt.Text == string.Empty)
            {
                string message = "Mời bạn nhập dữ liệu đầy đủ";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            mnusua.Enabled = false;
            mnuluu.Enabled = true;
            chkhd.Enabled = txtten.Enabled = txtngaysinh.Enabled = txtsdt.Enabled = txtmatkhau.Enabled = txtdiachi.Enabled = cbbgt.Enabled = cbbbophan.Enabled = true;
        }

        private void mnuxoa_Click(object sender, EventArgs e)
        {
            if (txtma.Text == string.Empty || txtdiachi.Text == string.Empty || txtmatkhau.Text == string.Empty || txtngaysinh.Text == string.Empty || txtsdt.Text == string.Empty || txtten.Text == string.Empty || cbbbophan.Text == string.Empty || cbbgt.Text == string.Empty)
            {
                string message = "Mời bạn nhập dữ liệu đầy đủ";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                return;
            }
            if (nv.Delete(txtma.Text))
            {
                string message = "Sửa thành công.";
                MessageBoxThanhCong frm = new MessageBoxThanhCong();
                frm.message(message);
                frm.ShowDialog();
                NhanVienGUI_Load(sender, e);
            }
            else
            {
                string message = "Xóa thất bại";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                NhanVienGUI_Load(sender, e);
            }
        }
    }
}
