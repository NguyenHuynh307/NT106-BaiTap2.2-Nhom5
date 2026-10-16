using System;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QuanLyNguoiDung.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository()
        {
            _connectionString = LoadConnectionString();
        }

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private static string LoadConnectionString()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
                if (File.Exists(filePath))
                {
                    string jsonText = File.ReadAllText(filePath);
                    using (JsonDocument document = JsonDocument.Parse(jsonText))
                    {
                        if (document.RootElement.TryGetProperty("ConnectionStrings", out JsonElement connSection) &&
                            connSection.TryGetProperty("DefaultConnection", out JsonElement connString))
                        {
                            string? value = connString.GetString();
                            if (!string.IsNullOrWhiteSpace(value))
                            {
                                return value;
                            }
                        }
                    }
                }
            }
            catch
            {
            }
            return @"Server=.;Database=QuanLyNguoiDung;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        private static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        private static string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] combinedBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(combinedBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        private static bool VerifyPassword(string password, string salt, string hash)
        {
            string calculatedHash = HashPassword(password, salt);
            return string.Equals(calculatedHash, hash, StringComparison.Ordinal);
        }

        private static Exception HandleSqlException(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                return new Exception("Tên đăng nhập hoặc dữ liệu đã tồn tại trong hệ thống!");
            }
            if (ex.Number == -1 || ex.Number == 2 || ex.Number == 53)
            {
                return new Exception("Mất kết nối với máy chủ SQL Server. Vui lòng kiểm tra lại dịch vụ CSDL!");
            }
            return new Exception("Đã xảy ra lỗi khi truy vấn cơ sở dữ liệu. Vui lòng thử lại sau!");
        }

        public async Task<bool> KiemTraTonTaiAsync(string tenDangNhap)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "SELECT COUNT(1) FROM NguoiDung WHERE TenDangNhap = @TenDangNhap";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar, 50).Value = tenDangNhap;
                        await conn.OpenAsync();
                        object? result = await cmd.ExecuteScalarAsync();
                        return Convert.ToInt32(result) > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw HandleSqlException(ex);
            }
        }

        public async Task<bool> DangKyNguoiDungAsync(NguoiDung nguoiDung, string matKhauTho)
        {
            try
            {
                string salt = GenerateSalt();
                string matKhauBam = HashPassword(matKhauTho, salt);

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO NguoiDung (TenDangNhap, Salt, MatKhauBam, HoTen, Email, NgayTao) VALUES (@TenDangNhap, @Salt, @MatKhauBam, @HoTen, @Email, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar, 50).Value = nguoiDung.TenDangNhap;
                        cmd.Parameters.Add("@Salt", SqlDbType.NVarChar, 100).Value = salt;
                        cmd.Parameters.Add("@MatKhauBam", SqlDbType.NVarChar, 256).Value = matKhauBam;
                        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 100).Value = (object?)nguoiDung.HoTen ?? DBNull.Value;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = (object?)nguoiDung.Email ?? DBNull.Value;

                        await conn.OpenAsync();
                        int rows = await cmd.ExecuteNonQueryAsync();
                        return rows > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw HandleSqlException(ex);
            }
        }

        public async Task<NguoiDung?> GetByTenDangNhapAsync(string tenDangNhap)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "SELECT TenDangNhap, Salt, MatKhauBam, HoTen, Email, NgayTao, LanDangNhapCuoi FROM NguoiDung WHERE TenDangNhap = @TenDangNhap";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar, 50).Value = tenDangNhap;
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                return new NguoiDung
                                {
                                    TenDangNhap = reader["TenDangNhap"].ToString() ?? string.Empty,
                                    Salt = reader["Salt"].ToString() ?? string.Empty,
                                    MatKhauBam = reader["MatKhauBam"].ToString() ?? string.Empty,
                                    HoTen = reader["HoTen"].ToString() ?? string.Empty,
                                    Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : null,
                                    NgayTao = reader["NgayTao"] != DBNull.Value ? Convert.ToDateTime(reader["NgayTao"]) : null,
                                    LanDangNhapCuoi = reader["LanDangNhapCuoi"] != DBNull.Value ? Convert.ToDateTime(reader["LanDangNhapCuoi"]) : null
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (SqlException ex)
            {
                throw HandleSqlException(ex);
            }
        }

        public async Task<bool> CapNhatLanDangNhapCuoiAsync(string tenDangNhap)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    string query = "UPDATE NguoiDung SET LanDangNhapCuoi = GETDATE() WHERE TenDangNhap = @TenDangNhap";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar, 50).Value = tenDangNhap;
                        await conn.OpenAsync();
                        int rows = await cmd.ExecuteNonQueryAsync();
                        return rows > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw HandleSqlException(ex);
            }
        }

        public async Task<bool> KiemTraDangNhapAsync(string tenDangNhap, string matKhau)
        {
            NguoiDung? user = await GetByTenDangNhapAsync(tenDangNhap);
            if (user == null)
            {
                return false;
            }

            bool isValid = VerifyPassword(matKhau, user.Salt, user.MatKhauBam);
            if (isValid)
            {
                await CapNhatLanDangNhapCuoiAsync(tenDangNhap);
                return true;
            }
            return false;
        }

        public bool KiemTraTonTai(string tenDangNhap)
        {
            return KiemTraTonTaiAsync(tenDangNhap).GetAwaiter().GetResult();
        }

        public bool DangKyNguoiDung(NguoiDung nguoiDung, string matKhauTho)
        {
            return DangKyNguoiDungAsync(nguoiDung, matKhauTho).GetAwaiter().GetResult();
        }

        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            return KiemTraDangNhapAsync(tenDangNhap, matKhau).GetAwaiter().GetResult();
        }
    }
}