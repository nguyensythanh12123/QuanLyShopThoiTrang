using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.ShopThoiTrangTableAdapters;

namespace DAL
{
    public class LoaiSP_DAL
    {
        public LoaiSP_DAL()
        {

        }
        LOAISPTableAdapter lsp = new LOAISPTableAdapter();
        public DataTable getLoaiSP()
        {
            return lsp.GetData();
        }
        public bool Them(string MaLoai,string TenLoai)
        {
            try
            {
                if (lsp.Insert(MaLoai, TenLoai) > 0)
                    return true;
                return false;
            }catch
            {
                return false;
            }
        }
        public bool Sua(string MaLoai,string TenLoai)
        {
            try
            {
                if (lsp.UpdateQuery(TenLoai, MaLoai) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        public bool Xoa(string MaLoai)
        {
            try
            {
                if (lsp.DeleteQuery(MaLoai) > 0)
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
