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
    public class CT_PhieuNhapDAL
    {
        CT_PHIEUNHAPTableAdapter ct = new CT_PHIEUNHAPTableAdapter();
        ThoiTrangDataContext context = new ThoiTrangDataContext();
        public CT_PhieuNhapDAL()
        {

        }
        public bool ThemCT(string MaPN,string MaSP,int sln,int gianhap,int thanhtien,string ghichu)
        {
            try
            {
                if (ct.Insert(MaPN, MaSP, sln, gianhap, thanhtien, ghichu) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        public void LoadPN(DataGridView dgv,string Mapn)
        {
            var ctpns = from pn in context.CT_PHIEUNHAPs join k in context.SANPHAMs on pn.MASP equals k.MASP where pn.MAPN == Mapn select new
                        { msp=pn.MASP,tsp=k.TENSP,sld=pn.SOLUONGNHAP,gn=pn.GIANHAP,tt=pn.THANHTIEN,gc=pn.GHICHU };
            dgv.DataSource = ctpns;
        }
        
    }
}
