using QL_BanSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanSach
{
    public partial class frmDirectoty : Form
    {
        public frmDirectoty()
        {
            InitializeComponent();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            frmSach f = new frmSach();
            f.Show();
            this.Close();
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            frm_Sach f = new frm_Sach();
            f.Show();
            this.Close();
        }

        private void btnDM_Click(object sender, EventArgs e)
        {
            frmDMS f = new frmDMS();
            f.Show();
            this.Close();
        }

        private void btnTG_Click(object sender, EventArgs e)
        {
            frmTG f = new frmTG();
            f.Show();
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            f.Show();
            this.Close();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();
            f.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
            this.Hide();
        }
    }
}
