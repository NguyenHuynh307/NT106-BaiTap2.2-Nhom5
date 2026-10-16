using System;
using System.Windows.Forms;
using QuanLyNguoiDung.Data;

namespace QuanLyNguoiDung
{
    public partial class FormDangNhap : Form
    {
        private readonly IUserRepository _userRepository = new UserRepository();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object? sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_userRepository.KiemTraDangNhap(tenDangNhap, matKhau))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormTrangChinh formTrangChinh = new FormTrangChinh();
                formTrangChinh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkRegister_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKi frmRegister = new FormDangKi();
            this.Hide();
            frmRegister.ShowDialog();
            this.Show();
        }
    }
}