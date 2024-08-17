using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_BanSach
{
    class ConnectSQL
    {
        string conStr = @"Data Source=DuyCute\DuyCute;Initial Catalog=THHQTCSDL_QLBS;Integrated Security=True";
        public int KiemTraSDT(string sdt)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string sql = "KiemTraSDT";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    int count = (int)cmd.ExecuteScalar();
                    return count;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error, show a user-friendly message, etc.)
                Console.WriteLine(String.Format("An error occurred: {0}", ex.Message));
                return -1; // Return a specific value indicating an error
            }
        }

        private readonly object lockObject = new object();
        public string GenerateMaKH()
        {
            lock (lockObject)
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string query = "SELECT TOP 1 MaKH FROM KhachHang ORDER BY MaKH DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    object result = cmd.ExecuteScalar();

                    if (result != null) 
                    {
                     
                        int lastNumber = int.Parse(result.ToString().Substring(2));
                        int nextNumber = lastNumber + 1;

                        string newMaNhanVien = string.Format("KH{0:D3}", nextNumber);

                        if (MaKHExists(newMaNhanVien))
                        {
                            nextNumber++;
                            newMaNhanVien = string.Format("KH{0:D3}", nextNumber);
                        }

                        return newMaNhanVien;
                    }
                    else
                    {
                        return "KH001";
                    }
                }
            }
        }
        private bool MaKHExists(string maKH)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKhachHang";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaKhachHang", maKH);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public int themKhachHang(string ma, string ten,string dc,string sdt,string email)
        {
            using(SqlConnection con=new SqlConnection(conStr))
            {
                con.Open();
                string sql = "ThemKhachHang";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maKH", ma);
                cmd.Parameters.AddWithValue("@tenKH", ten);
                cmd.Parameters.AddWithValue("@diaChi", dc);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@email", email);
                int count = cmd.ExecuteNonQuery();
                return count;
            }
        }

        public string layMaTuSDT(string sdt)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string sql = "layMaTuSDT";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sdt", sdt);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string ma = result.ToString();
                        return ma;
                    }
                    else
                    {
                        // Handle the case where the result is null (no matching record found)
                        Console.WriteLine("No record found for the provided phone number.");
                        return null; // Or throw a custom exception, or return an appropriate value
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error, show a user-friendly message, etc.)
                Console.WriteLine("An error occurred while retrieving data: " + ex.Message);
                // You might want to throw the exception again or return an appropriate value
                return null; // Or throw a custom exception, or return an appropriate value
            }
        }

        //don hang
        private readonly object lockObject1 = new object();
        public string GenerateMaDH()
        {
            lock (lockObject1)
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string query = "SELECT TOP 1 MaDH FROM DonHang ORDER BY MaDH DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    object result = cmd.ExecuteScalar();

                    if (result != null) 
                    {
                     
                        int lastNumber = int.Parse(result.ToString().Substring(2));
                        int nextNumber = lastNumber + 1;

                        string newMaNhanVien = string.Format("DH{0:D3}", nextNumber);

                        if (MaDHExists(newMaNhanVien))
                        {
                            nextNumber++;
                            newMaNhanVien = string.Format("DH{0:D3}", nextNumber);
                        }

                        return newMaNhanVien;
                    }
                    else
                    {
                        return "DH001";
                    }
                }
            }
        }
        private bool MaDHExists(string maDH)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM DonHang WHERE MaDH = @MaDonHang";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaDonHang", maDH);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public int themDonHang(string maDH, string maKH)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string sql = "themDonHang";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maDH", maDH);
                    cmd.Parameters.AddWithValue("@maKH", maKH);
                    int affectedRows = cmd.ExecuteNonQuery();
                    return affectedRows;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error, show a user-friendly message, etc.)
                Console.WriteLine("An error occurred while inserting data: " + ex.Message);
                // You might want to throw the exception again or return an appropriate value
                return -1; // Or throw a custom exception, or return an appropriate value
            }
        }

        //chi tiết
        private readonly object lockObject2 = new object();
        public string GenerateMaCTDH()
        {
            lock (lockObject2)
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string query = "SELECT TOP 1 MaCTDH FROM ChiTietDonHang ORDER BY MaCTDH DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    object result = cmd.ExecuteScalar();

                    if (result != null) 
                    {
                     
                        int lastNumber = int.Parse(result.ToString().Substring(2));
                        int nextNumber = lastNumber + 1;

                        string newMaNhanVien = string.Format("CT{0:D3}", nextNumber);

                        if (MaCTDHExists(newMaNhanVien))
                        {
                            nextNumber++;
                            newMaNhanVien = string.Format("CT{0:D3}", nextNumber);
                        }

                        return newMaNhanVien;
                    }
                    else
                    {
                        return "CT001";
                    }
                }
            }
        }
        private bool MaCTDHExists(string maCTDH)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM ChiTietDonHang WHERE MaCTDH = @MaCTDH";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaCTDH", maCTDH);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public void themChiTietDonHang(string maCTDH,string maDH,string maS, int sl,double gia)
        {
            using(SqlConnection con=new SqlConnection(conStr))
            {
                con.Open();
                string sql = "themChiTietDonHang";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maCTDH", maCTDH);
                cmd.Parameters.AddWithValue("@maDH", maDH);
                cmd.Parameters.AddWithValue("@maSach", maS);
                cmd.Parameters.AddWithValue("@soLuong", sl);
                cmd.Parameters.AddWithValue("@giaBan", gia);
                cmd.ExecuteNonQuery();
            }
        }
        //Sách
        private readonly object lockObject3 = new object();
        public string GenerateMaSach()
        {
            lock (lockObject3)
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    string query = "SELECT TOP 1 MaSach FROM Sach ORDER BY MaSach DESC";
                    SqlCommand cmd = new SqlCommand(query, con);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {

                        int lastNumber = int.Parse(result.ToString().Substring(2));
                        int nextNumber = lastNumber + 1;

                        string newMaNhanVien = string.Format("SH{0:D3}", nextNumber);

                        if (MaSachExists(newMaNhanVien))
                        {
                            nextNumber++;
                            newMaNhanVien = string.Format("SH{0:D3}", nextNumber);
                        }

                        return newMaNhanVien;
                    }
                    else
                    {
                        return "SH001";
                    }
                }
            }
        }
        private bool MaSachExists(string MaSach)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Sach WHERE MaSach = @Masach";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Masach", MaSach);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
