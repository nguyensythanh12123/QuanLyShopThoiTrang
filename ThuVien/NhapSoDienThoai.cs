using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    public class NhapSoDienThoai
    {
        
        public bool kiemTraSo(string sdt)
        {
            char[] kq = sdt.ToArray();
            for (int i = 0; i < kq.Length; i++)
                if (!char.IsNumber(kq[i]))
                    return false;
            return true;
        }
        public bool kiemTraSDT(string SDT)
        {
            if(kiemTraSo(SDT) && SDT.Length==10)
            {
                if (SDT.Substring(0, 3) == "070" || SDT.Substring(0, 3) == "079" || SDT.Substring(0, 3) == "077" || SDT.Substring(0, 3) == "076" || SDT.Substring(0, 3) == "078" || SDT.Substring(0, 3) == "089" || SDT.Substring(0, 3) == "090" || SDT.Substring(0, 3) == "090" ||
                    SDT.Substring(0, 3) == "083" || SDT.Substring(0, 3) == "084" || SDT.Substring(0, 3) == "085" || SDT.Substring(0, 3) == "081" || SDT.Substring(0, 3) == "082" || SDT.Substring(0, 3) == "088" || SDT.Substring(0, 3) == "091" || SDT.Substring(0, 3) == "094" ||
                    SDT.Substring(0, 3) == "032" || SDT.Substring(0, 3) == "033" || SDT.Substring(0, 3) == "034" || SDT.Substring(0, 3) == "035" || SDT.Substring(0, 3) == "036" || SDT.Substring(0, 3) == "037" || SDT.Substring(0, 3) == "038" || SDT.Substring(0, 3) == "039" || SDT.Substring(0, 3) == "096" || SDT.Substring(0, 3) == "097" || SDT.Substring(0, 3) == "098")
                    return true;
            }
            return false;
        }
    }
}
