using System.Data;
using System.Text.Json;
using Microsoft.Data.SqlClient;

namespace QuanLyNguoiDung.Data
{
    public class UserRepository : IUserRepository
    {
        private const string CHUOI_KET_NOI_MAC_DINH =
            @"Server=localhost\SQLEXPRESS;Database=QuanLyNguoiDung;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;";

        private const string LOI_CSDL =
            "Không kết nối được cơ sở dữ liệu. Hãy thử lại.";

        private readonly string _connectionString;

        public UserRepository()
        {
            _connectionString = DocChuoiKetNoi();
        }

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private static string DocChuoiKetNoi()
        {
            try
            {
                string path = Path.Combine(
                    AppContext.BaseDirectory,
                    "appsettings.json");

                if (File.Exists(path))
                {
                    using JsonDocument doc =
                        JsonDocument.Parse(File.ReadAllText(path));

                    if (doc.RootElement.TryGetProperty(
                            "ConnectionStrings", out JsonElement section) &&
                        section.TryGetProperty(
                            "DefaultConnection", out JsonElement item))
                    {
                        string? value = item.GetString();

                        if (!string.IsNullOrWhiteSpace(value))
                            return value;
                    }
                }
            }
            catch (Exception)
            {
                // Cau hinh loi thi thu dung chuoi ket noi mac dinh.
            }

            return CHUOI_KET_NOI_MAC_DINH;
        }

        public async Task<bool> KiemTraTonTaiAsync(string tenDangNhap)
        {
            const string sql =
                "SELECT COUNT(1) FROM dbo.Users WHERE TenDangNhap = @ten";

            try
            {
                using var conn = new SqlConnection(_connectionString);
                using var cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value =
                    tenDangNhap;

                await conn.OpenAsync();

                object? result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result) > 0;
            }
            catch (SqlException ex)
            {
                throw new LoiCoSoDuLieuException(LOI_CSDL, ex);
            }
            catch (Exception ex) when (
                ex is InvalidOperationException ||
                ex is ArgumentException ||
                ex is TimeoutException)
            {
                throw new LoiCoSoDuLieuException(LOI_CSDL, ex);
            }
        }

        public async Task<bool> DangKyNguoiDungAsync(
            NguoiDung nguoiDung,
            string matKhauTho)
        {
            // PBKDF2 ton CPU; chay nen de khong chan luong giao dien.
            var (salt, bam) =
                await Task.Run(() => MatKhau.Tao(matKhauTho));

            const string sql =
                "INSERT INTO dbo.Users (TenDangNhap, MatKhauBam, Salt, HoTen, Email) VALUES (@ten, @bam, @salt, @hoTen, @email)";

            try
            {
                using var conn = new SqlConnection(_connectionString);
                using var cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value =
                    nguoiDung.TenDangNhap;

                cmd.Parameters.Add("@bam", SqlDbType.NVarChar, 64).Value = bam;

                cmd.Parameters.Add("@salt", SqlDbType.NVarChar, 32).Value =
                    salt;

                cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar, 50).Value =
                    nguoiDung.HoTen;

                object emailValue = string.IsNullOrWhiteSpace(nguoiDung.Email)
                    ? DBNull.Value
                    : nguoiDung.Email;

                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value =
                    emailValue;

                await conn.OpenAsync();

                return await cmd.ExecuteNonQueryAsync() > 0;
            }
            catch (SqlException ex) when (
                ex.Number == 2627 || ex.Number == 2601)
            {
                // UNIQUE chan ten dang nhap trung, ke ca khi hai yeu cau
                // dang ky xay ra gan nhu dong thoi.
                return false;
            }
            catch (SqlException ex)
            {
                throw new LoiCoSoDuLieuException(LOI_CSDL, ex);
            }
            catch (Exception ex) when (
                ex is InvalidOperationException ||
                ex is ArgumentException ||
                ex is TimeoutException)
            {
                throw new LoiCoSoDuLieuException(LOI_CSDL, ex);
            }
        }

        public async Task<NguoiDung?> GetByTenDangNhapAsync(
            string tenDangNhap)
        {
            const string sql =
                "SELECT UserId, TenDangNhap, MatKhauBam, Salt, HoTen, Email, NgayTao, LanDangNhapCuoi FROM dbo.Users WHERE TenDangNhap = @ten";

            try
            {
                using var conn = new SqlConnection(_connectionString);
                using var cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value =
                    tenDangNhap;

                await conn.OpenAsync();

                using var reader = await cmd.ExecuteReaderAsync();

                if (!await reader.ReadAsync())
                    return null;

                return new NguoiDung
                {
                    UserId = reader.GetInt32(0),
                    TenDangNhap = reader.GetString(1),
                    MatKhauBam = reader.GetString(2),
                    Salt = reader.GetString(3),
                    HoTen = reader.GetString(4),
                    Email = reader.IsDBNull(5) ? null : reader.GetString(5),
                    NgayTao = reader.IsDBNull(6)
                        ? null : reader.GetDateTime(6),
                    LanDangNhapCuoi = reader.IsDBNull(7)
                        ? null : reader.GetDateTime(7)
                };
            }
            catch (SqlException ex)
            {
                throw new LoiCoSoDuLieuException(LOI_CSDL, ex);
            }
            catch (Exception ex) when (
                ex is InvalidOperationException ||
                ex is ArgumentException ||
                ex is TimeoutException)
            {
                throw new LoiCoSoDuLieuException(LOI_CSDL, ex);
            }
        }

        public async Task CapNhatLanDangNhapCuoiAsync(
            string tenDangNhap)
        {
            const string sql =
                "UPDATE dbo.Users SET LanDangNhapCuoi = SYSDATETIME() WHERE TenDangNhap = @ten";

            try
            {
                using var conn = new SqlConnection(_connectionString);
                using var cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value =
                    tenDangNhap;

                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            catch (SqlException ex)
            {
                throw new LoiCoSoDuLieuException(LOI_CSDL, ex);
            }
            catch (Exception ex) when (
                ex is InvalidOperationException ||
                ex is ArgumentException ||
                ex is TimeoutException)
            {
                throw new LoiCoSoDuLieuException(LOI_CSDL, ex);
            }
        }

        public async Task<NguoiDung?> DangNhapAsync(
            string tenDangNhap,
            string matKhauTho)
        {
            NguoiDung? nguoiDung =
                await GetByTenDangNhapAsync(tenDangNhap);

            // Khong tiet lo ten dang nhap co ton tai hay khong.
            if (nguoiDung == null)
                return null;

            bool dung;
            try
            {
                dung = await Task.Run(() =>
                    MatKhau.KiemTra(
                        matKhauTho,
                        nguoiDung.Salt,
                        nguoiDung.MatKhauBam));
            }
            catch (FormatException)
            {
                // Salt/hash khong dung Base64 thi coi la dang nhap that bai.
                return null;
            }

            if (!dung)
                return null;

            // NguoiDung vua doc van giu thoi diem dang nhap truoc do.
            await CapNhatLanDangNhapCuoiAsync(tenDangNhap);

            return nguoiDung;
        }
    }
}