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
    public class CT_HoaDonDAL
    {
        public CT_HoaDonDAL()
        {
   
        }
        CT_HOADONTableAdapter cthd = new CT_HOADONTableAdapter();
        BangTamCTHDTableAdapter bt = new BangTamCTHDTableAdapter();
        ThoiTrangDataContext context = new ThoiTrangDataContext();
        public bool insertCTHD(int mahd,string masp,int sl,int gia,int thanhtien)
        {
            try
            {
                if (cthd.Insert(mahd, masp, sl, gia, thanhtien)>0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        public int layMaCTHD(int mahd,string masp)
        {
            return int.Parse(cthd.LayMaCTHD(mahd, masp).ToString());

        }
        public bool deleteCTHD(int macthd)
        {
            try
            {
                if (cthd.XoaCTHD(macthd) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        public bool SuaCTHD(int macthd,int sl,int gia,int tt)
        {
            try
            {
                //int kq = cthd.UpdateCTHD(sl, gia, tt, macthd);
                if (cthd.UpdateCTHD(sl, gia, tt, macthd)>0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        public DataTable loadCTHD(int mahd)
        {
            return bt.GetDataDK(mahd);
        }
        public void LoadctHD(DataGridView dgv,int mahd)
        {
            var cthds = from cthd in context.CT_HOADONs join k in context.SANPHAMs on cthd.MASP equals k.MASP where cthd.MAHD == mahd select new { ma = cthd.MASP, ten = k.TENSP, sl = cthd.SOLUONG, gb = cthd.GIABAN, tt = cthd.THANHTIEN };
            dgv.DataSource = cthds;
        }
    }
}
