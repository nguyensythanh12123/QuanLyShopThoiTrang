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
    public class CT_DatHang
    {
        public CT_DatHang()
        {

        }
        CT_DatHangDAL ct = new CT_DatHangDAL();
        public int LayMaCTDH(string madh,string masp)
        {
            return ct.LayMaCTDH(madh, masp);
        }
        public bool insert(string madh, string masp, int sl, int gianhap, int tt, string ghichu)
        {
            return ct.themCTDH(madh, masp, sl, gianhap, tt, ghichu);
        }
        public bool delete(int mactdh)
        {
            return ct.XoaCTDH(mactdh);
        }
        public bool update(int macthd,int sl,int tt)
        {
            return ct.SuaCTDH(macthd, sl, tt);
        }
        public DataTable loadctdh(string madh)
        {
            return ct.loadcthd(madh);
        }
        //public void loadctdhm(DataGridView dgv,string madh)
        //{
        //    ct.loadctdhdal(dgv, madh);
        //}
        public DataTable LoadDatHang(string madh)
        {
            return ct.LoadDatHangTheoMaDH(madh);
        }
    }
}
