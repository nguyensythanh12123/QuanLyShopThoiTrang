using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThoiTrang
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        QuanLyNguoiDung CauHinh = new QuanLyNguoiDung();
        Home frm1 = new Home();

        public void ProcessLogin()
        {
            int result;
            result = CauHinh.Check_User(txtTenDN.Text, txtMK.Text);
            //Check_User viết trong Class QL_NguoiDung
            // Wrong username or pass
            if (result == 10)
            {
                //MessageBox.Show("Sai " + labelControl1.Text + " Hoặc " +
                //labelControl2.Text);
                string message = "Sai " + labelControl1.Text.ToLower() + " hoặc " + labelControl2.Text.ToLower();
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                txtTenDN.ResetText();
                txtMK.ResetText();
                return;
            }
            // Account had been disabled
            else if (result == 20)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }

            Home.TenDN = txtTenDN.Text;
            frm1.Show();
            this.Hide();

        }
        public void ProcessConfig()
        {
            //frmConfig frm = new frmConfig();
            //frm.Show();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDN.Text.Trim()))
            {
                //MessageBox.Show("không được bỏ trống" + labelControl1.Text.ToLower());
                string message = "Không được bỏ trống " + labelControl1.Text.ToLower();
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                txtTenDN.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtMK.Text))
            {
                //MessageBox.Show("Không được bỏ trống" + labelControl2.Text.ToLower());
                string message = "Không được bỏ trống " + labelControl2.Text.ToLower();
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
                this.txtMK.Focus();
                return;
            }
            int kq = CauHinh.Check_Config(); //hàm Check_Config() thuộc Class QL_NguoiDung
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                ProcessConfig();
            }

            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                ProcessConfig();
            }
        }

        private void txtTenDN_Click(object sender, EventArgs e)
        {
            txtTenDN.Clear();
            iconPictureBox1.IconColor = Color.FromArgb(33, 252, 234);
            txtTenDN.ForeColor = Color.FromArgb(33, 252, 234);

            iconPictureBox2.IconColor = Color.WhiteSmoke;
            txtMK.ForeColor = Color.WhiteSmoke;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            txtMK.Clear();
            iconPictureBox2.IconColor = Color.FromArgb(33, 252, 234);
            txtMK.ForeColor = Color.FromArgb(33, 252, 234);

            iconPictureBox1.IconColor = Color.WhiteSmoke;
            txtTenDN.ForeColor = Color.WhiteSmoke;
            txtMK.PasswordChar = '*';
        }
    }
}
