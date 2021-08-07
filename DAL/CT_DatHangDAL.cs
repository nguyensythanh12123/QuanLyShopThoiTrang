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
    public class CT_DatHangDAL
    {
        public CT_DatHangDAL()
        {

        }
        CT_DATHANGTableAdapter ct = new CT_DATHANGTableAdapter();
        ThoiTrangDataContext ttrang = new ThoiTrangDataContext();
        DataTable1TableAdapter bt = new DataTable1TableAdapter();
        BangTamNhapHang1TableAdapter1 btnh = new BangTamNhapHang1TableAdapter1();
        public int LayMaCTDH(string madh,string masp)
        {
            return int.Parse(ct.LayMaCTDH(madh, masp).ToString());
        }
        
        public bool themCTDH(string madh,string masp,int sl,int gianhap,int tt,string ghichu)
        {
            try
            {
                if (ct.Insert(madh, masp, sl, gianhap, tt, ghichu) >0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
                  
        }
        public bool XoaCTDH(int macthd)
        {
            try
            {
                if (ct.DeleteCTDH(macthd) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        public bool SuaCTDH(int macthd,int sl,int tt)
        {
            try
            {
                if (ct.UpdateCTDH(sl, tt, macthd) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        public DataTable loadcthd(string madh)
        {
            return bt.GetDatadk(madh);
        }
        //public void loadctdhdal(DataGridView dgv, string madh)
        //{
        //    var ctdhs = from ct in ttrang.CT_DATHANGs join k in ttrang.SANPHAMs on ct.MASP equals k.MASP where ct.MADH == madh select new { msp = ct.MASP, tsp = k.TENSP, sld = ct.SOLUONGDAT, gn = ct.GIANHAP, tt = ct.THANHTIEN,gc=ct.GHICHUGH };

        //    dgv.DataSource = ctdhs;
        //}
        public DataTable LoadDatHangTheoMaDH(string madh)
        {
            return btnh.GetDatadk(madh);
        }    
    }
}
