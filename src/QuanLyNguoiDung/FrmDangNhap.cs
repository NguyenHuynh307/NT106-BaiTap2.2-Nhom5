using QuanLyNguoiDung.Data;

namespace QuanLyNguoiDung
{
    public partial class FrmDangNhap : Form
    {
        private readonly IUserRepository _userRepository = new UserRepository();

        public FrmDangNhap()
        {
            InitializeComponent();
            txtMatKhau.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            txtTenDangNhap.PlaceholderText = "nhập tên đăng nhập";
            txtMatKhau.PlaceholderText = "nhập mật khẩu";

            // Designer da gan nut Thoat va lien ket Dang ky.
            // Nut Dang nhap duoc noi tai day.
            btnDangNhap.Click += btnDangNhap_Click;
            AcceptButton = btnDangNhap;

            txtTenDangNhap.MaxLength = 20;
        }

        private void XoaLoi()
        {
            lblLoi.Text = string.Empty;
        }

        private async void btnDangNhap_Click(object? sender, EventArgs e)
        {
            XoaLoi();

            string ten = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (ten.Length == 0 || matKhau.Length == 0)
            {
                lblLoi.Text = "Vui lòng nhập tên đăng nhập và mật khẩu.";

                if (ten.Length == 0)
                    txtTenDangNhap.Focus();
                else
                    txtMatKhau.Focus();

                return;
            }

            btnDangNhap.Enabled = false;
            btnDangNhap.Text = "Đang xử lý...";

            try
            {
                NguoiDung? nguoiDung =
                    await _userRepository.DangNhapAsync(ten, matKhau);

                if (nguoiDung == null)
                {
                    // Dung cung thong bao cho ten khong ton tai va mat khau sai.
                    lblLoi.Text = "Tên đăng nhập hoặc mật khẩu không đúng.";
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                MoFormChinh(nguoiDung);
            }
            catch (LoiCoSoDuLieuException ex)
            {
                lblLoi.Text = ex.Message;
            }
            catch (Exception)
            {
                lblLoi.Text = "Đã xảy ra lỗi không mong muốn. Vui lòng thử lại.";
            }
            finally
            {
                btnDangNhap.Enabled = true;
                btnDangNhap.Text = "Đăng nhập";
            }
        }

        private void MoFormChinh(NguoiDung nguoiDung)
        {
            Hide();

            try
            {
                using var frm = new FrmChinh(nguoiDung);
                frm.ShowDialog();
            }
            finally
            {
                txtMatKhau.Clear();
                XoaLoi();
                Show();
                txtTenDangNhap.Focus();
            }
        }

        private void btnThoat_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void lnkDangKy_LinkClicked(
            object? sender,
            LinkLabelLinkClickedEventArgs e)
        {
            Hide();

            try
            {
                using var frm = new FrmDangKy();
                frm.ShowDialog();
            }
            finally
            {
                Show();
                txtTenDangNhap.Focus();
            }
        }
    }
}