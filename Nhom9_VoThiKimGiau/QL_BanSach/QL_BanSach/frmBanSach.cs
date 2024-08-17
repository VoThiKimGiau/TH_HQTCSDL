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
    public partial class frmBanSach : Form
    {
        ConnectSQL a = new ConnectSQL();
        string conStr =@"Data Source=DuyCute\DuyCute;Initial Catalog=THHQTCSDL_QLBS;Integrated Security=True";
        SqlDataAdapter da_ThongTinS;
        DataSet ds_ThongTinS;

        public frmBanSach()
        {
            da_ThongTinS = new SqlDataAdapter();
            ds_ThongTinS = new DataSet();
            InitializeComponent();
        }
        public void Load_ThongTin()
        {
            //Sách
            using(SqlConnection con=new SqlConnection(conStr))
            {
                con.Open();
                string sql = "Inf_Book";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                da_ThongTinS.SelectCommand = cmd;
                da_ThongTinS.Fill(ds_ThongTinS, "ThongTinS");
                dgv_inf_book.DataSource = ds_ThongTinS.Tables["ThongTinS"];
            }

        }
        
        private void frmBanSach_Load(object sender, EventArgs e)
        {
            Load_ThongTin();
            dgv_inf_book.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgv_inf_book_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_inf_book.SelectedRows.Count > 0)
            {
                DataGridViewRow chon = dgv_inf_book.SelectedRows[0];
                string ma = chon.Cells["MaSach"].Value.ToString();

           
                bool itemExists = false;
                foreach (ListViewItem item in lv_DonHang.Items)
                {
                    if (ma == item.SubItems[0].Text)
                    {

                        int slTemp;
                        if (int.TryParse(txt_soluong.Text, out slTemp))
                        {
                            int sl = slTemp + int.Parse(item.SubItems[2].Text);
                            item.SubItems[2].Text = sl.ToString();
                        }
                        else
                        {
                           
                            int sl = 1 + int.Parse(item.SubItems[2].Text);
                            item.SubItems[2].Text = sl.ToString();
                        }
                        double donGia = double.Parse(chon.Cells["GiaBan"].Value.ToString());
                        double totalPrice = int.Parse(item.SubItems[2].Text) * donGia;
                        item.SubItems[4].Text = totalPrice.ToString();
                        itemExists = true; 
                        break; 
                    }
                }

             
                if (!itemExists)
                {
                    int slTemp;
                    int sl = 1; 
                    if (!string.IsNullOrWhiteSpace(txt_soluong.Text) && int.TryParse(txt_soluong.Text, out slTemp))
                    {
                        sl = slTemp; 
                    }
                    double donGia = double.Parse(chon.Cells["GiaBan"].Value.ToString());
                    double totalPrice = sl * donGia;

                    ListViewItem ls = new ListViewItem(ma);
                    ls.SubItems.Add(chon.Cells["TenSach"].Value.ToString());
                    ls.SubItems.Add(sl.ToString());
                    ls.SubItems.Add(chon.Cells["GiaBan"].Value.ToString());
                    ls.SubItems.Add(totalPrice.ToString());
                    lv_DonHang.Items.Add(ls);
                }

                UpdateTotalPrice(); 
            }



        }
        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (ListViewItem item in lv_DonHang.Items)
            {
                int quantity = int.Parse(item.SubItems[2].Text);
                decimal unitPrice = decimal.Parse(item.SubItems[3].Text);
                decimal itemTotal = quantity * unitPrice;
                totalPrice += itemTotal;
            }

       
            txt_tongtien.Text = totalPrice.ToString();
        }
        private void ModifyQuantity(bool increase)
        {

            if (lv_DonHang.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_DonHang.SelectedItems[0];
                int soLuong = int.Parse(selectedItem.SubItems[2].Text);

                if (increase)
                {
           
                    soLuong++;
                }
                else
                {
            
                    if (soLuong > 1)
                    {
                        soLuong--;
                    }
                    else
                    {
                      
                        lv_DonHang.Items.Remove(selectedItem);
                        UpdateTotalPrice();
                        return; 
                    }
                }

                selectedItem.SubItems[2].Text = soLuong.ToString();
                UpdateTotalPrice();
            }
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        
        private void btn_tang1_Click(object sender, EventArgs e)
        {
            ModifyQuantity(true);
        }

        private void btn_giam1_Click(object sender, EventArgs e)
        {
            ModifyQuantity(false);
        }
        
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lv_DonHang.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_DonHang.SelectedItems[0];
                lv_DonHang.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để xóa.");
            }
        }
        public string maIn;
        private void btn_dat_Click(object sender, EventArgs e)
        {
            string sdt = "0941824972";
            using (frm_Input_Khach kh = new frm_Input_Khach())
            {
                if (kh.ShowDialog() == DialogResult.OK)
                {
                    sdt = kh.LayPhone;
                }
            }

            string maDH = a.GenerateMaDH();
            maIn = maDH;

            string maKH = a.layMaTuSDT(sdt);
            if (string.IsNullOrEmpty(maKH))
            {
                maKH = "KH001";
            }

            int t = a.themDonHang(maDH, maKH);
            if (t == 1)
            {
                int b = 0;
                foreach (ListViewItem item in lv_DonHang.Items)
                {
                    string maCTDH = a.GenerateMaCTDH();
                    string maS = item.SubItems[0].Text;
                    string sl = item.SubItems[2].Text;
                    string gia = item.SubItems[3].Text;
                    a.themChiTietDonHang(maCTDH, maDH, maS, int.Parse(sl), double.Parse(gia));
                    b = 1;
                    
                }
               
                if (b == 1)
                {
                    MessageBox.Show("Thêm Vào Đơn Hàng Thành Công!", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Danh sách đơn hàng trống hoặc có lỗi", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Đơn Hàng Bị Lỗi", "Thông Báo");
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            int t = 1;
            if (rdo_timten.Checked)
            {
                t = 1;
            }
            if (rdo_timtg.Checked)
            {
                t = 2;
            }

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
        
                ds_ThongTinS.Tables["ThongTinS"].Clear();

                string sql = "TimSachTheoTenTacGia";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ten", txt_tim.Text);
                cmd.Parameters.AddWithValue("@bien", t);
                da_ThongTinS.SelectCommand = cmd;
                da_ThongTinS.Fill(ds_ThongTinS, "ThongTinS");
                dgv_inf_book.DataSource = ds_ThongTinS.Tables["ThongTinS"];
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            ds_ThongTinS.Tables["ThongTinS"].Clear();
            Load_ThongTin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection(conStr))
            {
                con.Open();
                string sql = "LayThongTinDonHang";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maDH", maIn);
                SqlDataAdapter da_ThongTinHD = new SqlDataAdapter();
                da_ThongTinHD.SelectCommand = cmd;
                DataTable dt = new DataTable("HoaDonIn");
                da_ThongTinHD.Fill(dt);
                //
                rpt_InHoaDon baocao = new rpt_InHoaDon();
                baocao.SetDataSource(dt);
                //hienthi
                frmInHoaDon f = new frmInHoaDon();
                f.crystalReportViewer1.ReportSource = baocao;
                f.ShowDialog();

            }
            
        }

        private void btn_qlsach_Click(object sender, EventArgs e)
        {
            frm_Sach a = new frm_Sach();
            this.Hide();
            a.Show();
        }

        private void btn_bansach_Click(object sender, EventArgs e)
        {
            frmBanSach a = new frmBanSach();
            this.Hide();
            a.Show();
        }


       
    }
}
