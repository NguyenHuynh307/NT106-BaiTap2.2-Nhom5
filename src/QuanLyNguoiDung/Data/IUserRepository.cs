namespace QuanLyNguoiDung.Data
{
    public interface IUserRepository
    {
        bool KiemTraDangNhap(string tenDangNhap, string matKhau);
        Task<bool> DangKyNguoiDung(NguoiDung nguoiDung);
        Task<bool> KiemTraTonTai(string tenDangNhap);
        NguoiDung? GetByTenDangNhap(string tenDangNhap);
    }
}