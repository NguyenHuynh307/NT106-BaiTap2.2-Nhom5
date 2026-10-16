using System;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKi frmRegister = new FormDangKi();
            this.Hide();
            frmRegister.ShowDialog();
            this.Show();
        }
    }
}
