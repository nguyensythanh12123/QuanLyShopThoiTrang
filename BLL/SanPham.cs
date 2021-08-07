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
    public class SanPham
    {
        public SanPham()
        {

        }
        SanPhamDAL sp = new SanPhamDAL();
        public DataTable getSP()
        {
            return sp.getSP();
        }
        public void getSanPham(DataGridView dgv)
        {
            sp.LoadSanPham(dgv);
        }
        public string LayTenSPbll(string Masp)
        {
            return sp.LayTenSP(Masp);
        }
        public int LayGiaSPBLL(string Masp)
        {
            return sp.LayGiaSP(Masp);
        }
        public int laySLTon(string masp)
        {
            return sp.Layslt(masp);
        }
        public DataTable LaySanPhamTheoNCC(string mancc)
        {
            return sp.getSPTheoNCC(mancc);
        }
        public string layMaSP(string tensp)
        {
            return sp.layMaSP(tensp);
        }
        public bool Insert(string Masp, string TenSp, string mota, int slt, string MaNCC, string ml, string anh, string anhct)
        {
            return sp.Them(Masp, TenSp, mota, slt, MaNCC, ml, anh, anhct);
        }
        public bool Update(string Masp, string TenSp, string mota, int slt, string MaNCC, string ml, string anh, string anhct)
        {
            return sp.Sua(Masp, TenSp, mota, slt, MaNCC, ml, anh, anhct);
        }
        public bool UpdatePrice(string Masp,int gia)
        {
            return sp.SuaGia(Masp, gia);
        }
        public bool Delete(string Masp)
        {
            return sp.Xoa(Masp);
        }
    }
}
