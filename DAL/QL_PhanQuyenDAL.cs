using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.ShopThoiTrangTableAdapters;

namespace DAL
{
    public class QL_PhanQuyenDAL
    {
        QL_PHANQUYENTableAdapter pq = new QL_PHANQUYENTableAdapter();
        GetPhanQuyenTamTableAdapter gpq = new GetPhanQuyenTamTableAdapter();

        public QL_PhanQuyenDAL()
        {

        }
        public DataTable GetMaManHinh(string mabp)
        {
            return pq.GetDataByDSMH(mabp);
        }
        public DataTable getdata(string MaBP)
        {
            return gpq.GetData(MaBP);       
        }
        public bool Sua(string MaBP,string MaMH,bool Quyen)
        {
            try
            {
                if (pq.UpdateQuery(Quyen, MaBP, MaMH) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;                    
            }

        }
        public bool KiemTraKC(string MaBP,string MaMH)
        {
            try
            {
                if (pq.KTKC(MaBP, MaMH) > 0)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Them(string MaBP, string MaMH,bool Quyen)
        {
            try
            {
                if (pq.Insert(MaBP, MaMH, Quyen) > 0)
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
