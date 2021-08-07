using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public class TinhTongTien
    {
        public int tinhTongTien(DataGridView dgv,int cell)
        {
            int tongtien = 0;
            for(int i=0;i<dgv.Rows.Count;i++)
            {
                tongtien += int.Parse(dgv.Rows[i].Cells[cell].Value.ToString());
            }
            return tongtien;
        }

        public int tinhSoLuong(DataGridView dgv, int cell)
        {
            int sl = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                sl++;
            }
            return sl;
        }
    }
}
