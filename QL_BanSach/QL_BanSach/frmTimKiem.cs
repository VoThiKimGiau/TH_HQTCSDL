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
    public partial class frmTimKiem : Form
    {
        SqlConnection cn;
        SqlDataAdapter da_Sach;
        DataSet ds_Sach;
        
        public frmTimKiem()
        {
            cn = new SqlConnection(@"Data Source=DuyCute\DuyCute;Initial Catalog=THHQTCSDL_QLBS;Integrated Security=True");
            InitializeComponent();
        }
        

        private void rdDM_CheckedChanged(object sender, EventArgs e)
        {
            rdDM.Enabled = true;
            txtDM.Enabled = true;
            rdTen.Enabled = false;
            txtTen.Enabled = false;
            txtTen.Clear();
        }

        private void rdTen_CheckedChanged(object sender, EventArgs e)
        {
            rdTen.Enabled = true;
            rdTen.Enabled = true;
            txtTen.Enabled = true;
            rdDM.Enabled = false;
            txtDM.Enabled = false;
            txtDM.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            rdTen.Enabled = rdDM.Enabled =true;
            txtTen.Enabled = txtDM.Enabled = false;
            // Khai bao DataSet
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            //Tao SqlDataAdapter
            if (rdTen.Checked)
            {
               
                rdDM.Checked = false;
                txtDM.Clear();
                da = new SqlDataAdapter("Select TenSach, TacGia.TenTG, DMS.TenDanhMuc, GiaBan from Sach join DanhMucSach DMS on Sach.MaDanhMuc = DMS.MaDanhMuc join TacGia on Sach.MaTG = TacGia.MaTG where TenSach like N'%" + txtTen.Text + "%'", cn);
            }
            else
            {
                
                rdTen.Checked = false;
                txtTen.Clear();
                da = new SqlDataAdapter("Select TenSach,TacGia.TenTG, DMS.TenDanhMuc, GiaBan from Sach join DanhMucSach DMS on Sach.MaDanhMuc = DMS.MaDanhMuc join TacGia on Sach.MaTG = TacGia.MaTG where DMS.TenDanhMuc like N'%" + txtDM.Text + "%'", cn);
            }
            //Do du lieu tu DataAdapter vao dataSet
            da.Fill(ds, "Sach");
           
            //Gan du lieu nguon cho dataGridView
            dataGridView1.DataSource = ds.Tables["Sach"];
            rdDM.Checked = rdTen.Checked = false;


        }
        void Load_DgvLophoc()
        {
            //Khai bao DataSet
            DataSet ds = new DataSet();
            //Tao SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter("Select TenSach, TacGia.TenTG, DMS.TenDanhMuc, GiaBan from Sach join DanhMucSach DMS on Sach.MaDanhMuc = DMS.MaDanhMuc join TacGia on Sach.MaTG = TacGia.MaTG", cn);

            //Do du lieu tu DataAdapter vao dataSet
            da.Fill(ds, "Sach");
            //Gan du lieu nguon cho dataGridView
            dataGridView1.DataSource = ds.Tables["Sach"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTen.Enabled = txtDM.Enabled = false;
            Load_DgvLophoc();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmDirectoty f = new frmDirectoty();
            f.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No) e.Cancel = true;
        }
    }
}
