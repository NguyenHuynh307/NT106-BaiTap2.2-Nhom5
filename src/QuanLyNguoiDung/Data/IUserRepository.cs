using System.Threading.Tasks;

namespace QuanLyNguoiDung.Data
{
    public interface IUserRepository
    {
        Task<bool> KiemTraTonTaiAsync(string tenDangNhap);
        Task<bool> DangKyNguoiDungAsync(NguoiDung nguoiDung, string matKhauTho);
        Task<NguoiDung?> GetByTenDangNhapAsync(string tenDangNhap);
        Task<bool> CapNhatLanDangNhapCuoiAsync(string tenDangNhap);
        Task<bool> KiemTraDangNhapAsync(string tenDangNhap, string matKhau);

        bool KiemTraTonTai(string tenDangNhap);
        bool DangKyNguoiDung(NguoiDung nguoiDung, string matKhauTho);
        bool KiemTraDangNhap(string tenDangNhap, string matKhau);
    }
}