using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.ShopThoiTrangTableAdapters;

namespace DAL
{
    public class DatHangDAL
    {
        public DatHangDAL()
        {

        }
        DATHANGTableAdapter dh = new DATHANGTableAdapter();
        BangTamLayNCCTableAdapter bt = new BangTamLayNCCTableAdapter();
        public DataTable layMaDHtheoNgay(DateTime ngaytao)
        {
            return dh.GetDataBydk(ngaytao);
        }
        public string LayMDHMax()
        {
            return dh.LayMaDHMax().ToString();
        }
        public string layMaNCC(string MADH)
        {
            return dh.LayMaNCC(MADH);
        }
        public bool Them(string madh,string manv,string mancc,DateTime ngaydat,DateTime ngaygiao,int tiendat,string ttGiao)
        {
            try
            {
                if (dh.Insert(madh, manv, mancc, ngaydat, ngaygiao, tiendat, ttGiao)>0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        public bool Update(string madh, string manv, string mancc, DateTime ngaydat, DateTime ngaygiap, int tiendat, string ttGiao)
        {
            try
            {
                if (dh.CapNhatDH(manv, mancc, ngaydat, ngaygiap, tiendat, ttGiao, madh) == 1)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }

        }
        public DataTable loaddata(string madh)
        {
            return bt.GetDataDK(madh);
        }
        public DataTable getMaDHTheoNCC(string MaNCC)
        {
            return dh.GetDataByad(MaNCC);
        }
        public bool suaTT(string MaDH)
        {
            if (dh.UpdateTT(MaDH) > 0)
                return true;
            return false;
        }
        public bool suaTienDat(string MaDH,int TienDat)
        {
            if (dh.UpdateTienDat(TienDat, MaDH) > 0)
                return true;
            return false;
        }
    }
}
