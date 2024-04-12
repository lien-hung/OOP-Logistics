namespace OOP_Logistics
{
    partial class Form_DangKyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangKyNhanVien));
            btnHuy = new Button();
            btnDangKy = new Button();
            txtXacNhanMatKhau = new TextBox();
            lblXacNhanMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            txtTenDangNhap = new TextBox();
            lblTenDangNhap = new Label();
            txtBienSo = new TextBox();
            lblBienSo = new Label();
            lblLinhVuc = new Label();
            lblNoiLamViec = new Label();
            txtSoCCCD = new TextBox();
            lblSoCCCD = new Label();
            txtSoDienThoai = new TextBox();
            lblSoDienThoai = new Label();
            txtHoVaTen = new TextBox();
            lblHoVaTen = new Label();
            cboLoaiNhanVien = new ComboBox();
            lblLoaiKhachHang = new Label();
            lblTieuDe = new Label();
            ptbLogo = new PictureBox();
            cboNoiLamViec = new ComboBox();
            cboLoaiXe = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.FromArgb(255, 128, 0);
            btnHuy.Location = new Point(33, 396);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(212, 40);
            btnHuy.TabIndex = 58;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            btnHuy.MouseEnter += btnHuy_MouseEnter;
            btnHuy.MouseLeave += btnHuy_MouseLeave;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(255, 128, 0);
            btnDangKy.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(249, 396);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(212, 40);
            btnDangKy.TabIndex = 57;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.MouseEnter += btnDangKy_MouseEnter;
            btnDangKy.MouseLeave += btnDangKy_MouseLeave;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtXacNhanMatKhau.Location = new Point(249, 347);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '●';
            txtXacNhanMatKhau.Size = new Size(212, 29);
            txtXacNhanMatKhau.TabIndex = 56;
            // 
            // lblXacNhanMatKhau
            // 
            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblXacNhanMatKhau.Location = new Point(249, 323);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new Size(142, 21);
            lblXacNhanMatKhau.TabIndex = 55;
            lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(33, 347);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(212, 29);
            txtMatKhau.TabIndex = 54;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(33, 323);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(75, 21);
            lblMatKhau.TabIndex = 53;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(249, 291);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(212, 29);
            txtTenDangNhap.TabIndex = 52;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(249, 267);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(111, 21);
            lblTenDangNhap.TabIndex = 51;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtBienSo
            // 
            txtBienSo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBienSo.Location = new Point(33, 291);
            txtBienSo.Name = "txtBienSo";
            txtBienSo.Size = new Size(212, 29);
            txtBienSo.TabIndex = 50;
            // 
            // lblBienSo
            // 
            lblBienSo.AutoSize = true;
            lblBienSo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienSo.Location = new Point(33, 267);
            lblBienSo.Name = "lblBienSo";
            lblBienSo.Size = new Size(60, 21);
            lblBienSo.TabIndex = 49;
            lblBienSo.Text = "Biển số";
            // 
            // lblLinhVuc
            // 
            lblLinhVuc.AutoSize = true;
            lblLinhVuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLinhVuc.Location = new Point(249, 211);
            lblLinhVuc.Name = "lblLinhVuc";
            lblLinhVuc.Size = new Size(128, 21);
            lblLinhVuc.TabIndex = 47;
            lblLinhVuc.Text = "Loại phương tiện";
            // 
            // lblNoiLamViec
            // 
            lblNoiLamViec.AutoSize = true;
            lblNoiLamViec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoiLamViec.Location = new Point(33, 211);
            lblNoiLamViec.Name = "lblNoiLamViec";
            lblNoiLamViec.Size = new Size(97, 21);
            lblNoiLamViec.TabIndex = 45;
            lblNoiLamViec.Text = "Nơi làm việc";
            // 
            // txtSoCCCD
            // 
            txtSoCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoCCCD.Location = new Point(249, 179);
            txtSoCCCD.Name = "txtSoCCCD";
            txtSoCCCD.Size = new Size(212, 29);
            txtSoCCCD.TabIndex = 42;
            // 
            // lblSoCCCD
            // 
            lblSoCCCD.AutoSize = true;
            lblSoCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoCCCD.Location = new Point(249, 155);
            lblSoCCCD.Name = "lblSoCCCD";
            lblSoCCCD.Size = new Size(93, 21);
            lblSoCCCD.TabIndex = 41;
            lblSoCCCD.Text = "Số căn cước";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoDienThoai.Location = new Point(33, 179);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(212, 29);
            txtSoDienThoai.TabIndex = 40;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoDienThoai.Location = new Point(33, 155);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(101, 21);
            lblSoDienThoai.TabIndex = 39;
            lblSoDienThoai.Text = "Số điện thoại";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoVaTen.Location = new Point(249, 123);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(212, 29);
            txtHoVaTen.TabIndex = 38;
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.AutoSize = true;
            lblHoVaTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoVaTen.Location = new Point(249, 99);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(76, 21);
            lblHoVaTen.TabIndex = 37;
            lblHoVaTen.Text = "Họ và tên";
            // 
            // cboLoaiNhanVien
            // 
            cboLoaiNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiNhanVien.FormattingEnabled = true;
            cboLoaiNhanVien.Items.AddRange(new object[] { "Nhân viên trung chuyển", "Tài xế cơ hữu" });
            cboLoaiNhanVien.Location = new Point(33, 123);
            cboLoaiNhanVien.Name = "cboLoaiNhanVien";
            cboLoaiNhanVien.Size = new Size(212, 29);
            cboLoaiNhanVien.TabIndex = 36;
            cboLoaiNhanVien.SelectedIndexChanged += cboLoaiNhanVien_SelectedIndexChanged;
            // 
            // lblLoaiKhachHang
            // 
            lblLoaiKhachHang.AutoSize = true;
            lblLoaiKhachHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoaiKhachHang.Location = new Point(33, 99);
            lblLoaiKhachHang.Name = "lblLoaiKhachHang";
            lblLoaiKhachHang.Size = new Size(155, 21);
            lblLoaiKhachHang.TabIndex = 35;
            lblLoaiKhachHang.Text = "Chọn loại nhân viên:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = Color.FromArgb(255, 128, 0);
            lblTieuDe.Location = new Point(207, 30);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(266, 32);
            lblTieuDe.TabIndex = 34;
            lblTieuDe.Text = "ĐĂNG KÝ NHÂN VIÊN";
            // 
            // ptbLogo
            // 
            ptbLogo.Image = Properties.Resources.X_Delivery;
            ptbLogo.Location = new Point(16, 15);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(166, 65);
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLogo.TabIndex = 33;
            ptbLogo.TabStop = false;
            // 
            // cboNoiLamViec
            // 
            cboNoiLamViec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboNoiLamViec.FormattingEnabled = true;
            cboNoiLamViec.Items.AddRange(new object[] { "Kho 1 (59C Nguyễn Đình Chiểu, Q3)", "Kho 2 (279 Nguyễn Tri Phương, Q10)", "Kho 3 (Đại lộ Nguyễn Văn Linh, HBC)" });
            cboNoiLamViec.Location = new Point(33, 235);
            cboNoiLamViec.Name = "cboNoiLamViec";
            cboNoiLamViec.Size = new Size(212, 29);
            cboNoiLamViec.TabIndex = 46;
            // 
            // cboLoaiXe
            // 
            cboLoaiXe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiXe.FormattingEnabled = true;
            cboLoaiXe.Items.AddRange(new object[] { "Xe tải", "Xe bán tải", "Xe máy" });
            cboLoaiXe.Location = new Point(249, 235);
            cboLoaiXe.Name = "cboLoaiXe";
            cboLoaiXe.Size = new Size(212, 29);
            cboLoaiXe.TabIndex = 48;
            // 
            // Form_DangKyNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(496, 462);
            Controls.Add(cboLoaiXe);
            Controls.Add(cboNoiLamViec);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(lblXacNhanMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblTenDangNhap);
            Controls.Add(txtBienSo);
            Controls.Add(lblBienSo);
            Controls.Add(lblLinhVuc);
            Controls.Add(lblNoiLamViec);
            Controls.Add(txtSoCCCD);
            Controls.Add(lblSoCCCD);
            Controls.Add(txtSoDienThoai);
            Controls.Add(lblSoDienThoai);
            Controls.Add(txtHoVaTen);
            Controls.Add(lblHoVaTen);
            Controls.Add(cboLoaiNhanVien);
            Controls.Add(lblLoaiKhachHang);
            Controls.Add(lblTieuDe);
            Controls.Add(ptbLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_DangKyNhanVien";
            Text = "Đăng ký nhân viên";
            Load += Form_DangKyNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuy;
        private Button btnDangKy;
        private TextBox txtXacNhanMatKhau;
        private Label lblXacNhanMatKhau;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private TextBox txtTenDangNhap;
        private Label lblTenDangNhap;
        private TextBox txtBienSo;
        private Label lblBienSo;
        private Label lblLinhVuc;
        private Label lblNoiLamViec;
        private TextBox txtSoCCCD;
        private Label lblSoCCCD;
        private TextBox txtSoDienThoai;
        private Label lblSoDienThoai;
        private TextBox txtHoVaTen;
        private Label lblHoVaTen;
        private ComboBox cboLoaiNhanVien;
        private Label lblLoaiKhachHang;
        private Label lblTieuDe;
        private PictureBox ptbLogo;
        private ComboBox cboNoiLamViec;
        private ComboBox cboLoaiXe;
    }
}