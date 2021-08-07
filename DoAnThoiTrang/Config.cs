using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThoiTrang
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }
        QuanLyNguoiDung CauHinh = new QuanLyNguoiDung();
        private void Config_Load(object sender, EventArgs e)
        {

        }

        private void cbbserver_DropDown(object sender, EventArgs e)
        {
            cbbserver.DataSource = CauHinh.GetServerName();
            cbbserver.DisplayMember = "Servername";
        }

        private void cbbdatabase_DropDown(object sender, EventArgs e)
        {
            cbbdatabase.DataSource = CauHinh.GetDBName(cbbserver.Text, txtusername.Text, txtpassword.Text);
            cbbdatabase.DisplayMember = "name";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(cbbserver.Text, txtusername.Text, txtpassword.Text, cbbdatabase.Text);
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
