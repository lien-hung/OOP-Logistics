namespace OOP_Logistics
{
    partial class Form_DangKyKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangKyKhachHang));
            ptbLogo = new PictureBox();
            lblTieuDe = new Label();
            lblLoaiKhachHang = new Label();
            cboLoaiKhachHang = new ComboBox();
            txtHoVaTen = new TextBox();
            lblHoVaTen = new Label();
            txtSoDienThoai = new TextBox();
            lblSoDienThoai = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtSoCCCD = new TextBox();
            lblSoCCCD = new Label();
            txtTenCongTy = new TextBox();
            lblTenCongTy = new Label();
            txtLinhVuc = new TextBox();
            lblLinhVuc = new Label();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            txtTenDangNhap = new TextBox();
            lblTenDangNhap = new Label();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            txtXacNhanMatKhau = new TextBox();
            lblXacNhanMatKhau = new Label();
            btnDangKy = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // ptbLogo
            // 
            ptbLogo.Image = Properties.Resources.X_Delivery;
            ptbLogo.Location = new Point(12, 12);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(166, 65);
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLogo.TabIndex = 7;
            ptbLogo.TabStop = false;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = Color.FromArgb(255, 128, 0);
            lblTieuDe.Location = new Point(184, 27);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(292, 32);
            lblTieuDe.TabIndex = 8;
            lblTieuDe.Text = "ĐĂNG KÝ KHÁCH HÀNG";
            // 
            // lblLoaiKhachHang
            // 
            lblLoaiKhachHang.AutoSize = true;
            lblLoaiKhachHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoaiKhachHang.Location = new Point(57, 90);
            lblLoaiKhachHang.Name = "lblLoaiKhachHang";
            lblLoaiKhachHang.Size = new Size(168, 21);
            lblLoaiKhachHang.TabIndex = 9;
            lblLoaiKhachHang.Text = "Chọn loại khách hàng:";
            // 
            // cboLoaiKhachHang
            // 
            cboLoaiKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiKhachHang.FormattingEnabled = true;
            cboLoaiKhachHang.Items.AddRange(new object[] { "Cá nhân", "Doanh nghiệp" });
            cboLoaiKhachHang.Location = new Point(231, 87);
            cboLoaiKhachHang.Name = "cboLoaiKhachHang";
            cboLoaiKhachHang.Size = new Size(197, 29);
            cboLoaiKhachHang.TabIndex = 10;
            cboLoaiKhachHang.SelectedIndexChanged += cboLoaiKhachHang_SelectedIndexChanged;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoVaTen.Location = new Point(33, 154);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(212, 29);
            txtHoVaTen.TabIndex = 12;
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.AutoSize = true;
            lblHoVaTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoVaTen.Location = new Point(33, 130);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(76, 21);
            lblHoVaTen.TabIndex = 11;
            lblHoVaTen.Text = "Họ và tên";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoDienThoai.Location = new Point(249, 154);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(212, 29);
            txtSoDienThoai.TabIndex = 14;
            txtSoDienThoai.KeyPress += txtSoDienThoai_KeyPress;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoDienThoai.Location = new Point(249, 130);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(101, 21);
            lblSoDienThoai.TabIndex = 13;
            lblSoDienThoai.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(249, 210);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(212, 29);
            txtEmail.TabIndex = 18;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(249, 186);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email";
            // 
            // txtSoCCCD
            // 
            txtSoCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoCCCD.Location = new Point(33, 210);
            txtSoCCCD.Name = "txtSoCCCD";
            txtSoCCCD.Size = new Size(212, 29);
            txtSoCCCD.TabIndex = 16;
            txtSoCCCD.KeyPress += txtSoCCCD_KeyPress;
            // 
            // lblSoCCCD
            // 
            lblSoCCCD.AutoSize = true;
            lblSoCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoCCCD.Location = new Point(33, 186);
            lblSoCCCD.Name = "lblSoCCCD";
            lblSoCCCD.Size = new Size(93, 21);
            lblSoCCCD.TabIndex = 15;
            lblSoCCCD.Text = "Số căn cước";
            // 
            // txtTenCongTy
            // 
            txtTenCongTy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenCongTy.Location = new Point(33, 266);
            txtTenCongTy.Name = "txtTenCongTy";
            txtTenCongTy.Size = new Size(212, 29);
            txtTenCongTy.TabIndex = 20;
            // 
            // lblTenCongTy
            // 
            lblTenCongTy.AutoSize = true;
            lblTenCongTy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenCongTy.Location = new Point(33, 242);
            lblTenCongTy.Name = "lblTenCongTy";
            lblTenCongTy.Size = new Size(88, 21);
            lblTenCongTy.TabIndex = 19;
            lblTenCongTy.Text = "Tên công ty";
            // 
            // txtLinhVuc
            // 
            txtLinhVuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLinhVuc.Location = new Point(249, 266);
            txtLinhVuc.Name = "txtLinhVuc";
            txtLinhVuc.Size = new Size(212, 29);
            txtLinhVuc.TabIndex = 22;
            // 
            // lblLinhVuc
            // 
            lblLinhVuc.AutoSize = true;
            lblLinhVuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinhVuc.Location = new Point(249, 242);
            lblLinhVuc.Name = "lblLinhVuc";
            lblLinhVuc.Size = new Size(68, 21);
            lblLinhVuc.TabIndex = 21;
            lblLinhVuc.Text = "Lĩnh vực";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.Location = new Point(33, 322);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(212, 29);
            txtDiaChi.TabIndex = 24;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(33, 298);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(57, 21);
            lblDiaChi.TabIndex = 23;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(249, 322);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(212, 29);
            txtTenDangNhap.TabIndex = 26;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(249, 298);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(111, 21);
            lblTenDangNhap.TabIndex = 25;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(33, 378);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(212, 29);
            txtMatKhau.TabIndex = 28;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(33, 354);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(75, 21);
            lblMatKhau.TabIndex = 27;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtXacNhanMatKhau.Location = new Point(249, 378);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '●';
            txtXacNhanMatKhau.Size = new Size(212, 29);
            txtXacNhanMatKhau.TabIndex = 30;
            // 
            // lblXacNhanMatKhau
            // 
            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblXacNhanMatKhau.Location = new Point(249, 354);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new Size(142, 21);
            lblXacNhanMatKhau.TabIndex = 29;
            lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(255, 128, 0);
            btnDangKy.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(249, 427);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(212, 40);
            btnDangKy.TabIndex = 31;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            btnDangKy.MouseEnter += btnDangKy_MouseEnter;
            btnDangKy.MouseLeave += btnDangKy_MouseLeave;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.FromArgb(255, 128, 0);
            btnHuy.Location = new Point(33, 427);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(212, 40);
            btnHuy.TabIndex = 32;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            btnHuy.MouseEnter += btnHuy_MouseEnter;
            btnHuy.MouseLeave += btnHuy_MouseLeave;
            // 
            // Form_DangKyKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(496, 493);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(lblXacNhanMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblTenDangNhap);
            Controls.Add(txtDiaChi);
            Controls.Add(lblDiaChi);
            Controls.Add(txtLinhVuc);
            Controls.Add(lblLinhVuc);
            Controls.Add(txtTenCongTy);
            Controls.Add(lblTenCongTy);
            Controls.Add(txtSoCCCD);
            Controls.Add(lblSoCCCD);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtSoDienThoai);
            Controls.Add(lblSoDienThoai);
            Controls.Add(txtHoVaTen);
            Controls.Add(lblHoVaTen);
            Controls.Add(cboLoaiKhachHang);
            Controls.Add(lblLoaiKhachHang);
            Controls.Add(lblTieuDe);
            Controls.Add(ptbLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_DangKyKhachHang";
            Text = "Đăng ký khách hàng";
            Load += Form_DangKyKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbLogo;
        private Label lblTieuDe;
        private Label lblLoaiKhachHang;
        private ComboBox cboLoaiKhachHang;
        private TextBox txtHoVaTen;
        private Label lblHoVaTen;
        private TextBox txtSoDienThoai;
        private Label lblSoDienThoai;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtSoCCCD;
        private Label lblSoCCCD;
        private TextBox txtTenCongTy;
        private Label lblTenCongTy;
        private TextBox txtLinhVuc;
        private Label lblLinhVuc;
        private TextBox txtDiaChi;
        private Label lblDiaChi;
        private TextBox txtTenDangNhap;
        private Label lblTenDangNhap;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private TextBox txtXacNhanMatKhau;
        private Label lblXacNhanMatKhau;
        private Button btnDangKy;
        private Button btnHuy;
    }
}