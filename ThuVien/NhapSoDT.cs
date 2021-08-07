using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public class NhapSoDT:TextBox
    {
        public NhapSoDT()
        {
            this.KeyPress += NhapSoDT_KeyPress;
            this.Leave += NhapSoDT_Leave;
        }

        private void NhapSoDT_Leave(object sender, EventArgs e)
        {
            if (this.Text.Substring(0, 1) == "0" && this.Text.Length == 10)
                return;
            else
            {
                MessageBox.Show("Mời bạn nhập đúng SĐT");
                
            }
        }

        private void NhapSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
