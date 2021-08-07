using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.ShopThoiTrangTableAdapters;

namespace DAL
{
    public class ManHinhDAL
    {
        public ManHinhDAL()
        {

        }
        DM_MAHINHTableAdapter mh = new DM_MAHINHTableAdapter();
        public bool insert(string MaMH,string TenMH)
        {
            try
            {
                if (mh.Insert(MaMH, TenMH) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool delete(string MaMH)
        {
            try
            {
                if (mh.DeleteMH(MaMH) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        public bool update(string MaMH,string TenMH)
        {
            try
            {
                if (mh.UpdateMH(TenMH, MaMH) > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        public DataTable GetMH()
        {
            return mh.GetData();
        }
    }
}
