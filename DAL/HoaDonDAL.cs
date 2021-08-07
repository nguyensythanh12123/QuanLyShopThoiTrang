using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.ShopThoiTrangTableAdapters;
using System.Windows.Forms;

namespace DAL
{
    public class HoaDonDAL
    {
        public HoaDonDAL()
        {

        }
        HOADONTableAdapter hd = new HOADONTableAdapter();
        ThoiTrangDataContext context = new ThoiTrangDataContext();
        public DataTable LayHDTheoNgay(string ngaylap)
        {
            return hd.GetDataBydk(ngaylap);
        }
        public bool insertHD(int makh,string manv,DateTime Ngaytao,int tongtien,string tt)
        {
            try
            {
                if (hd.Insert(makh, manv, Ngaytao, tongtien, tt) == 1)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        public bool UpdateTinhTrang(int maHD,string TT)
        {
            try
            {
                if (hd.UpdateTinhTrang(TT,maHD) > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        public int layHoaDonMax()
        {
            return int.Parse(hd.LayMaxHD().ToString());
        }
        public void LoadAllHD(DataGridView dgv,DateTime Ngay1,DateTime Ngay2)
        {
            var hds = from hd in context.HOADONs join k in context.NHANVIENs on hd.MANV equals k.MANV where hd.NGAYTAO>=Ngay1 && hd.NGAYTAO<=Ngay2 select new
                        {MAHD=hd.MAHD,TENNV=k.TENNV,NGAYTAO=hd.NGAYTAO,hd.THANHTOAN};
            dgv.DataSource = hds;
        }
        public bool UpdateTT(int MaHD,int tongtien,string MaNV)
        {
            if (hd.UpdateTongTien(tongtien,MaNV, MaHD) > 0)
                return true;
            return false;
        }
        public DataTable getSearch(int MaHD)
        {
            return hd.GetDataBySrch(MaHD);
        }
        public DataTable GetDataTheoTTrang()
        {
            return hd.GetDataByTT();
        }
    }
}
