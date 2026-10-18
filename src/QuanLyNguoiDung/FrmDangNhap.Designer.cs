#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    partial class FrmDangNhap
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
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblLoi = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lnkDangKy = new System.Windows.Forms.LinkLabel();
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
            this.pnlTieuDe.TabIndex = 5;
            //
            // lblTieuDe
            //
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(16, 11);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(100, 20);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Đăng nhập";
            //
            // lblTenDangNhap
            //
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(24, 64);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(90, 17);
            this.lblTenDangNhap.TabIndex = 6;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            //
            // txtTenDangNhap
            //
            this.txtTenDangNhap.Location = new System.Drawing.Point(24, 86);
            this.txtTenDangNhap.MaxLength = 20;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(352, 25);
            this.txtTenDangNhap.TabIndex = 0;
            //
            // lblMatKhau
            //
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(24, 124);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(60, 17);
            this.lblMatKhau.TabIndex = 7;
            this.lblMatKhau.Text = "Mật khẩu";
            //
            // txtMatKhau
            //
            this.txtMatKhau.Location = new System.Drawing.Point(24, 146);
            this.txtMatKhau.MaxLength = 64;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(352, 25);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            //
            // lblLoi  (luon hien dien tren form, Text rong o trang thai binh thuong)
            //
            this.lblLoi.AutoSize = false;
            this.lblLoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoi.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblLoi.Location = new System.Drawing.Point(24, 178);
            this.lblLoi.Name = "lblLoi";
            this.lblLoi.Size = new System.Drawing.Size(352, 22);
            this.lblLoi.TabIndex = 8;
            this.lblLoi.Text = "";
            this.lblLoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnDangNhap
            //
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(27, 111, 108);
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(35, 130, 124);
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(20, 88, 86);
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(186, 212);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(98, 34);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            //
            // btnThoat
            //
            this.btnThoat.Location = new System.Drawing.Point(290, 212);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 34);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnThoat.FlatAppearance.BorderSize = 1;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(210, 230, 228);
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(190, 220, 216);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            //
            // lnkDangKy
            //
            this.lnkDangKy.AutoSize = false;
            this.lnkDangKy.LinkArea = new System.Windows.Forms.LinkArea(19, 7);
            this.lnkDangKy.Location = new System.Drawing.Point(24, 262);
            this.lnkDangKy.Name = "lnkDangKy";
            this.lnkDangKy.Size = new System.Drawing.Size(352, 22);
            this.lnkDangKy.TabIndex = 4;
            this.lnkDangKy.TabStop = true;
            this.lnkDangKy.Text = "Chưa có tài khoản? Đăng ký";
            this.lnkDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDangKy_LinkClicked);
            //
            // FrmDangNhap
            //
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(400, 304);
            this.Controls.Add(this.lnkDangKy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lblLoi);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.pnlTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 245);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập — Hệ thống tra cứu triệu chứng";
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblLoi;
        private Button btnDangNhap;
        private Button btnThoat;
        private LinkLabel lnkDangKy;
    }
}
