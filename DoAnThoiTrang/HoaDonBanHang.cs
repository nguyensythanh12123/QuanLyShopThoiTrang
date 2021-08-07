using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThoiTrang
{
    public class HoaDonBanHang
    {
        string _STT;
        String _TenSP;
        int _SoLuong;
        int _GiaBan;
        int _ThanhTien;
        int _TongTien;

        public string STT { get => _STT; set => _STT = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public int GiaBan { get => _GiaBan; set => _GiaBan = value; }
        public int ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
        public int TongTien { get => _TongTien; set => _TongTien = value; }
    }
}
