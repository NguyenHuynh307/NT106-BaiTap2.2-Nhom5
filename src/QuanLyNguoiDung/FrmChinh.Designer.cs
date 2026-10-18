#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNguoiDung
{
    partial class FrmChinh
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
            this.lblXinChao = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblLanDangNhapCuoi = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblCanhBao = new System.Windows.Forms.Label();
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
            this.pnlTieuDe.Size = new System.Drawing.Size(480, 44);
            this.pnlTieuDe.TabIndex = 6;
            //
            // lblTieuDe
            //
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(16, 11);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(90, 20);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Trang chính";
            //
            // lblXinChao
            //
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblXinChao.ForeColor = System.Drawing.Color.FromArgb(27, 111, 108);
            this.lblXinChao.Location = new System.Drawing.Point(24, 62);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(80, 21);
            this.lblXinChao.TabIndex = 1;
            this.lblXinChao.Text = "Xin chào,";
            //
            // lblTenDangNhap
            //
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(24, 108);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(100, 17);
            this.lblTenDangNhap.TabIndex = 2;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            //
            // lblEmail
            //
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 136);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            //
            // lblNgayTao
            //
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Location = new System.Drawing.Point(24, 164);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(70, 17);
            this.lblNgayTao.TabIndex = 4;
            this.lblNgayTao.Text = "Ngày tạo:";
            //
            // lblLanDangNhapCuoi
            //
            this.lblLanDangNhapCuoi.AutoSize = true;
            this.lblLanDangNhapCuoi.Location = new System.Drawing.Point(24, 192);
            this.lblLanDangNhapCuoi.Name = "lblLanDangNhapCuoi";
            this.lblLanDangNhapCuoi.Size = new System.Drawing.Size(150, 17);
            this.lblLanDangNhapCuoi.TabIndex = 5;
            this.lblLanDangNhapCuoi.Text = "Lần đăng nhập gần nhất:";
            //
            // btnDangXuat
            //
            this.btnDangXuat.Location = new System.Drawing.Point(366, 224);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(90, 34);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(27, 111, 108);
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(35, 130, 124);
            this.btnDangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(20, 88, 86);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            //
            // lblCanhBao  (dong canh bao co dinh theo de tai)
            //
            this.lblCanhBao.AutoSize = false;
            this.lblCanhBao.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.lblCanhBao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCanhBao.ForeColor = System.Drawing.Color.FromArgb(120, 80, 0);
            this.lblCanhBao.Location = new System.Drawing.Point(0, 284);
            this.lblCanhBao.Name = "lblCanhBao";
            this.lblCanhBao.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.lblCanhBao.Size = new System.Drawing.Size(480, 56);
            this.lblCanhBao.TabIndex = 7;
            this.lblCanhBao.Text = "Thông tin chỉ mang tính tham khảo, không thể thay thế chẩn đoán của bác sĩ, nếu vấn đề của bạn quan trọng hãy đến các bệnh viện gần nhất";
            this.lblCanhBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // FrmChinh
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 340);
            this.Controls.Add(this.lblCanhBao);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.lblLanDangNhapCuoi);
            this.Controls.Add(this.lblNgayTao);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblXinChao);
            this.Controls.Add(this.pnlTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 245);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chính — Hệ thống tra cứu triệu chứng";
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Panel pnlTieuDe;
        private Label lblTieuDe;
        private Label lblXinChao;
        private Label lblTenDangNhap;
        private Label lblEmail;
        private Label lblNgayTao;
        private Label lblLanDangNhapCuoi;
        private Button btnDangXuat;
        private Label lblCanhBao;
    }
}
