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
    public partial class Home : Form
    {
        NhanVien nv = new NhanVien();
        QL_PhanQuyen ql = new QL_PhanQuyen();
        public static string TenDN = string.Empty;
        public Home()
        {
            InitializeComponent();
        }

        //public Color SelectThemeColor()
        //{
        //    int index = random.Next(ThemeColor.ColorList.Count);
        //    while(temIndex == index)
        //    {
        //        random.Next(ThemeColor.ColorList.Count);
        //    }
        //    temIndex = index;
        //    string color = ThemeColor.ColorList[index];
        //    return ColorTranslator.FromHtml(color);
        //}

        //public void ActiveButton(object btnSender)
        //{
        //    if(btnSender != null)
        //    {
        //        if(current != (Button)btnSender)
        //        {
        //            DisableButton();
        //            Color color = SelectThemeColor();
        //            current = (Button)btnSender;
        //            current.BackColor = color;
        //            current.ForeColor = Color.White;
        //            current.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        //        }
        //    }
        //}

        //public void DisableButton()
        //{
        //   foreach(Control prev in panellogo.Controls)
        //    {
        //        if(prev.GetType() == typeof(Button))
        //        {
        //            prev.BackColor = Color.FromArgb(39, 39, 58);
        //            prev.ForeColor = Color.Gainsboro;
        //            prev.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        //        }
        //    }
        //}

        public void customize()
        {
            panelNghiepVu.Visible = false;
            panelDM.Visible = false;
        }

        public void hideMenu()
        {
            if (panelDM.Visible == true)
                panelDM.Visible = false;
            if (panelNghiepVu.Visible == true)
                panelNghiepVu.Visible = false;
        }

        public void Showmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatHangGUI dh = new DatHangGUI();
            dh.Show();
        }
        
        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            BanHangGUI bh = new BanHangGUI();
            bh.ShowDialog();
        }

        private void mnuDatHang_Click(object sender, EventArgs e)
        {
            DatHangGUI dh = new DatHangGUI();
            dh.ShowDialog();
        }

        private void bảngGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMuc.BangGiaGUI bg = new DanhMuc.BangGiaGUI();
            bg.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMuc.SanPhamGUI frmsp = new DanhMuc.SanPhamGUI();
            frmsp.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            Showmenu(panelDM);
            
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            hideMenu();
            lalTieuDe.Text = btnNhanVien.Text;
            openChildForm(new DanhMuc.NhanVienGUI());
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            hideMenu();
            lalTieuDe.Text = btnSP.Text;
            openChildForm(new DanhMuc.SanPhamGUI());
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            hideMenu();
            lalTieuDe.Text = btnNCC.Text;
            openChildForm(new DanhMuc.NhaCungCapGUI());
        }

        private void btnGia_Click(object sender, EventArgs e)
        {
            hideMenu();
            lalTieuDe.Text = btnGia.Text;
            openChildForm(new DanhMuc.BangGiaGUI());
        }

        private void btnNghiepVu_Click(object sender, EventArgs e)
        {
            Showmenu(panelNghiepVu);
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            BanHangGUI frm = new BanHangGUI();
            frm.ShowDialog();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            DatHangGUI frm = new DatHangGUI();
            frm.ShowDialog();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            NhapHangGUI frm = new NhapHangGUI();
            frm.ShowDialog();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            hideMenu();
            lalTieuDe.Text = btnHome.Text;
            Home frm = new Home();
            frm.Show();
            this.Hide();
        }
        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            hideMenu();
            lalTieuDe.Text = btnDoanhthu.Text;
            openChildForm(new DoanhThuGUI());
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            hideMenu();
            lalTieuDe.Text = btnPhanQuyen.Text;
            openChildForm(new QL_PhanQuyenGUI());
        }

        private void btnHoTro_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap frm = new DangNhap();
            frm.Show();
        }
        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            hideMenu();
            lalTieuDe.Text = btnLoaiSP.Text;
            openChildForm(new DanhMuc.LoaiSPGUI());
        }
        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            hideMenu();
            lalTieuDe.Text = btnBoPhan.Text;
            openChildForm(new DanhMuc.BoPhanGUI());
        }

        private void btnManHinh_Click(object sender, EventArgs e)
        {
            hideMenu();
            lalTieuDe.Text = btnManHinh.Text;
            openChildForm(new DM_ManHinhGUI());
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblTenNV.Text = nv.layTenNV(Home.TenDN);
            List<string> nhomND = nv.getBoPhan(TenDN);
            foreach (string item in nhomND)
            {
                DataTable dsQuyen = ql.getManHinh(item);
                foreach (DataRow mh in dsQuyen.Rows)
                {
                    FindMenuPhanQuyen(this.panellogo, mh[1].ToString(), Convert.ToBoolean(mh[2].ToString()));
                }
            }

        }
        private void FindMenuPhanQuyen(Panel mnuItems, string pScreenName, bool pEnable)
        {
            foreach (Control menu in mnuItems.Controls)
            {
                if (menu is Panel)
                {
                    FindMenuPhanQuyen(panelDM, pScreenName, pEnable);
                    FindMenuPhanQuyen(panelNghiepVu, pScreenName, pEnable);
                    menu.Enabled = CheckAllMenuChildVisible(panelDM);
                    menu.Enabled = CheckAllMenuChildVisible(panelNghiepVu);
                    menu.Visible = menu.Enabled;
                    customize();
                }
                else if (string.Equals(pScreenName.Trim(), menu.Tag))
                {
                    menu.Enabled = pEnable;
                    menu.Visible = pEnable;
                    customize();
                }
            }
        }

        private bool CheckAllMenuChildVisible(Panel mnuItems)
        {
            foreach (Control menuItem in mnuItems.Controls)
            {
                if (menuItem is Button && menuItem.Enabled)
                {
                    return true;
                }
                else if (menuItem is Panel)
                {
                    continue;
                }
            }
            return false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTuVan_Click(object sender, EventArgs e)
        {
            hideMenu();
            lalTieuDe.Text = btnTuVan.Text;
            openChildForm(new TuVanGUI());

        }

        private void btnDonOnline_Click(object sender, EventArgs e)
        {
            hideMenu();
            lalTieuDe.Text = btnDonOnline.Text;
            openChildForm(new QuanLyDonHangOnline());
        }
    }
}
