using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.ShopThoiTrangTableAdapters;

namespace DAL
{
    public class BoPhanDAL
    {
        public BoPhanDAL()
        {

        }
        BOPHANTableAdapter bp=new BOPHANTableAdapter();
        public DataTable GetBP()
        {
            return bp.GetData();
        }
        public bool Them(string MaBP,string tenBP)
        {
            try
            {
                if (bp.Insert(MaBP, tenBP) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string MaBP,string TenBP)
        {
            try
            {
                if (bp.UpdateQuery(TenBP, MaBP) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Xoa(string MaBP)
        {
            try
            {
                if (bp.DeleteQuery(MaBP) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public string layTenBP(string maBP)
        {
            return bp.layTenBP(maBP);
        }

        public int? ktkc(string mabp)
        {
            return bp.KTKC(mabp);
        }
    }
}
