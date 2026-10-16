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
            btnDangNhap.Click += btnDangNhap_Click;
        }

        private void btnThoat_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkRegister_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKi formDangKi = new FormDangKi();
            formDangKi.ShowDialog();
        }

        private async void btnDangNhap_Click(object? sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool isSuccess = await _userRepository.KiemTraDangNhapAsync(tenDangNhap, matKhau);
                if (isSuccess)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tạm ẩn chuyển hướng FormMain để tránh lỗi CS0246 nếu dự án chưa có FormMain
                    // Trường hợp Form chính của bạn tên là Form1, hãy bỏ comment và đổi FormMain -> Form1
                    /*
                    FormMain formMain = new FormMain();
                    this.Hide();
                    formMain.ShowDialog();
                    this.Close();
                    */
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}