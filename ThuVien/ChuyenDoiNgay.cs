using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    public class ChuyenDoiNgay
    {
        public string CDxuoiu(string ngay)
        {
            string[] kq = ngay.Split('-');
            string year = kq[2];
            string month = kq[1];
            string day = kq[0];
            return year + "-" + month + "-" + day;
        }
    }
}
