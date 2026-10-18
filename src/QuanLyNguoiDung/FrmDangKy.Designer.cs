#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    partial class FrmDangKy
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblLoiTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblLoiMatKhau = new System.Windows.Forms.Label();
            this.lblXacNhanMatKhau = new System.Windows.Forms.Label();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.lblLoiXacNhanMatKhau = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblLoiHoTen = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLoiEmail = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlTieuDe
            //
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(27, 111, 108);
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(400, 44);
            this.pnlTieuDe.TabIndex = 7;
            //
            // lblTieuDe
            //
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(16, 11);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(140, 20);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Đăng ký tài khoản";
            //
            // lblTenDangNhap
            //
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(24, 56);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(100, 17);
            this.lblTenDangNhap.TabIndex = 10;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            //
            // txtTenDangNhap
            //
            this.txtTenDangNhap.Location = new System.Drawing.Point(24, 76);
            this.txtTenDangNhap.MaxLength = 20;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PlaceholderText = "3-20 ký tự, không dấu, không trùng";
            this.txtTenDangNhap.Size = new System.Drawing.Size(352, 25);
            this.txtTenDangNhap.TabIndex = 0;
            //
            // lblLoiTenDangNhap  (luon hien dien, Text rong o trang thai binh thuong)
            //
            this.lblLoiTenDangNhap.AutoSize = false;
            this.lblLoiTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblLoiTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblLoiTenDangNhap.Location = new System.Drawing.Point(24, 104);
            this.lblLoiTenDangNhap.Name = "lblLoiTenDangNhap";
            this.lblLoiTenDangNhap.Size = new System.Drawing.Size(352, 20);
            this.lblLoiTenDangNhap.TabIndex = 11;
            this.lblLoiTenDangNhap.Text = "";
            this.lblLoiTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblMatKhau
            //
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(24, 132);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(100, 17);
            this.lblMatKhau.TabIndex = 12;
            this.lblMatKhau.Text = "Mật khẩu";
            //
            // txtMatKhau
            //
            this.txtMatKhau.Location = new System.Drawing.Point(24, 152);
            this.txtMatKhau.MaxLength = 64;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PlaceholderText = "tối thiểu 8 ký tự, có chữ và số";
            this.txtMatKhau.Size = new System.Drawing.Size(352, 25);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            //
            // lblLoiMatKhau  (luon hien dien, Text rong o trang thai binh thuong)
            //
            this.lblLoiMatKhau.AutoSize = false;
            this.lblLoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblLoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblLoiMatKhau.Location = new System.Drawing.Point(24, 180);
            this.lblLoiMatKhau.Name = "lblLoiMatKhau";
            this.lblLoiMatKhau.Size = new System.Drawing.Size(352, 20);
            this.lblLoiMatKhau.TabIndex = 13;
            this.lblLoiMatKhau.Text = "";
            this.lblLoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblXacNhanMatKhau
            //
            this.lblXacNhanMatKhau.AutoSize = true;
            this.lblXacNhanMatKhau.Location = new System.Drawing.Point(24, 208);
            this.lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            this.lblXacNhanMatKhau.Size = new System.Drawing.Size(100, 17);
            this.lblXacNhanMatKhau.TabIndex = 14;
            this.lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            //
            // txtXacNhanMatKhau
            //
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(24, 228);
            this.txtXacNhanMatKhau.MaxLength = 64;
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PlaceholderText = "nhập lại mật khẩu";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(352, 25);
            this.txtXacNhanMatKhau.TabIndex = 2;
            this.txtXacNhanMatKhau.UseSystemPasswordChar = true;
            //
            // lblLoiXacNhanMatKhau  (luon hien dien, Text rong o trang thai binh thuong)
            //
            this.lblLoiXacNhanMatKhau.AutoSize = false;
            this.lblLoiXacNhanMatKhau.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblLoiXacNhanMatKhau.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblLoiXacNhanMatKhau.Location = new System.Drawing.Point(24, 256);
            this.lblLoiXacNhanMatKhau.Name = "lblLoiXacNhanMatKhau";
            this.lblLoiXacNhanMatKhau.Size = new System.Drawing.Size(352, 20);
            this.lblLoiXacNhanMatKhau.TabIndex = 15;
            this.lblLoiXacNhanMatKhau.Text = "";
            this.lblLoiXacNhanMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblHoTen
            //
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(24, 284);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(100, 17);
            this.lblHoTen.TabIndex = 16;
            this.lblHoTen.Text = "Họ và tên";
            //
            // txtHoTen
            //
            this.txtHoTen.Location = new System.Drawing.Point(24, 304);
            this.txtHoTen.MaxLength = 50;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PlaceholderText = "Nguyễn Văn A";
            this.txtHoTen.Size = new System.Drawing.Size(352, 25);
            this.txtHoTen.TabIndex = 3;
            //
            // lblLoiHoTen  (luon hien dien, Text rong o trang thai binh thuong)
            //
            this.lblLoiHoTen.AutoSize = false;
            this.lblLoiHoTen.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblLoiHoTen.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblLoiHoTen.Location = new System.Drawing.Point(24, 332);
            this.lblLoiHoTen.Name = "lblLoiHoTen";
            this.lblLoiHoTen.Size = new System.Drawing.Size(352, 20);
            this.lblLoiHoTen.TabIndex = 17;
            this.lblLoiHoTen.Text = "";
            this.lblLoiHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblEmail
            //
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 360);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 17);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email (không bắt buộc)";
            //
            // txtEmail
            //
            this.txtEmail.Location = new System.Drawing.Point(24, 380);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "ten@mien.com";
            this.txtEmail.Size = new System.Drawing.Size(352, 25);
            this.txtEmail.TabIndex = 4;
            //
            // lblLoiEmail  (luon hien dien, Text rong o trang thai binh thuong)
            //
            this.lblLoiEmail.AutoSize = false;
            this.lblLoiEmail.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblLoiEmail.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblLoiEmail.Location = new System.Drawing.Point(24, 408);
            this.lblLoiEmail.Name = "lblLoiEmail";
            this.lblLoiEmail.Size = new System.Drawing.Size(352, 20);
            this.lblLoiEmail.TabIndex = 19;
            this.lblLoiEmail.Text = "";
            this.lblLoiEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnDangKy
            //
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(27, 111, 108);
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(35, 130, 124);
            this.btnDangKy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(20, 88, 86);
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(186, 444);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(98, 34);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            //
            // btnHuy
            //
            this.btnHuy.Location = new System.Drawing.Point(290, 444);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 34);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnHuy.FlatAppearance.BorderSize = 1;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(210, 230, 228);
            this.btnHuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(190, 220, 216);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            //
            // FrmDangKy
            //
            this.AcceptButton = this.btnDangKy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(400, 496);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.lblLoiTenDangNhap);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblLoiMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblLoiXacNhanMatKhau);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.lblXacNhanMatKhau);
            this.Controls.Add(this.lblLoiHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblLoiEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pnlTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 245);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản — Hệ thống tra cứu triệu chứng";
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblLoiTenDangNhap;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblLoiMatKhau;
        private Label lblXacNhanMatKhau;
        private TextBox txtXacNhanMatKhau;
        private Label lblLoiXacNhanMatKhau;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblLoiHoTen;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblLoiEmail;
        private Button btnDangKy;
        private Button btnHuy;
    }
}
