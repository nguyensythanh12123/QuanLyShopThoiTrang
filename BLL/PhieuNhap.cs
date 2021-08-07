using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class PhieuNhap
    {
        PhieunhapDAL pn = new PhieunhapDAL();
        public PhieuNhap()
        {

        }
        public string loadMaPNMax()
        {
            return pn.layMaMax();
        }
        public DataTable getPNTheoNgay(string ngaylap)
        {
            return pn.loadMaPNTheoNgay(ngaylap);
        }
        public bool Insert(string MaPN, string madh, DateTime NgayNhap, int tienNhap,string MaNV)
        {
            return pn.LuuPhieuNhap(MaPN, madh, NgayNhap, tienNhap,MaNV);
        }
        public bool SuaTienNhap(string MaPN,int TN)
        {
            return pn.SuaTienNhap(MaPN, TN);
        }
    }
}
