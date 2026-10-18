using System.Text.RegularExpressions;
using QuanLyNguoiDung.Data;

namespace QuanLyNguoiDung
{
    public partial class FrmDangKy : Form
    {
        private readonly IUserRepository _userRepository = new UserRepository();

        private static readonly Regex RegexTenDangNhap =
            new(@"^[A-Za-z0-9_]{3,20}$");

        private static readonly Regex RegexEmail =
            new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        public FrmDangKy()
        {
            InitializeComponent();
            txtMatKhau.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtXacNhanMatKhau.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;

            btnDangKy.Click += btnDangKy_Click;
            AcceptButton = btnDangKy;
            CancelButton = btnHuy;

            txtTenDangNhap.MaxLength = 20;
            txtMatKhau.MaxLength = 64;
            txtXacNhanMatKhau.MaxLength = 64;
            txtHoTen.MaxLength = 50;
            txtEmail.MaxLength = 100;
        }

        private void XoaLoi()
        {
            lblLoiTenDangNhap.Text = string.Empty;
            lblLoiMatKhau.Text = string.Empty;
            lblLoiXacNhanMatKhau.Text = string.Empty;
            lblLoiHoTen.Text = string.Empty;
            lblLoiEmail.Text = string.Empty;
        }

        private Control? KiemTraDuLieu(
            string ten,
            string matKhau,
            string xacNhan,
            string hoTen,
            string email)
        {
            Control? loiDauTien = null;

            void DatLoi(Label nhan, Control o, string noiDung)
            {
                nhan.Text = noiDung;

                if (loiDauTien == null)
                    loiDauTien = o;
            }

            if (ten.Length == 0)
                DatLoi(lblLoiTenDangNhap, txtTenDangNhap,
                    "Vui lòng nhập tên đăng nhập.");
            else if (!RegexTenDangNhap.IsMatch(ten))
                DatLoi(lblLoiTenDangNhap, txtTenDangNhap,
                    "Tên đăng nhập 3-20 ký tự: chữ không dấu, số, dấu _.");

            if (matKhau.Length == 0)
                DatLoi(lblLoiMatKhau, txtMatKhau,
                    "Vui lòng nhập mật khẩu.");
            else if (matKhau.Length < 8 || matKhau.Length > 64 ||
                     !matKhau.Any(char.IsLetter) ||
                     !matKhau.Any(char.IsDigit))
                DatLoi(lblLoiMatKhau, txtMatKhau,
                    "Mật khẩu cần 8-64 ký tự, có ít nhất một chữ và một số.");

            if (xacNhan.Length == 0)
                DatLoi(lblLoiXacNhanMatKhau, txtXacNhanMatKhau,
                    "Vui lòng xác nhận mật khẩu.");
            else if (xacNhan != matKhau)
                DatLoi(lblLoiXacNhanMatKhau, txtXacNhanMatKhau,
                    "Hai ô mật khẩu không giống nhau.");

            if (hoTen.Length == 0)
                DatLoi(lblLoiHoTen, txtHoTen,
                    "Vui lòng nhập họ và tên.");
            else if (hoTen.Length < 2 || hoTen.Length > 50 ||
                     !hoTen.All(c => char.IsLetter(c) || c == ' '))
                DatLoi(lblLoiHoTen, txtHoTen,
                    "Họ tên cần 2-50 ký tự, gồm chữ cái và khoảng trắng.");

            // Email khong bat buoc.
            if (email.Length > 0 &&
                (email.Length > 100 || !RegexEmail.IsMatch(email)))
                DatLoi(lblLoiEmail, txtEmail,
                    "Email không hợp lệ hoặc vượt quá 100 ký tự.");

            return loiDauTien;
        }

        private async void btnDangKy_Click(object? sender, EventArgs e)
        {
            XoaLoi();

            string ten = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string xacNhan = txtXacNhanMatKhau.Text;
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Kiem tra tai cho truoc khi goi database.
            Control? oLoi = KiemTraDuLieu(
                ten, matKhau, xacNhan, hoTen, email);

            if (oLoi != null)
            {
                if (oLoi == txtXacNhanMatKhau)
                {
                    txtMatKhau.Clear();
                    txtXacNhanMatKhau.Clear();
                    oLoi = txtMatKhau;
                }

                oLoi.Focus();
                return;
            }

            btnDangKy.Enabled = false;
            btnDangKy.Text = "Đang xử lý...";

            try
            {
                if (await _userRepository.KiemTraTonTaiAsync(ten))
                {
                    lblLoiTenDangNhap.Text = "Tên này đã có người dùng.";
                    txtTenDangNhap.Focus();
                    return;
                }

                var nguoiDung = new NguoiDung
                {
                    TenDangNhap = ten,
                    HoTen = hoTen,
                    Email = string.IsNullOrWhiteSpace(email) ? null : email
                };

                bool thanhCong =
                    await _userRepository.DangKyNguoiDungAsync(nguoiDung, matKhau);

                if (!thanhCong)
                {
                    // UNIQUE trong database la lop bao ve cuoi cung.
                    lblLoiTenDangNhap.Text = "Tên này đã có người dùng.";
                    txtTenDangNhap.Focus();
                    return;
                }

                MessageBox.Show(
                    "Đăng ký tài khoản thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            catch (LoiCoSoDuLieuException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Đã xảy ra lỗi không mong muốn. Vui lòng thử lại.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnDangKy.Enabled = true;
                btnDangKy.Text = "Đăng ký";
            }
        }

        private void btnHuy_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}