using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.ShopThoiTrangTableAdapters;

namespace DAL
{
    public class PhieunhapDAL
    {
        public PhieunhapDAL()
        {

        }
        PHIEUNHAPTableAdapter pn = new PHIEUNHAPTableAdapter();
        public string layMaMax()
        {
            return pn.LayMaPNMax().ToString();
        }
        public DataTable loadMaPNTheoNgay(string NgayLap)
        {
            return pn.GetDataBydk(NgayLap);
        }
        public bool LuuPhieuNhap(string MAPN,string madh,DateTime NgayNhap,int tienNhap,string MaNV)
        {
            try
            {
                if (pn.Insert(MAPN, madh, NgayNhap, tienNhap,MaNV) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaTienNhap(string MaPN,int TienNhap)
        {
                try
                {
                    if (pn.SuaTienNhap(TienNhap, MaPN) > 0)
                        return true;
                    return false;
                }
                catch
                {
                    return false;
                }
        }
    }
}
