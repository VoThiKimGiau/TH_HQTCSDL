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
    public partial class frmSach : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        private Bitmap bmp;

        public frmSach()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=DuyCute\DuyCute;Initial Catalog=THHQTCSDL_QLBS;Integrated Security=True");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            dgvSach.AllowUserToAddRows = true;
            dgvSach.ReadOnly = false;
            for (int i = 0; i < dgvSach.Rows.Count - 1; i++)
                dgvSach.Rows[i].ReadOnly = true;
            dgvSach.FirstDisplayedScrollingRowIndex = dgvSach.Rows.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvSach.SelectedRows)
            {
                dgvSach.Rows.RemoveAt(item.Index);
            }
            MessageBox.Show("Thành công!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            dgvSach.ReadOnly = false;
            for (int i = 0; i < dgvSach.Rows.Count - 1; i++)
                dgvSach.Rows[i].ReadOnly = false;
            dgvSach.Columns[0].ReadOnly = true;
            dgvSach.AllowUserToAddRows = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Sach", conn);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "Sach");
            databingding(ds.Tables["Sach"]);
            MessageBox.Show("Thành công", "Thông báo");
            btnSave.Enabled = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmDirectoty f = new frmDirectoty();
            f.Show();
            this.Hide();
        }

        void loadS()
        {
            string strsel = "Select * from Sach";
            SqlDataAdapter da = new SqlDataAdapter(strsel, conn);
            da.Fill(ds, "Sach");
            dgvSach.DataSource = ds.Tables["Sach"];
        }

        //string loadTypeOfUser(string UN, string Pass)
        //{
        //    string type = "";
        //    SqlCommand cmd = new SqlCommand("SELECT * FROM PQ WHERE username ='" + UN + "' and pass='" + Pass + "'", conn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    if (dt != null)
        //    {
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            type = dr["typeofuser"].ToString();
        //        }
        //    }
        //    return type;
        //}

        // string loadTK()
        //{
        //    string value = "";
        //    int sl = 0;
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd = new SqlCommand("Select dbo.sum_SachTrongKho()");
        //    SqlDataReader reader = cmd.ExecuteReader();

        //    if (reader.Read())
        //    {
        //        value = reader.GetString(0); // Đọc giá trị từ cột thứ nhất trong kết quả truy vấn
        //    }

        //    reader.Close();
        //    return value;
        //}

        void databingding(DataTable pDT)
        {
            txtMS.DataBindings.Clear();
            txtTG.DataBindings.Clear();
            txtTS.DataBindings.Clear();
            txtGB.DataBindings.Clear();
            txtSL.DataBindings.Clear();
            txtDM.DataBindings.Clear();

            txtMS.DataBindings.Add("Text", pDT, "MaSach");
            txtTG.DataBindings.Add("Text", pDT, "MaTG");
            txtTS.DataBindings.Add("Text", pDT, "TenSach");
            txtGB.DataBindings.Add("Text", pDT, "GiaBan");
            txtSL.DataBindings.Add("Text", pDT, "SLKho");
            txtDM.DataBindings.Add("Text", pDT, "MaDanhMuc");
        }
        public frmLogin f;
        private void frmSach_Load(object sender, EventArgs e)
        {
            loadS();
            //txtTK.Text = loadTK();

            //string user = loadTypeOfUser(f.un, f.ps);

            dgvSach.ReadOnly = true;
            dgvSach.AllowUserToAddRows = false;

            foreach (Control item in tabLayout.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                    item.Enabled = false;
            }

            btnUpdate.Enabled = btnDelete.Enabled = btnSave.Enabled = false;
            databingding(ds.Tables["Sach"]);
        }

        private void dgvSach_SelectionChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = btnDelete.Enabled = true;
        }

        private void frmSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.No == r)
                e.Cancel = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dgvSach.Height;
            dgvSach.Height = dgvSach.RowCount * dgvSach.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvSach.Width, dgvSach.Height);
            dgvSach.DrawToBitmap(bmp, new Rectangle(0, 0, dgvSach.Width, dgvSach.Height));
            dgvSach.Height = height;

            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
