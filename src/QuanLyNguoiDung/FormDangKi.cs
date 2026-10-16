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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private async void btnDangKy_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();
            string xacNhanMatKhau = txtConfirmPassword.Text.Trim();
            string hoTen = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(email) && !email.Contains("@"))
            {
                MessageBox.Show("Email không đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            //khoa nut, doi ten thanh Dang Xu Ly
            btnDangKy.Enabled = false;
            btnDangKy.Text = "Đang xử lý...";

            try
            {
                //kiem tra trung ten dang nhap
                bool isExists = await _userRepository.KiemTraTonTai(tenDangNhap);
                if (isExists)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }

                NguoiDung nguoiDungMoi = new NguoiDung
                {
                    TenDangNhap = tenDangNhap,
                    MatKhau = matKhau,
                    HoTen = hoTen,
                    Email = email
                };

                //thuc hien dang ky (INSERT) va kiem tra trung bang UNIQUE
                bool success = await _userRepository.DangKyNguoiDung(nguoiDungMoi);
                if (success)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng ký thất bại, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //mo lai nut bam
                btnDangKy.Enabled = true;
                btnDangKy.Text = "Đăng ký";
            }
        }

        private void btnDangKy_Click_1(object sender, EventArgs e)
        {

        }
    }
}