using QuanLyNguoiDung.Data;

namespace QuanLyNguoiDung
{
    public partial class FrmChinh : Form
    {
        // Constructor khong tham so de Designer mo duoc form.
        public FrmChinh()
        {
            InitializeComponent();
        }

        public FrmChinh(NguoiDung nguoiDung) : this()
        {
            lblXinChao.Text = $"Xin chào, {nguoiDung.HoTen}";
            lblTenDangNhap.Text = $"Tên đăng nhập: {nguoiDung.TenDangNhap}";

            lblEmail.Text = "Email: " +
                (string.IsNullOrWhiteSpace(nguoiDung.Email)
                    ? "(chưa cập nhật)"
                    : nguoiDung.Email);

            lblNgayTao.Text = "Ngày tạo: " +
                (nguoiDung.NgayTao?.ToString("dd/MM/yyyy HH:mm")
                    ?? "(không có thông tin)");

            lblLanDangNhapCuoi.Text = "Lần đăng nhập gần nhất: " +
                (nguoiDung.LanDangNhapCuoi?.ToString("dd/MM/yyyy HH:mm")
                    ?? "Đây là lần đăng nhập đầu tiên");
        }

        private void btnDangXuat_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}