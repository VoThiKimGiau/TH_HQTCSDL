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
    public partial class frm_Input_Khach : Form
    {
        ConnectSQL a = new ConnectSQL();

        string layPhone;

        public string LayPhone
        {
            get { return layPhone; }
            set { layPhone = value; }
        }
        public frm_Input_Khach()
        {
            InitializeComponent();
        }

        private void btn_kiemtra_Click(object sender, EventArgs e)
        {
            string sdt = txt_sdt_kt.Text;
            if (sdt == null || sdt == "")
            {
                sdt = "0941824972";
            }
            int t = a.KiemTraSDT(sdt.Trim());
            if (t == 1)
            {
                lb_tb.Text = "Đúng Thông Tin";
                layPhone = sdt.Trim();
            }
            else
            {
                lb_tb.Text = "Khách Hàng Chưa Tồn Tại!";
            }
        }

        private void rdo_khachcu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_khachcu.Checked)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
            }
        }

        private void rdo_khachmoi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_khachmoi.Checked)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
            }
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            if (txt_tenkh.Text != "" && txt_dc.Text != "" && txt_email.Text != "" && txt_sdt.Text != "")
            {
                string ma = a.GenerateMaKH();
                string sdt = txt_sdt.Text;
                int t = a.themKhachHang(ma, txt_tenkh.Text, txt_dc.Text, sdt.Trim(), txt_email.Text);
                if (t == 1)
                {
                    lb_tb2.Text = "Đăng Ký Thành Công!";

                    layPhone = sdt.Trim();
                }
                else
                {
                    lb_tb2.Text = "Đăng Ký Thất Bại";
                }
            }
            else
            {
                lb_tb2.Text = "Nhập Đầy Đủ Thông Tin";
            }
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            if (rdo_khachcu.Checked)
            {
                string soDienThoai = txt_sdt_kt.Text.Trim();
                LayPhone = soDienThoai;
            }
            else
            {
                string soDienThoai = txt_sdt.Text.Trim();
                LayPhone = soDienThoai;
            }
            DialogResult = DialogResult.OK;
            Close();
        }


        private void frm_Input_Khach_Load(object sender, EventArgs e)
        {
            //this.Size = new System.Drawing.Size(1254, 1118);

        }
    }
}
