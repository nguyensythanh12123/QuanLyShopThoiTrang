using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class NhanVien
    {
        public NhanVien()
        {

        }
        NhanVienDAL nv = new NhanVienDAL();
        public DataTable getNhanVien()
        {
            return nv.getNV();
        }
        public bool Insert(string MaNV, string TenNV, DateTime Ngaysinh, string diaChi, string GT, string sdt, string maBP, string Matkhau, bool hoatdong)
        {
            return nv.Them(MaNV, TenNV, Ngaysinh, diaChi, GT, sdt, maBP, Matkhau, hoatdong);
        }
        public bool Update(string MaNV, string TenNV, string Ngaysinh, string diaChi, string GT, string sdt, string maBP, string Matkhau, bool hoatdong)
        {
            return nv.Sua(MaNV, TenNV, Ngaysinh, diaChi, GT, sdt, maBP, Matkhau, hoatdong);
        }
        public bool Delete(string MaNV)
        {
            return nv.Xoa(MaNV);
        }
        public int LayMaMax()
        {
            return nv.layMaMax();
        }
        public List<string> getBoPhan(string MaNV)
        {
            return nv.GetMaNhomNguoiDung(MaNV);
        }
        public string layTenNV(string ma)
        {
            return nv.layTenNV(ma);
        }
    }
}
