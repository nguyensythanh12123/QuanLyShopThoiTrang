using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class HoaDon
    {
        HoaDonDAL hd = new HoaDonDAL();
        public HoaDon()
        {

        }
        public bool UpdateTinhTrang(int MaHD,string TT)
        {
            return hd.UpdateTinhTrang(MaHD,TT);
        }
        public DataTable LoadHDTheoNgay(string ngaylap)
        {
            return hd.LayHDTheoNgay(ngaylap);
        }
        public bool Them(int makh,string manv,DateTime ngaytao,int tongtien,string tttt)
        {
            return hd.insertHD(makh, manv, ngaytao, tongtien, tttt);
        }
        public int LayHDMax()
        {
            return hd.layHoaDonMax();
        }
        public void LoadDT(DataGridView dgv, DateTime Ngay1, DateTime Ngay2)
        {
            hd.LoadAllHD(dgv, Ngay1, Ngay2);
        }
        public bool UpdateTongTien(int MaHD,int TongTien,string MaNV)
        {
            return hd.UpdateTT(MaHD, TongTien,MaNV);
        }
        public DataTable getSearch(int MaHD)
        {
            return hd.getSearch(MaHD);
        }
        public DataTable LoadDataTinhTrang()
        {
            return hd.GetDataTheoTTrang();
        }
    }
}
