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
    public partial class frmDMS : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        private Bitmap bmp;

        public frmDMS()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=DuyCute\DuyCute;Initial Catalog=THHQTCSDL_QLBS;Integrated Security=True");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            dgvDM.AllowUserToAddRows = true;
            dgvDM.ReadOnly = false;
            for (int i = 0; i < dgvDM.Rows.Count - 1; i++)
                dgvDM.Rows[i].ReadOnly = true;
            dgvDM.FirstDisplayedScrollingRowIndex = dgvDM.Rows.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvDM.SelectedRows)
            {
                dgvDM.Rows.RemoveAt(item.Index);
            }
            MessageBox.Show("Thành công!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            dgvDM.ReadOnly = false;
            for (int i = 0; i < dgvDM.Rows.Count - 1; i++)
                dgvDM.Rows[i].ReadOnly = false;
            dgvDM.Columns[0].ReadOnly = true;
            dgvDM.AllowUserToAddRows = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from DanhMucSach", conn);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "DanhMucSach");
            databingding(ds.Tables["DanhMucSach"]);
            MessageBox.Show("Thành công", "Thông báo");
            btnSave.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmDirectoty f = new frmDirectoty();
            f.Show();
            this.Hide();
        }

        void loadDM()
        {
            string strsel = "Select * from DanhMucSach";
            SqlDataAdapter da = new SqlDataAdapter(strsel, conn);
            da.Fill(ds, "DanhMucSach");
            dgvDM.DataSource = ds.Tables["DanhMucSach"];
        }

        void databingding(DataTable pDT)
        {
            txtMDM.DataBindings.Clear();
            txtTDM.DataBindings.Clear();

            txtMDM.DataBindings.Add("Text", pDT, "MaDanhMuc");
            txtTDM.DataBindings.Add("Text", pDT, "TenDanhMuc");
        }

        private void frmDMS_Load(object sender, EventArgs e)
        {
            loadDM();
            dgvDM.ReadOnly = true;
            dgvDM.AllowUserToAddRows = false;

            foreach (Control item in tabLayout.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                    item.Enabled = false;
            }

            btnUpdate.Enabled = btnDelete.Enabled = btnSave.Enabled = false;
            databingding(ds.Tables["DanhMucSach"]);
        }

        private void dgvDM_SelectionChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = btnDelete.Enabled = true;
        }

        private void frmDMS_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.No == r)
                e.Cancel = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dgvDM.Height;
            dgvDM.Height = dgvDM.RowCount * dgvDM.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvDM.Width, dgvDM.Height);
            dgvDM.DrawToBitmap(bmp, new Rectangle(0, 0, dgvDM.Width, dgvDM.Height));
            dgvDM.Height = height;

            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
