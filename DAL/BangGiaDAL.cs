using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.ShopThoiTrangTableAdapters;

namespace DAL
{
    public class BangGiaDAL
    {
        public BangGiaDAL()
        {

        }
        BangGiaTableAdapter bg = new BangGiaTableAdapter();
        BangGiaTamTableAdapter bgt=new BangGiaTamTableAdapter();
        public DataTable getGiaNhap(string masp)
        {
            return bg.GetDataByGia(masp);
        }
        public DataTable getBangGia(string MaSP)
        {
            return bgt.GetDatabg(MaSP);
        }
        public DataTable getAllGia()
        {
            return bgt.GetDataBybg();
        }
        public bool Them(string MaSP,DateTime NgayCN,int GiaBan,int GiaNhap)
        {
            try
            {
                if (bg.Insert(MaSP, NgayCN, GiaBan, GiaNhap) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Xoa(string MaSP,DateTime NgayCN)
        {
            try
            {
                if (bg.DeleteQuery(MaSP,NgayCN) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string MaSP,DateTime ngaycn,int giaban,int gianhap)
        {
            try
            {
                if (bg.UpdateQuery(giaban,gianhap,MaSP,ngaycn) > 0)
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
