using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DAL.ShopThoiTrangTableAdapters;

namespace DAL
{
    public class SanPhamDAL
    {
        SANPHAMTableAdapter sp = new SANPHAMTableAdapter();
        ThoiTrangDataContext context = new ThoiTrangDataContext();
        public SanPhamDAL()
        {

        }
        public DataTable getSP()
        {
            return sp.GetData();
        }
        public string LayTenSP(string Masp)
        {
            return sp.LayTenSP(Masp);
        }
        public void LoadSanPham(DataGridView dgv)
        {
            var sanphams = from sp in context.SANPHAMs select new
            { msp=sp.MASP,tsp=sp.TENSP,gia=sp.GIA,mt=sp.MOTA,slt=sp.SOLUONGTON,ncc=sp.NHACUNGCAP.TENNCC,lsp=sp.LOAISP.TENLOAI,a=sp.ANH,act=sp.ANHCT };
            dgv.DataSource = sanphams;
        }
        public int LayGiaSP(string Masp)
        {
            return int.Parse(sp.LayGiaSP(Masp).ToString());
        }
        public int Layslt(string masp)
        {
            return int.Parse(sp.LaySoLuongTon(masp).ToString());
        }
        public DataTable getSPTheoNCC(string MaNCC)
        {
            return sp.GetDataBydk(MaNCC);
        }
        public string layMaSP(string tensp)
        {
            return sp.LayMaSanPham(tensp);
        }
        public bool Them(string Masp,string TenSp, string mota, int slt, string MaNCC, string ml, string anh, string anhct)
        {
            try
            {
                if (sp.InsertQuery(Masp, TenSp, mota, slt, MaNCC, ml, anh, anhct) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Xoa(string Masp)
        {
            try
            {
                if (sp.DeleteQuery(Masp) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaGia(string Masp,int gia)
        {
            try
            {
                if (sp.UpdateGia(gia,Masp) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string Masp, string TenSp, string mota, int slt, string MaNCC, string ml, string anh, string anhct)
        {
            try
            {
                if (sp.UpdateQuery(TenSp, mota, slt, MaNCC, ml, anh, anhct,Masp) > 0)
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
