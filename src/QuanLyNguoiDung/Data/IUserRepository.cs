namespace QuanLyNguoiDung.Data
{
    public interface IUserRepository
    {
        bool KiemTraDangNhap(string tenDangNhap, string matKhau);
        bool DangKyNguoiDung(NguoiDung nguoiDung);
        bool KiemTraTonTai(string tenDangNhap);
        NguoiDung? GetByTenDangNhap(string tenDangNhap);
    }
}