using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BoPhan
    {
        public BoPhan()
        {

        }
        BoPhanDAL bp = new BoPhanDAL();
        public DataTable GetBoPhan()
        {
            return bp.GetBP();
        }
        public bool Insert(string MaBP,string TenBP)
        {
            return bp.Them(MaBP, TenBP);
        }
        public bool Update(string MaBP,string TenBP)
        {
            return bp.Sua(MaBP, TenBP);
        }
        public bool Delete(string MaBP)
        {
            return bp.Xoa(MaBP);
        }
        public string layTenBP(string maBP)
        {
            return bp.layTenBP(maBP);
        }
        public int? ktkc(string mabp)
        {
            return bp.ktkc(mabp);
        }
    }
}
