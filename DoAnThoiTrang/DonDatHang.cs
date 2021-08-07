using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThoiTrang
{
    class DonDatHang
    {
        string masp;
        string tensp;
        int sl;
        int gn;
        int tt;
        public DonDatHang()
        {

        }

        public string Msp { get => masp; set => masp = value; }
        public string Tsp { get => tensp; set => tensp = value; }
        public int Sld { get => sl; set => sl = value; }
        public int Gn { get => gn; set => gn = value; }
        public int Tt { get => tt; set => tt = value; }
    }
}
