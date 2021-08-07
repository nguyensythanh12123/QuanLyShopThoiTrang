using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public class TextBoxNhapSo:TextBox
    {
        public  TextBoxNhapSo()
        {
            this.KeyPress += TextBoxNhapSo_KeyPress;
        }

        private void TextBoxNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
