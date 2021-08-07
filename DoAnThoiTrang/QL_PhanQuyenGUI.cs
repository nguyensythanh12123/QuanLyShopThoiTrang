using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace DoAnThoiTrang
{
    public partial class QL_PhanQuyenGUI : Form
    {
        public QL_PhanQuyenGUI()
        {
            InitializeComponent();
        }
        BoPhan bp = new BoPhan();
        QL_PhanQuyen pq = new QL_PhanQuyen();
        private void QL_PhanQuyenGUI_Load(object sender, EventArgs e)
        {
            dgvbp.DataSource = bp.GetBoPhan();
        }

        private void dgvbp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvphanquyen.DataSource = pq.GetPhanQuyen(dgvbp.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaBP = dgvbp.CurrentRow.Cells[0].Value.ToString();
            int flag = 0;
            foreach (DataGridViewRow item in dgvphanquyen.Rows)
            {
                if (pq.KiemTraKC(MaBP, item.Cells[0].Value.ToString()))
                {
                    try
                    {
                        if (pq.Insert(MaBP, item.Cells[0].Value.ToString(), (bool)(item.Cells[2].Value)))
                        {
                            flag = 1;
                        }
                        else
                        {
                            flag = 0;
                        }
                       
                    }
                    catch
                    {
                        if (pq.Insert(MaBP, item.Cells[0].Value.ToString(), false))
                        {
                            flag = 1;
                        }
                        else
                        {
                            flag = 0;
                        }
                    }
                }
                else
                {
                    if(pq.Update(MaBP, item.Cells[0].Value.ToString(), (bool)(item.Cells[2].Value)))
                    {
                        flag = 1;
                    }
                    else
                    {
                        flag = 0;
                    }
                    //pq.Update((item.Cells[2] == null) ? false : (bool)(item.Cells[2].Value), MaBP, item.Cells[0].Value.ToString());
                }
            }
            if(flag==1)
            {
                string message = "Phân quyền thành công.";
                MessageBoxThanhCong frm = new MessageBoxThanhCong();
                frm.message(message);
                frm.ShowDialog();
            }
            else
            {
                string message = "Phân quyền thất bại.";
                MessageBoxCustom frm = new MessageBoxCustom();
                frm.message(message);
                frm.ShowDialog();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
