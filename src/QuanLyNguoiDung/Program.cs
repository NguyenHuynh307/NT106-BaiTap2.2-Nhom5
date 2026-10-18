namespace QuanLyNguoiDung
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.SetUnhandledExceptionMode(
                UnhandledExceptionMode.CatchException);

            Application.ThreadException += (sender, args) =>
                HienLoiChung();

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
                HienLoiChung();

            Application.Run(new FrmDangNhap());
        }

        private static void HienLoiChung()
        {
            MessageBox.Show(
                "Đã xảy ra lỗi không mong muốn. Vui lòng thử lại.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}