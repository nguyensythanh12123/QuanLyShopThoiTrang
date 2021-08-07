using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThuVien
{
    public class NhapSoNguyenThuc
    {
        //public string txtSo { get; set; }
        public bool kiemTraSo(string so)
        {
            
            char[] kq = so.ToArray();
            for (int i = 0; i < kq.Length; i++)
                if (!char.IsNumber(kq[i]))
                    return false;
            return true;
        }
        public bool ktraKyTu(string txtSo)
        {
            char[] tachC = txtSo.ToCharArray();
            bool kq = false;
            int dem = 0;
            for (int i = 0; i < txtSo.Length; i++)
            {
                if (i > 0 && tachC[i] == '-')
                {
                    return false;
                }
                else if (tachC[0] == '.' || (i == txtSo.Length - 1 && tachC[i] == '.')
                            || (i > 0 && tachC[i] == '.'))
                {
                    dem++;
                    if (dem == 2)
                    {
                        return false;
                    }
                }
                else
                {
                    kq = true;
                }
            }
            return kq;
        }
        public bool kiemtrasoNT(string txtSo)
        {
            //^[+-]?\d*\.\d+$|^[+-]?\d+(\.\d*)?$
            Regex _regex = new Regex(@"^[+-]?\d*\.\d+$|^[+-]?\d+(\.\d*)?$");
            if (_regex.IsMatch(txtSo))
                return true;
            return false;
        }
    }
}
