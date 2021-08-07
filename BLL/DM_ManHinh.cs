using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class DM_ManHinh
    {
        public DM_ManHinh()
        {

        }
        ManHinhDAL mh = new ManHinhDAL();
        public DataTable getMH()
        {
            return mh.GetMH();
        }
        public bool Insert(string MaMH,string TenMH)
        {
            return mh.insert(MaMH, TenMH);
        }
        public bool Delete(string MaMH)
        {
            return mh.delete(MaMH);
        }
        public bool Update(string MaMH,string TenMH)
        {
            return mh.update(MaMH, TenMH);
        }
    }
}
