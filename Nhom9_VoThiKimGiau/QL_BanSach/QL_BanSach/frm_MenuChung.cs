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

    public partial class frm_MenuChung : Form
    {
        Button currentBtn;
        Panel leftBorderBtn;

        public frm_MenuChung()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 96);
            leftBorderBtn.BackColor = Color.Red;
            leftBorderBtn.Visible = false;
            Controls.Add(leftBorderBtn);
            timer1.Start();
        }

        void ActivateButton(Button clickedBtn)
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.Black;
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            }

            currentBtn = clickedBtn;
            currentBtn.BackColor = Color.FromArgb(173, 216, 230);
            currentBtn.ForeColor = Color.Black;
            currentBtn.TextAlign = ContentAlignment.MiddleLeft;

            leftBorderBtn.Size = new Size(7, currentBtn.Height);
            leftBorderBtn.Location = new Point(currentBtn.Left - leftBorderBtn.Width, currentBtn.Top);
            leftBorderBtn.Visible = true;
        }
        Form activeForm = null;

        void openForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pannel_from.Controls.Add(childForm);
            pannel_from.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_ordermn_Click(object sender, EventArgs e)
        {
            ActivateButton(btn_ordermn);
            openForm(new frmBanSach());
        }

        private void btn_monanmn_Click(object sender, EventArgs e)
        {
            ActivateButton(btn_monanmn);
            openForm(new frm_Sach());
        }

        private void btn_khachhangmn_Click(object sender, EventArgs e)
        {
            ActivateButton(btn_khachhangmn);
            openForm(new frmDMS());
        }

        private void btn_nhanvienmn_Click(object sender, EventArgs e)
        {
            ActivateButton(btn_nhanvienmn);
            openForm(new frmTG());
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            ActivateButton(btn_thongke);
            openForm(new frmThongKe());

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frmLogin a = new frmLogin();
            this.Hide();  // Ẩn form hiện tại
            a.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void btn_bepbarmn_Click(object sender, EventArgs e)
        {
            ActivateButton(btn_bepbarmn);
            openForm(new frmTimKiem());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_MenuChung a = new frm_MenuChung();
            this.Hide();
            a.Show();
        }

        private void frm_MenuChung_Load(object sender, EventArgs e)
        {
            openForm(new frmBanSach());
        }



    }
}
