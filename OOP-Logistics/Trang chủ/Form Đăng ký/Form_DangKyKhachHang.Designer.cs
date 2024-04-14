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
            ptbLogo.Location = new Point(14, 16);
            ptbLogo.Margin = new Padding(3, 4, 3, 4);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(190, 87);
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLogo.TabIndex = 7;
            ptbLogo.TabStop = false;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = Color.FromArgb(255, 128, 0);
            lblTieuDe.Location = new Point(210, 36);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(361, 41);
            lblTieuDe.TabIndex = 8;
            lblTieuDe.Text = "ĐĂNG KÝ KHÁCH HÀNG";
            // 
            // lblLoaiKhachHang
            // 
            lblLoaiKhachHang.AutoSize = true;
            lblLoaiKhachHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoaiKhachHang.Location = new Point(65, 120);
            lblLoaiKhachHang.Name = "lblLoaiKhachHang";
            lblLoaiKhachHang.Size = new Size(215, 28);
            lblLoaiKhachHang.TabIndex = 9;
            lblLoaiKhachHang.Text = "Chọn loại khách hàng:";
            // 
            // cboLoaiKhachHang
            // 
            cboLoaiKhachHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiKhachHang.FormattingEnabled = true;
            cboLoaiKhachHang.Items.AddRange(new object[] { "Cá nhân", "Doanh nghiệp" });
            cboLoaiKhachHang.Location = new Point(285, 117);
            cboLoaiKhachHang.Margin = new Padding(3, 4, 3, 4);
            cboLoaiKhachHang.Name = "cboLoaiKhachHang";
            cboLoaiKhachHang.Size = new Size(225, 36);
            cboLoaiKhachHang.TabIndex = 10;
            cboLoaiKhachHang.SelectedIndexChanged += cboLoaiKhachHang_SelectedIndexChanged;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoVaTen.Location = new Point(38, 205);
            txtHoVaTen.Margin = new Padding(3, 4, 3, 4);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(242, 34);
            txtHoVaTen.TabIndex = 12;
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.AutoSize = true;
            lblHoVaTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoVaTen.Location = new Point(38, 173);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(96, 28);
            lblHoVaTen.TabIndex = 11;
            lblHoVaTen.Text = "Họ và tên";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoDienThoai.Location = new Point(285, 205);
            txtSoDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(242, 34);
            txtSoDienThoai.TabIndex = 14;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoDienThoai.Location = new Point(285, 173);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(128, 28);
            lblSoDienThoai.TabIndex = 13;
            lblSoDienThoai.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(285, 280);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(242, 34);
            txtEmail.TabIndex = 18;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(285, 248);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email";
            // 
            // txtSoCCCD
            // 
            txtSoCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoCCCD.Location = new Point(38, 280);
            txtSoCCCD.Margin = new Padding(3, 4, 3, 4);
            txtSoCCCD.Name = "txtSoCCCD";
            txtSoCCCD.Size = new Size(242, 34);
            txtSoCCCD.TabIndex = 16;
            // 
            // lblSoCCCD
            // 
            lblSoCCCD.AutoSize = true;
            lblSoCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoCCCD.Location = new Point(38, 248);
            lblSoCCCD.Name = "lblSoCCCD";
            lblSoCCCD.Size = new Size(117, 28);
            lblSoCCCD.TabIndex = 15;
            lblSoCCCD.Text = "Số căn cước";
            // 
            // txtTenCongTy
            // 
            txtTenCongTy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenCongTy.Location = new Point(38, 355);
            txtTenCongTy.Margin = new Padding(3, 4, 3, 4);
            txtTenCongTy.Name = "txtTenCongTy";
            txtTenCongTy.Size = new Size(242, 34);
            txtTenCongTy.TabIndex = 20;
            // 
            // lblTenCongTy
            // 
            lblTenCongTy.AutoSize = true;
            lblTenCongTy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenCongTy.Location = new Point(38, 323);
            lblTenCongTy.Name = "lblTenCongTy";
            lblTenCongTy.Size = new Size(112, 28);
            lblTenCongTy.TabIndex = 19;
            lblTenCongTy.Text = "Tên công ty";
            // 
            // txtLinhVuc
            // 
            txtLinhVuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLinhVuc.Location = new Point(285, 355);
            txtLinhVuc.Margin = new Padding(3, 4, 3, 4);
            txtLinhVuc.Name = "txtLinhVuc";
            txtLinhVuc.Size = new Size(242, 34);
            txtLinhVuc.TabIndex = 22;
            // 
            // lblLinhVuc
            // 
            lblLinhVuc.AutoSize = true;
            lblLinhVuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinhVuc.Location = new Point(285, 323);
            lblLinhVuc.Name = "lblLinhVuc";
            lblLinhVuc.Size = new Size(84, 28);
            lblLinhVuc.TabIndex = 21;
            lblLinhVuc.Text = "Lĩnh vực";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiaChi.Location = new Point(38, 429);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(242, 34);
            txtDiaChi.TabIndex = 24;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaChi.Location = new Point(38, 397);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(71, 28);
            lblDiaChi.TabIndex = 23;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(285, 429);
            txtTenDangNhap.Margin = new Padding(3, 4, 3, 4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(242, 34);
            txtTenDangNhap.TabIndex = 26;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(285, 397);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(140, 28);
            lblTenDangNhap.TabIndex = 25;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(38, 504);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(242, 34);
            txtMatKhau.TabIndex = 28;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(38, 472);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(94, 28);
            lblMatKhau.TabIndex = 27;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtXacNhanMatKhau.Location = new Point(285, 504);
            txtXacNhanMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '●';
            txtXacNhanMatKhau.Size = new Size(242, 34);
            txtXacNhanMatKhau.TabIndex = 30;
            // 
            // lblXacNhanMatKhau
            // 
            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblXacNhanMatKhau.Location = new Point(285, 472);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new Size(177, 28);
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
            btnDangKy.Location = new Point(285, 569);
            btnDangKy.Margin = new Padding(3, 4, 3, 4);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(242, 53);
            btnDangKy.TabIndex = 31;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.MouseEnter += btnDangKy_MouseEnter;
            btnDangKy.MouseLeave += btnDangKy_MouseLeave;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.FromArgb(255, 128, 0);
            btnHuy.Location = new Point(38, 569);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(242, 53);
            btnHuy.TabIndex = 32;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            btnHuy.MouseEnter += btnHuy_MouseEnter;
            btnHuy.MouseLeave += btnHuy_MouseLeave;
            // 
            // Form_DangKyKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(567, 657);
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
            Margin = new Padding(3, 4, 3, 4);
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