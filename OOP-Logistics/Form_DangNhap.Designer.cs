namespace OOP_Logistics
{
    partial class Form_DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangNhap));
            ptbLogo = new PictureBox();
            lblTieuDe = new Label();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            btnDangNhap = new Button();
            btnDangKy = new Button();
            lblQuenMatKhau = new Label();
            lblVeTrangChu = new Label();
            lblLoaiTaiKhoan = new Label();
            cboLoaiTaiKhoan = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // ptbLogo
            // 
            ptbLogo.Image = Properties.Resources.X_Delivery;
            ptbLogo.Location = new Point(83, 12);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(189, 72);
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLogo.TabIndex = 6;
            ptbLogo.TabStop = false;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = Color.FromArgb(255, 128, 0);
            lblTieuDe.Location = new Point(97, 101);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(161, 32);
            lblTieuDe.TabIndex = 7;
            lblTieuDe.Text = "ĐĂNG NHẬP";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(29, 181);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(116, 21);
            lblTenDangNhap.TabIndex = 10;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(29, 205);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(301, 29);
            txtTenDangNhap.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(29, 265);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(301, 29);
            txtMatKhau.TabIndex = 14;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(29, 241);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(77, 21);
            lblMatKhau.TabIndex = 12;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(255, 128, 0);
            btnDangNhap.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(29, 308);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(301, 40);
            btnDangNhap.TabIndex = 15;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.MouseEnter += btnDangNhap_MouseEnter;
            btnDangNhap.MouseLeave += btnDangNhap_MouseLeave;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.White;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.FromArgb(255, 128, 0);
            btnDangKy.Location = new Point(29, 354);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(301, 40);
            btnDangKy.TabIndex = 16;
            btnDangKy.Text = "Chưa có tài khoản? Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            btnDangKy.MouseEnter += btnDangKy_MouseEnter;
            btnDangKy.MouseLeave += btnDangKy_MouseLeave;
            // 
            // lblQuenMatKhau
            // 
            lblQuenMatKhau.AutoSize = true;
            lblQuenMatKhau.ForeColor = Color.Blue;
            lblQuenMatKhau.Location = new Point(236, 246);
            lblQuenMatKhau.Name = "lblQuenMatKhau";
            lblQuenMatKhau.Size = new Size(94, 15);
            lblQuenMatKhau.TabIndex = 13;
            lblQuenMatKhau.Text = "Quên mật khẩu?";
            // 
            // lblVeTrangChu
            // 
            lblVeTrangChu.AutoSize = true;
            lblVeTrangChu.ForeColor = Color.Blue;
            lblVeTrangChu.Location = new Point(107, 404);
            lblVeTrangChu.Name = "lblVeTrangChu";
            lblVeTrangChu.Size = new Size(145, 15);
            lblVeTrangChu.TabIndex = 17;
            lblVeTrangChu.Text = "Quay lại trang chào mừng";
            lblVeTrangChu.Click += lblVeTrangChu_Click;
            // 
            // lblLoaiTaiKhoan
            // 
            lblLoaiTaiKhoan.AutoSize = true;
            lblLoaiTaiKhoan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoaiTaiKhoan.Location = new Point(69, 147);
            lblLoaiTaiKhoan.Name = "lblLoaiTaiKhoan";
            lblLoaiTaiKhoan.Size = new Size(57, 21);
            lblLoaiTaiKhoan.TabIndex = 8;
            lblLoaiTaiKhoan.Text = "Bạn là:";
            // 
            // cboLoaiTaiKhoan
            // 
            cboLoaiTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiTaiKhoan.FormattingEnabled = true;
            cboLoaiTaiKhoan.Items.AddRange(new object[] { "Khách hàng", "Nhân viên", "Quản trị viên" });
            cboLoaiTaiKhoan.Location = new Point(132, 144);
            cboLoaiTaiKhoan.Name = "cboLoaiTaiKhoan";
            cboLoaiTaiKhoan.Size = new Size(150, 29);
            cboLoaiTaiKhoan.TabIndex = 9;
            // 
            // Form_DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(360, 433);
            Controls.Add(cboLoaiTaiKhoan);
            Controls.Add(lblLoaiTaiKhoan);
            Controls.Add(lblVeTrangChu);
            Controls.Add(lblQuenMatKhau);
            Controls.Add(btnDangKy);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblTieuDe);
            Controls.Add(ptbLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_DangNhap";
            Text = "Đăng nhập";
            Load += Form_DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbLogo;
        private Label lblTieuDe;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private Button btnDangNhap;
        private Button btnDangKy;
        private Label lblQuenMatKhau;
        private Label lblVeTrangChu;
        private Label lblLoaiTaiKhoan;
        private ComboBox cboLoaiTaiKhoan;
    }
}