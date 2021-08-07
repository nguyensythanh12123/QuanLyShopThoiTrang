using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class NhaCungCap
    {
        public NhaCungCap()
        {

        }
        NhaCungCapDAL ncc = new NhaCungCapDAL();
        public DataTable getNCC()
        {
            return ncc.LoadNCC();
        }
        public bool Insert(string MaNCC, string Ten, string DiaChi, string SDT)
        {
            return ncc.Them(MaNCC, Ten, DiaChi, SDT);
                  
        }
        public bool Update(string MaNCC, string Ten, string DiaChi, string SDT)
        {
            return ncc.Sua(MaNCC,Ten,DiaChi,SDT);
        }
        public bool Delete(string Mancc)
        {
            return ncc.Xoa(Mancc);
        }
    }
}
