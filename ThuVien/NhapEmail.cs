using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    public class NhapEmail
    {
        public string ChuoiEmail { get; set; }
        public bool kiemTraEmail()
        {
            if (ChuoiEmail.Contains("@gmail.com"))
                return true;
            else
                return false;
        }
    }
}
