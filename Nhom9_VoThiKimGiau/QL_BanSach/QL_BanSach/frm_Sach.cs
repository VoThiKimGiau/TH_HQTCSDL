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
    public partial class frm_Sach : Form
    {
        ConnectSQL a = new ConnectSQL();
        public string conStr = Properties.Settings.Default.conStr;
        SqlDataAdapter da_ThongTinS;
        DataSet ds_ThongTinS;
        SqlDataAdapter da_ThongTinHD;
        DataSet ds_ThongTinHD;
        DataSet danhmuc;
        DataSet tacgia;
        public frm_Sach()
        {
            da_ThongTinS = new SqlDataAdapter();
            ds_ThongTinS = new DataSet();
            da_ThongTinHD = new SqlDataAdapter();
            ds_ThongTinHD = new DataSet();
            danhmuc = new DataSet();
            tacgia = new DataSet();
            InitializeComponent();
        }
        public void Load_Sach()
        {
            using(SqlConnection con=new SqlConnection(conStr))
            {
                con.Open();
                string sql="Select*from Sach";
                da_ThongTinS=new SqlDataAdapter(sql,con);
                
                da_ThongTinS.Fill(ds_ThongTinS,"ThongTinS");
                dgv_sach.DataSource=ds_ThongTinS.Tables["ThongTinS"];
            }
        }
        public void Load_HoaDon()
        {
            using(SqlConnection con=new SqlConnection(conStr))
            {
                con.Open();
                string sql = "Select *From DonHang";
                da_ThongTinHD = new SqlDataAdapter(sql, con);
                da_ThongTinHD.Fill(ds_ThongTinHD, "ThongTinHD");
                dgv_HoaDon.DataSource = ds_ThongTinHD.Tables["ThongTinHD"];
            }
        }
        private void frm_Sach_Load(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection(conStr))
            {
                con.Open();
                string sql = "Select*from DanhMucSach";
                string sql1 = "Select*from TacGia";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(danhmuc, "DanhMuc");
                SqlDataAdapter da1 = new SqlDataAdapter(sql1, con);
                da1.Fill(tacgia, "TacGia");
                cbb_danhmuc.DataSource = danhmuc.Tables["DanhMuc"];
                cbb_danhmuc.DisplayMember = "MaDanhMuc";
                cbb_danhmuc.SelectedIndex = -1;
               
                cbb_tacgia.DataSource = tacgia.Tables["TacGia"];
                cbb_tacgia.DisplayMember = "MaTG";
                cbb_tacgia.SelectedIndex = -1;
               
            }
            Load_Sach();
            dgv_sach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Load_HoaDon();
            dgv_HoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void txt_slkho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, loại bỏ ký tự khỏi TextBox
                e.Handled = true;
            }
        }

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, loại bỏ ký tự khỏi TextBox
                e.Handled = true;
            }
        }
        
        private void dgv_sach_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_sach.SelectedRows.Count>0)
            {
                DataGridViewRow chon = dgv_sach.SelectedRows[0];
                txt_tensach.Text = chon.Cells["TenSach"].Value.ToString();
                txt_gia.Text = chon.Cells["GiaBan"].Value.ToString();
                txt_slkho.Text = chon.Cells["SLKho"].Value.ToString();
                cbb_danhmuc.Text = chon.Cells["MaDanhMuc"].Value.ToString();
                cbb_tacgia.Text = chon.Cells["MaTG"].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_tensach.Text!=""&&txt_gia.Text!=""&&txt_slkho.Text!=""&&cbb_tacgia.Text!=""&&cbb_danhmuc.Text!="")
            {
                string ma = a.GenerateMaSach();
                string ten = txt_tensach.Text;
                int slk =int.Parse(txt_slkho.Text);
                double gia=double.Parse(txt_gia.Text);
                string matg = cbb_tacgia.Text;
                string madm = cbb_danhmuc.Text;
                using(SqlConnection con=new SqlConnection(conStr))
                {
                    con.Open();
        
                    string them = "Insert Into Sach Values('" + ma + "', '" + matg + "', '" + madm + "', " + gia + ", " + slk + ", N'" + ten + "')";
                    SqlCommand cmd = new SqlCommand(them, con);
                    int t = cmd.ExecuteNonQuery();
                    if(t==1)
                    {
                        MessageBox.Show("Thêm Thành Công", "Thông Báo");
                        ds_ThongTinS.Tables["ThongTinS"].Clear();
                        Load_Sach();
                    }
                }
            }
           
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(txt_tensach.Text!=""&&txt_gia.Text!=""&&txt_slkho.Text!=""&&cbb_tacgia.Text!=""&&cbb_danhmuc.Text!="")
            {
                DataGridViewRow chon = dgv_sach.SelectedRows[0];
                string ma = chon.Cells["MaSach"].Value.ToString();
                using(SqlConnection con=new SqlConnection(conStr))
                {
                    con.Open();
                    string xoa = "Delete From Sach Where MaSach='" + ma + "'";
                    SqlCommand cmd = new SqlCommand(xoa, con);
                    int t = cmd.ExecuteNonQuery();
                    if(t==1)
                    {
                        MessageBox.Show("Xóa Thành Công!", "Thông Báo");
                        ds_ThongTinS.Tables["ThongTinS"].Clear();
                        Load_Sach();
                    }
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_tensach.Text != "" && txt_gia.Text != "" && txt_slkho.Text != "" && cbb_tacgia.Text != "" && cbb_danhmuc.Text != "")
            {
                DataGridViewRow chon = dgv_sach.SelectedRows[0];
                string ma = chon.Cells["MaSach"].Value.ToString();
                string ten = txt_tensach.Text;
                string matg = cbb_tacgia.Text;
                string madm = cbb_danhmuc.Text;
                double gia =double.Parse(txt_gia.Text);
                int slk = int.Parse(txt_slkho.Text);
                using(SqlConnection con=new SqlConnection(conStr))
                {
                    con.Open();
                    string sua = "Update Sach Set TenSach=N'" + ten + "',MaTG='" + matg + "',MaDanhMuc='" + madm + "',GiaBan=" + gia + ",SLKho=" + slk + " Where MaSach='"+ma+"'";
                    SqlCommand cmd = new SqlCommand(sua, con);
                    int t = cmd.ExecuteNonQuery();
                    if (t == 1)
                    {
                        MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
                        ds_ThongTinS.Tables["ThongTinS"].Clear();
                        Load_Sach();
                    }
                }
               
            }
        }

        private void dgv_HoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_HoaDon.SelectedRows.Count>0)
            {
                DataGridViewRow chon=dgv_HoaDon.SelectedRows[0];

                txt_maHD.Text = chon.Cells["MaDH"].Value.ToString();

            }
        }

        private void btn_xoahd_Click(object sender, EventArgs e)
        {
            if (dgv_HoaDon.SelectedRows.Count > 0)
            {
                DataGridViewRow chon = dgv_HoaDon.SelectedRows[0];

                string ma = chon.Cells["MaDH"].Value.ToString();
                using(SqlConnection con=new SqlConnection(conStr))
                {
                    con.Open();
                    string xoaCT = "Delete From ChiTietDonHang Where MaDH='" + ma + "'";
                    string xoaDH = "Delete From DonHang Where MaDH='" + ma + "'";
                    SqlCommand cmd = new SqlCommand(xoaCT, con);
                    int t = cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand(xoaDH, con);
                    int i = cmd1.ExecuteNonQuery();
                    if(t==1&&i==1)
                    {
                        MessageBox.Show("Xóa Đơn Hàng Thành Công!", "Thông Báo");
                        ds_ThongTinHD.Tables["ThongTinHD"].Clear();
                        Load_HoaDon();
                    }
                }

            }
        }

        private void btn_inhd_Click(object sender, EventArgs e)
        {
             if (dgv_HoaDon.SelectedRows.Count > 0)
            {
                DataGridViewRow chon = dgv_HoaDon.SelectedRows[0];

                string ma = chon.Cells["MaDH"].Value.ToString();
                // ...
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string sql = "LayThongTinDonHang";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maDH", ma);
                    SqlDataAdapter da_ThongTinHD = new SqlDataAdapter();
                    da_ThongTinHD.SelectCommand = cmd;
                    DataTable dt = new DataTable("HoaDonIn");
                    da_ThongTinHD.Fill(dt);
                    //
                    rpt_InHoaDon baocao = new rpt_InHoaDon();
                    baocao.SetDataSource(dt);

                    // Hiển thị thông báo và in hóa đơn khi nhấn OK
                    DialogResult result = MessageBox.Show("Bạn có muốn in hóa đơn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        // Mở form in hóa đơn
                        frmInHoaDon f = new frmInHoaDon();
                        f.crystalReportViewer1.ReportSource = baocao;
                        f.ShowDialog();
                    }
                }
                // ...


            }
        }
        private decimal LayTongTienDonHang(string maDH)
        {
            decimal tongTien = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.LayTongTienDonHang(@maDH)", con))
                    {
                        cmd.Parameters.AddWithValue("@maDH", maDH);

                        // Sử dụng ExecuteScalar để lấy giá trị trả về từ hàm
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            tongTien = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tongTien;
        }


        private void btn_tonghd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_HoaDon.SelectedRows.Count > 0)
                {
                    DataGridViewRow chon = dgv_HoaDon.SelectedRows[0];
                    string ma = chon.Cells["MaDH"].Value.ToString();

                    if (!string.IsNullOrEmpty(ma))
                    {
                        decimal tongTien = LayTongTienDonHang(ma);
                        txt_tongtienhd.Text = tongTien.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Mã đơn hàng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_soluongsachdh_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_HoaDon.SelectedRows.Count > 0)
                {
                    DataGridViewRow chon = dgv_HoaDon.SelectedRows[0];
                    string maDH = chon.Cells["MaDH"].Value.ToString();

                    if (!string.IsNullOrEmpty(maDH))
                    {
                        int soLuongSach = LaySoLuongSachTrongDonHang(maDH);
                        txt_slsachdh.Text = soLuongSach.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Mã đơn hàng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int LaySoLuongSachTrongDonHang(string maDH)
        {
            int soLuong = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.LaySoLuongSachTrongDonHang(@maDH)", con))
                    {
                        cmd.Parameters.AddWithValue("@maDH", maDH);

                        // Sử dụng ExecuteScalar để lấy giá trị trả về từ hàm
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            soLuong = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return soLuong;
        }

        private void btn_bansach_Click(object sender, EventArgs e)
        {
            frmBanSach a = new frmBanSach();
            this.Hide();
            a.Show();
        }

        private void btn_qlsach_Click(object sender, EventArgs e)
        {
            frm_Sach a = new frm_Sach();
            this.Hide();
            a.Show();
        }

        private void btn_function_Click(object sender, EventArgs e)
        {

        }

        private void dgv_sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
