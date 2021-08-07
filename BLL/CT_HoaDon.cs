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
    public class CT_HoaDon
    {
        CT_HoaDonDAL cthd = new CT_HoaDonDAL();
        public CT_HoaDon()
        {

        }
        public bool insert(int mahd,string masp,int sl,int gb,int tt)
        {
            return cthd.insertCTHD(mahd, masp, sl, gb, tt);
        }
        public bool delete(int macthd)
        {
            return cthd.deleteCTHD(macthd);
        }
        public bool update(int sl,int gia,int tt,int macthd)
        {
            return cthd.SuaCTHD(macthd, sl, gia, tt);
        }
        public int layMCTHD(int mahd,string masp)
        {
            return cthd.layMaCTHD(mahd, masp);
        }
        public DataTable loadCTHDBLL(int mahd)
        {
            return cthd.loadCTHD(mahd);
        }
        public void LoadCTHD(DataGridView dgv,int mahd)
        {
            cthd.LoadctHD(dgv, mahd);
        }
        
    }
}
