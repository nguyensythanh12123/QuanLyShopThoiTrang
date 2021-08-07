using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class QL_PhanQuyen
    {
        public QL_PhanQuyen()
        {

        }
        QL_PhanQuyenDAL pq = new QL_PhanQuyenDAL();
        public DataTable getManHinh(string MaBP)
        {
            return pq.GetMaManHinh(MaBP);
        }
        public DataTable GetPhanQuyen(string MaBP)
        {
            return pq.getdata(MaBP);
        }
        public bool Update(string MaBP, string MaMH, bool Quyen)
        {
            return pq.Sua(MaBP, MaMH, Quyen);
        }
        public bool KiemTraKC(string MaBP, string MaMH)
        {
            return pq.KiemTraKC(MaBP, MaMH);
        }
        public bool Insert(string MaBP, string MaMH, bool Quyen)
        {
            return pq.Them(MaBP, MaMH, Quyen);
        }
    }
}
