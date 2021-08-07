using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.ShopThoiTrangTableAdapters;

namespace DAL
{
    public class NhaCungCapDAL
    {
        public NhaCungCapDAL()
        {

        }
        NHACUNGCAPTableAdapter ncc = new NHACUNGCAPTableAdapter();
        public DataTable LoadNCC()
        {
            return ncc.GetData();
        }
        public bool Them(string MaNCC,string Ten,string DiaChi,string SDT)
        {
            try
            {
                if (ncc.Insert(MaNCC, Ten, DiaChi, SDT) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Sua(string MaNCC, string Ten, string DiaChi, string SDT)
        {
            try
            {
                if (ncc.UpdateQuery(Ten, DiaChi, SDT,MaNCC) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Xoa(string Mancc)
        {
            try
            {
                if (ncc.DeleteQuery(Mancc) > 0)
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
