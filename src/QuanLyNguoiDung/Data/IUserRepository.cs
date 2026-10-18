namespace QuanLyNguoiDung.Data
{
    public interface IUserRepository
    {
        Task<bool> KiemTraTonTaiAsync(string tenDangNhap);

        Task<bool> DangKyNguoiDungAsync(
            NguoiDung nguoiDung,
            string matKhauTho);

        Task<NguoiDung?> GetByTenDangNhapAsync(string tenDangNhap);

        Task CapNhatLanDangNhapCuoiAsync(string tenDangNhap);

        // Tra ve null neu ten dang nhap khong ton tai hoac mat khau sai.
        Task<NguoiDung?> DangNhapAsync(
            string tenDangNhap,
            string matKhauTho);
    }
}