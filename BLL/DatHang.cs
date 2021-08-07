using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class DatHang
    {
        public DatHang()
        {

        }
        DatHangDAL dh = new DatHangDAL();
        public DataTable LayDatHangNgay(DateTime NgayLap)
        {
            return dh.layMaDHtheoNgay(NgayLap);
        }
        public string LayMaDHMax()
        {
            return dh.LayMDHMax();
        }
        public string LayMaNCC(string MaDH)
        {
            return dh.layMaNCC(MaDH);
        }
        public bool insert(string madh, string manv, string mancc, DateTime ngaydat, DateTime ngaygiao, int tiendat, string ttGiao)
        {
            return dh.Them(madh, manv, mancc, ngaydat, ngaygiao, tiendat, ttGiao);         
        }
        public DataTable loadData(string madh)
        {
            return dh.loaddata(madh);
        }
        public DataTable GetMaDH(string MaNCC)
        {
            return dh.getMaDHTheoNCC(MaNCC);
        }
        public bool UpdateTT(string MaDH)
        {
            return dh.suaTT(MaDH);
        }
        public bool SuaTongTienDat(string MaDH,int TD)
        {
            return dh.suaTienDat(MaDH, TD);
        }
    }
}
