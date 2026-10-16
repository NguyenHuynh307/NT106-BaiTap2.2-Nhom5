using System;
using System.Windows.Forms;
using QuanLyNguoiDung.Data;

namespace QuanLyNguoiDung
{
    public partial class FormDangKi : Form
    {
        private readonly IUserRepository _userRepository = new UserRepository();

        public FormDangKi()
        {
            InitializeComponent();
            btnDangKy.Click += btnDangKy_Click;
        }

        private void btnHuy_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkLogin_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private async void btnDangKy_Click(object? sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();
            string xacNhanMatKhau = txtConfirmPassword.Text.Trim();
            string hoTen = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (await _userRepository.KiemTraTonTaiAsync(tenDangNhap))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NguoiDung nguoiDungMoi = new NguoiDung
                {
                    TenDangNhap = tenDangNhap,
                    HoTen = hoTen,
                    Email = email
                };

                if (await _userRepository.DangKyNguoiDungAsync(nguoiDungMoi, matKhau))
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}