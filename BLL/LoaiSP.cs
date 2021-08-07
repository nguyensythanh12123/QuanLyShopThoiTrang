using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class LoaiSP
    {
        public LoaiSP()
        {

        }
        LoaiSP_DAL lsp = new LoaiSP_DAL();
        public DataTable getLoaiSP()
        {
            return lsp.getLoaiSP();
        }
        public bool Insert(string MaLoai,string TenLoai)
        {
            return lsp.Them(MaLoai, TenLoai);
        }
        public bool Update(string MaLoai, string TenLoai)
        {
            return lsp.Sua(MaLoai, TenLoai);
        }
        public bool Delete(string MaLoai)
        {
            return lsp.Xoa(MaLoai);
        }
    }
}
