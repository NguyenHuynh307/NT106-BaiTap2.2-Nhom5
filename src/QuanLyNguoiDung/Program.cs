using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new Form
            {
                Text = "NT106 - Bai tap 2.2 - Nhom 5",
                StartPosition = FormStartPosition.CenterScreen,
                Width = 900,
                Height = 560,
                MinimumSize = new Size(640, 400)
            };

            Application.Run(form);
        }
    }
}