using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.ShopThoiTrangTableAdapters;

namespace DAL
{
    public class NhanVienDAL
    {
        NHANVIENTableAdapter nv = new NHANVIENTableAdapter();
        public NhanVienDAL()
        {

        }
        public DataTable getNV()
        {
            return nv.GetData();
        }
        public bool Them(string MaNV,string TenNV,DateTime Ngaysinh,string diaChi,string GT,string sdt,string maBP,string Matkhau,bool hoatdong)
        {
            try
            {
                if (nv.Insert(MaNV, TenNV, Ngaysinh, diaChi, GT, sdt, maBP, Matkhau, hoatdong) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string MaNV, string TenNV, string Ngaysinh, string diaChi, string GT, string sdt, string maBP, string Matkhau, bool hoatdong)
        {
            try
            {
                if (nv.UpdateQuery(TenNV, Ngaysinh, diaChi, GT, sdt, maBP, Matkhau, hoatdong, MaNV) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Xoa(string MaNV)
        {
            try
            {
                if (nv.DeleteQuery(MaNV) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public int layMaMax()
        {
            try
            {
                return int.Parse(nv.LayMaNV().ToString());
            }
            catch
            {
                return 0;
            }
        }
        public List<string> GetMaNhomNguoiDung(string MaNV)
        {
            List<string> kqMNND = new List<string>();


            DataTable dtkq = nv.GetDataByDSNND(MaNV);

            for (int i = 0; i < dtkq.Rows.Count; i++)
            {
                kqMNND.Add(dtkq.Rows[i].ItemArray[6].ToString());
            }

            return kqMNND;
        }

        public string layTenNV(string ma)
        {
            return nv.LayTenNhanVien(ma);
        }

    }
}
