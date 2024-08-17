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
    public partial class frmTG : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        private Bitmap bmp;

        public frmTG()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=DuyCute\DuyCute;Initial Catalog=THHQTCSDL_QLBS;Integrated Security=True");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            dgvTG.AllowUserToAddRows = true;
            dgvTG.ReadOnly = false;
            for (int i = 0; i < dgvTG.Rows.Count - 1; i++)
                dgvTG.Rows[i].ReadOnly = true;
            dgvTG.FirstDisplayedScrollingRowIndex = dgvTG.Rows.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvTG.SelectedRows)
            {
                dgvTG.Rows.RemoveAt(item.Index);
            }
            MessageBox.Show("Thành công!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            dgvTG.ReadOnly = false;
            for (int i = 0; i < dgvTG.Rows.Count - 1; i++)
                dgvTG.Rows[i].ReadOnly = false;
            dgvTG.Columns[0].ReadOnly = true;
            dgvTG.AllowUserToAddRows = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TacGia", conn);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "TacGia");
            databingding(ds.Tables["TacGia"]);
            MessageBox.Show("Thành công", "Thông báo");
            btnSave.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmDirectoty f = new frmDirectoty();
            f.Show();
            this.Hide();
        }

        void loadTG()
        {
            string strsel = "Select * from TacGia";
            SqlDataAdapter da = new SqlDataAdapter(strsel, conn);
            da.Fill(ds, "TacGia");
            dgvTG.DataSource = ds.Tables["TacGia"];
        }

        void databingding(DataTable pDT)
        {
            txtMTG.DataBindings.Clear();
            txtTG.DataBindings.Clear();

            txtMTG.DataBindings.Add("Text", pDT, "MaTG");
            txtTG.DataBindings.Add("Text", pDT, "TenTG");
        }

        private void frmTG_Load(object sender, EventArgs e)
        {
            loadTG();
            dgvTG.ReadOnly = true;
            dgvTG.AllowUserToAddRows = false;

            foreach (Control item in tabLayout.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                    item.Enabled = false;
            }

            btnUpdate.Enabled = btnDelete.Enabled = btnSave.Enabled = false;
            databingding(ds.Tables["TacGia"]);
        }

        private void dgvTG_SelectionChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = btnDelete.Enabled = true;
        }

        private void frmTG_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.No == r)
                e.Cancel = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dgvTG.Height;
            dgvTG.Height = dgvTG.RowCount * dgvTG.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvTG.Width, dgvTG.Height);
            dgvTG.DrawToBitmap(bmp, new Rectangle(0, 0, dgvTG.Width, dgvTG.Height));
            dgvTG.Height = height;

            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
