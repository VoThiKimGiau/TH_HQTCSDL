using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_BanSach
{
    public partial class frmThongKe : Form
    {
        SqlConnection cn;
        SqlDataAdapter da_Sach;
        DataSet ds_Sach;
   
        public frmThongKe()
        {
            cn = new SqlConnection(@"Data Source=DuyCute\DuyCute;Initial Catalog=THHQTCSDL_QLBS;Integrated Security=True");
            InitializeComponent();
        }

        private void rdDTHT_CheckedChanged(object sender, EventArgs e)
        {
            rdKH.Checked = false;
        }

        private void rdKH_CheckedChanged(object sender, EventArgs e)
        {
            rdDTHT.Checked = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No) e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmDirectoty f = new frmDirectoty();
            f.Show();
            this.Hide();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            if (rdKH.Checked)
            {
                da = new SqlDataAdapter("select * from dbo.DTKH()", cn);
            }
            else
            {

                da = new SqlDataAdapter("select * from dbo.TKThang()", cn);
            }
            //Do du lieu tu DataAdapter vao dataSet
            da.Fill(ds, "DonHang");

            //Gan du lieu nguon cho dataGridView
            dataGridView1.DataSource = ds.Tables["DonHang"];
        }

    }
}
