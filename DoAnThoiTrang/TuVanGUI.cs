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
    public partial class TuVanGUI : Form
    {
        public TuVanGUI()
        {
            InitializeComponent();
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

        ID3 id3 = new ID3();
        private void mnuthem_Click(object sender, EventArgs e)
        {
            if (id3.ThuatToan(txtcannang.Text, txttuoi.Text, txtchieucao.Text) == 1)
            {
                string message = "Size phù hợp với bạn là: XL";
                MessageBox_KetQUa frm = new MessageBox_KetQUa();
                frm.message(message);
                frm.ShowDialog();
            }
            else if (id3.ThuatToan(txtcannang.Text, txttuoi.Text, txtchieucao.Text) == 2)
            {
                string message = "Size phù hợp với bạn là: L";
                MessageBox_KetQUa frm = new MessageBox_KetQUa();
                frm.message(message);
                frm.ShowDialog();
            }
            else if (id3.ThuatToan(txtcannang.Text, txttuoi.Text, txtchieucao.Text) == 3)
            {
                string message = "Size phù hợp với bạn là: M";
                MessageBox_KetQUa frm = new MessageBox_KetQUa();
                frm.message(message);
                frm.ShowDialog();
            }
            else if (id3.ThuatToan(txtcannang.Text, txttuoi.Text, txtchieucao.Text) == 4)
            {
                string message = "Size phù hợp với bạn là: S";
                MessageBox_KetQUa frm = new MessageBox_KetQUa();
                frm.message(message);
                frm.ShowDialog();
            }
            else if (id3.ThuatToan(txtcannang.Text, txttuoi.Text, txtchieucao.Text) == 5)
            {
                string message = "Size phù hợp với bạn là: XXXL";
                MessageBox_KetQUa frm = new MessageBox_KetQUa();
                frm.message(message);
                frm.ShowDialog();
            }
            else if (id3.ThuatToan(txtcannang.Text, txttuoi.Text, txtchieucao.Text) == 6)
            {
                string message = "Size phù hợp với bạn là: XXL";
                MessageBox_KetQUa frm = new MessageBox_KetQUa();
                frm.message(message);
                frm.ShowDialog();
            }
            else
            {
                string message = "Không có kết quả";
                MessageBox_KetQUa frm = new MessageBox_KetQUa();
                frm.message(message);
                frm.ShowDialog();
            }
            
        }
    }
}
