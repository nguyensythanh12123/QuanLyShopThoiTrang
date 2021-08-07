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
    public class CT_PhieuNhap
    {
        
        public CT_PhieuNhap()
        {

        }
        CT_PhieuNhapDAL ctpn = new CT_PhieuNhapDAL();
        public bool insert(string MaPN, string MaSP, int sln, int gianhap, int thanhtien, string ghichu)
        {
            return ctpn.ThemCT(MaPN, MaSP, sln, gianhap, thanhtien, ghichu);
        }
        public void LoadCTPN(DataGridView dgv,string Mapn)
        {
            ctpn.LoadPN(dgv, Mapn);
        }
    }
}
