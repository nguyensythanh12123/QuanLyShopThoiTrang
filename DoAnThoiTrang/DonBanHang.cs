using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThoiTrang
{
    class DonBanHang
    {
        string maSP;
        string tenSP;
        int _SL;
        int _GiaBan;
        int _ThanhTien;
        //List<DonBanHang> listInit;
        public DonBanHang() {
           // this.ListInit = new List<DonBanHang>();
        }
        public string ma { get => maSP; set => maSP = value; }
        public string ten { get => tenSP; set => tenSP = value; }
        public int sl { get => _SL; set => _SL = value; }
        public int gb { get => _GiaBan; set => _GiaBan = value; }
        public int tt { get => _ThanhTien; set => _ThanhTien = value; }
        //internal List<DonBanHang> ListInit { get => listInit; set => listInit = value; }
    }
}
