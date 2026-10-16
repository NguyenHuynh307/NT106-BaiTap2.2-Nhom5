using System;
using Microsoft.Data.SqlClient;

namespace QuanLyNguoiDung.Data
{
    public class UserRepository : IUserRepository
    {
  
        private readonly string _connectionString = @"Data Source=.;Initial Catalog=QuanLyNguoiDungDB;Integrated Security=True;TrustServerCertificate=True;";

        public UserRepository() { }

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(1) FROM NguoiDung WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool DangKyNguoiDung(NguoiDung nguoiDung)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO NguoiDung (TenDangNhap, MatKhau, HoTen, Email) VALUES (@TenDangNhap, @MatKhau, @HoTen, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", nguoiDung.TenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", nguoiDung.MatKhau);
                    cmd.Parameters.AddWithValue("@HoTen", nguoiDung.HoTen);
                    cmd.Parameters.AddWithValue("@Email", nguoiDung.Email);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        public bool KiemTraTonTai(string tenDangNhap)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(1) FROM NguoiDung WHERE TenDangNhap = @TenDangNhap";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public NguoiDung? GetByTenDangNhap(string tenDangNhap)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT TenDangNhap, MatKhau, HoTen, Email FROM NguoiDung WHERE TenDangNhap = @TenDangNhap";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new NguoiDung
                            {
                                TenDangNhap = reader["TenDangNhap"].ToString() ?? "",
                                MatKhau = reader["MatKhau"].ToString() ?? "",
                                HoTen = reader["HoTen"].ToString() ?? "",
                                Email = reader["Email"].ToString() ?? ""
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}