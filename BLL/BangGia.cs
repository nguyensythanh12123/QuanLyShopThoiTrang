using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BangGia
    {
        public BangGia()
        {

        }
        BangGiaDAL bg = new BangGiaDAL();
        public DataTable GetGia(string masp)
        {
            return bg.getGiaNhap(masp);
        }
        public DataTable getBangGia(string Masp)
        {
            return bg.getBangGia(Masp);
        }
        public DataTable getAllGia()
        {
            return bg.getAllGia();
        }
        public bool Insert(string masp,DateTime ngacn,int giaban,int gianhap)
        {
            return bg.Them(masp, ngacn, giaban, gianhap);
        }
        public bool Update(string masp, DateTime ngacn, int giaban, int gianhap)
        {
            return bg.Sua(masp, ngacn, giaban, gianhap);
        }
        public bool Delete(string masp, DateTime ngacn)
        {
            return bg.Xoa(masp, ngacn);
        }
    }
}
