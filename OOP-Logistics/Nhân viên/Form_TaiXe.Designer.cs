namespace OOP_Logistics
{
    partial class Form_TaiXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TaiXe));
            btnXoaTaiKhoan = new Button();
            dgvLichSuGiaoHang = new DataGridView();
            txtBienSo = new TextBox();
            lblBienSo = new Label();
            txtPhuongTien = new TextBox();
            lblPhuongTien = new Label();
            txtSoCCCD = new TextBox();
            lblTieuDeThongTin = new Label();
            lblLichSuGiaoHang = new Label();
            navbarTaiXe = new Panel();
            btnDangXuat = new Button();
            btnLichSuGiaoHang = new Button();
            btnNhanDon = new Button();
            panelThongTin = new Panel();
            btnSuaTaiKhoan = new Button();
            btnSuaThongTin = new Button();
            btnLuuThongTin = new Button();
            btnLuuTaiKhoan = new Button();
            grpThongTinTaiKhoan = new GroupBox();
            txtXacNhanMatKhau = new TextBox();
            lblXacNhanMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            grpThongTinChung = new GroupBox();
            lblSoCCCD = new Label();
            txtSoDienThoai = new TextBox();
            lblSoDienThoai = new Label();
            txtHoVaTen = new TextBox();
            lblHoVaTen = new Label();
            lblMaTaiXe = new Label();
            txtMaTaiXe = new TextBox();
            panelNhanDon = new Panel();
            btnNhanGiao = new Button();
            dgvNhanDon = new DataGridView();
            lblTieuDeNhanDon = new Label();
            panelLichSuGiaoHang = new Panel();
            btnDanhDauDaGiao = new Button();
            lblDiemDanhGia = new Label();
            lblTongThuNhap = new Label();
            lblDiemDanhGiaText = new Label();
            lblTongThuNhapText = new Label();
            panelTaiXe = new Panel();
            lblTenTaiXe = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuGiaoHang).BeginInit();
            navbarTaiXe.SuspendLayout();
            panelThongTin.SuspendLayout();
            grpThongTinTaiKhoan.SuspendLayout();
            grpThongTinChung.SuspendLayout();
            panelNhanDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanDon).BeginInit();
            panelLichSuGiaoHang.SuspendLayout();
            panelTaiXe.SuspendLayout();
            SuspendLayout();
            // 
            // btnXoaTaiKhoan
            // 
            btnXoaTaiKhoan.BackColor = Color.Red;
            btnXoaTaiKhoan.FlatAppearance.BorderColor = Color.Red;
            btnXoaTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnXoaTaiKhoan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaTaiKhoan.ForeColor = Color.White;
            btnXoaTaiKhoan.Location = new Point(519, 459);
            btnXoaTaiKhoan.Margin = new Padding(0);
            btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            btnXoaTaiKhoan.Size = new Size(135, 43);
            btnXoaTaiKhoan.TabIndex = 19;
            btnXoaTaiKhoan.Text = "Xóa tài khoản";
            btnXoaTaiKhoan.UseVisualStyleBackColor = false;
            btnXoaTaiKhoan.Click += btnXoaTaiKhoan_Click;
            // 
            // dgvLichSuGiaoHang
            // 
            dgvLichSuGiaoHang.AllowUserToAddRows = false;
            dgvLichSuGiaoHang.AllowUserToDeleteRows = false;
            dgvLichSuGiaoHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSuGiaoHang.Location = new Point(32, 69);
            dgvLichSuGiaoHang.MultiSelect = false;
            dgvLichSuGiaoHang.Name = "dgvLichSuGiaoHang";
            dgvLichSuGiaoHang.Size = new Size(622, 398);
            dgvLichSuGiaoHang.TabIndex = 20;
            // 
            // txtBienSo
            // 
            txtBienSo.Enabled = false;
            txtBienSo.Location = new Point(111, 287);
            txtBienSo.Name = "txtBienSo";
            txtBienSo.Size = new Size(179, 29);
            txtBienSo.TabIndex = 11;
            // 
            // lblBienSo
            // 
            lblBienSo.AutoSize = true;
            lblBienSo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienSo.Location = new Point(6, 290);
            lblBienSo.Name = "lblBienSo";
            lblBienSo.Size = new Size(60, 21);
            lblBienSo.TabIndex = 10;
            lblBienSo.Text = "Biển số";
            // 
            // txtPhuongTien
            // 
            txtPhuongTien.Enabled = false;
            txtPhuongTien.Location = new Point(111, 245);
            txtPhuongTien.Name = "txtPhuongTien";
            txtPhuongTien.Size = new Size(179, 29);
            txtPhuongTien.TabIndex = 9;
            // 
            // lblPhuongTien
            // 
            lblPhuongTien.AutoSize = true;
            lblPhuongTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhuongTien.Location = new Point(6, 248);
            lblPhuongTien.Name = "lblPhuongTien";
            lblPhuongTien.Size = new Size(95, 21);
            lblPhuongTien.TabIndex = 8;
            lblPhuongTien.Text = "Phương tiện";
            // 
            // txtSoCCCD
            // 
            txtSoCCCD.Enabled = false;
            txtSoCCCD.Location = new Point(111, 203);
            txtSoCCCD.Name = "txtSoCCCD";
            txtSoCCCD.Size = new Size(179, 29);
            txtSoCCCD.TabIndex = 7;
            // 
            // lblTieuDeThongTin
            // 
            lblTieuDeThongTin.AutoSize = true;
            lblTieuDeThongTin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDeThongTin.ForeColor = Color.FromArgb(255, 128, 0);
            lblTieuDeThongTin.Location = new Point(26, 24);
            lblTieuDeThongTin.Name = "lblTieuDeThongTin";
            lblTieuDeThongTin.Size = new Size(229, 32);
            lblTieuDeThongTin.TabIndex = 1;
            lblTieuDeThongTin.Text = "THÔNG TIN TÀI XẾ";
            // 
            // lblLichSuGiaoHang
            // 
            lblLichSuGiaoHang.AutoSize = true;
            lblLichSuGiaoHang.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLichSuGiaoHang.ForeColor = Color.FromArgb(255, 128, 0);
            lblLichSuGiaoHang.Location = new Point(26, 24);
            lblLichSuGiaoHang.Name = "lblLichSuGiaoHang";
            lblLichSuGiaoHang.Size = new Size(251, 32);
            lblLichSuGiaoHang.TabIndex = 1;
            lblLichSuGiaoHang.Text = "LỊCH SỬ GIAO HÀNG";
            // 
            // navbarTaiXe
            // 
            navbarTaiXe.BackColor = Color.FromArgb(255, 128, 0);
            navbarTaiXe.Controls.Add(btnDangXuat);
            navbarTaiXe.Controls.Add(btnLichSuGiaoHang);
            navbarTaiXe.Controls.Add(btnNhanDon);
            navbarTaiXe.Location = new Point(0, 90);
            navbarTaiXe.Name = "navbarTaiXe";
            navbarTaiXe.Size = new Size(230, 476);
            navbarTaiXe.TabIndex = 6;
            // 
            // btnDangXuat
            // 
            btnDangXuat.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(0, 85);
            btnDangXuat.Margin = new Padding(0);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(230, 43);
            btnDangXuat.TabIndex = 2;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnLichSuGiaoHang
            // 
            btnLichSuGiaoHang.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            btnLichSuGiaoHang.FlatStyle = FlatStyle.Flat;
            btnLichSuGiaoHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLichSuGiaoHang.ForeColor = Color.White;
            btnLichSuGiaoHang.Location = new Point(0, 43);
            btnLichSuGiaoHang.Margin = new Padding(0);
            btnLichSuGiaoHang.Name = "btnLichSuGiaoHang";
            btnLichSuGiaoHang.Size = new Size(230, 43);
            btnLichSuGiaoHang.TabIndex = 1;
            btnLichSuGiaoHang.Text = "Lịch sử giao hàng";
            btnLichSuGiaoHang.UseVisualStyleBackColor = true;
            btnLichSuGiaoHang.Click += btnLichSuGiaoHang_Click;
            // 
            // btnNhanDon
            // 
            btnNhanDon.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            btnNhanDon.FlatStyle = FlatStyle.Flat;
            btnNhanDon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhanDon.ForeColor = Color.White;
            btnNhanDon.Location = new Point(0, 1);
            btnNhanDon.Margin = new Padding(0);
            btnNhanDon.Name = "btnNhanDon";
            btnNhanDon.Size = new Size(230, 43);
            btnNhanDon.TabIndex = 0;
            btnNhanDon.Text = "Nhận đơn";
            btnNhanDon.UseVisualStyleBackColor = true;
            btnNhanDon.Click += btnNhanDon_Click;
            // 
            // panelThongTin
            // 
            panelThongTin.BackColor = Color.FromArgb(255, 224, 192);
            panelThongTin.Controls.Add(btnSuaTaiKhoan);
            panelThongTin.Controls.Add(btnSuaThongTin);
            panelThongTin.Controls.Add(btnLuuThongTin);
            panelThongTin.Controls.Add(btnLuuTaiKhoan);
            panelThongTin.Controls.Add(btnXoaTaiKhoan);
            panelThongTin.Controls.Add(grpThongTinTaiKhoan);
            panelThongTin.Controls.Add(grpThongTinChung);
            panelThongTin.Controls.Add(lblTieuDeThongTin);
            panelThongTin.Location = new Point(228, 0);
            panelThongTin.Name = "panelThongTin";
            panelThongTin.Size = new Size(681, 566);
            panelThongTin.TabIndex = 7;
            // 
            // btnSuaTaiKhoan
            // 
            btnSuaTaiKhoan.BackColor = Color.Black;
            btnSuaTaiKhoan.FlatAppearance.BorderColor = Color.Black;
            btnSuaTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnSuaTaiKhoan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaTaiKhoan.ForeColor = Color.White;
            btnSuaTaiKhoan.Location = new Point(358, 459);
            btnSuaTaiKhoan.Margin = new Padding(0);
            btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
            btnSuaTaiKhoan.Size = new Size(63, 43);
            btnSuaTaiKhoan.TabIndex = 28;
            btnSuaTaiKhoan.Text = "Sửa";
            btnSuaTaiKhoan.UseVisualStyleBackColor = false;
            btnSuaTaiKhoan.Click += btnSuaTaiKhoan_Click;
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.BackColor = Color.Black;
            btnSuaThongTin.FlatAppearance.BorderColor = Color.Black;
            btnSuaThongTin.FlatStyle = FlatStyle.Flat;
            btnSuaThongTin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaThongTin.ForeColor = Color.White;
            btnSuaThongTin.Location = new Point(26, 459);
            btnSuaThongTin.Margin = new Padding(0);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(63, 43);
            btnSuaThongTin.TabIndex = 27;
            btnSuaThongTin.Text = "Sửa";
            btnSuaThongTin.UseVisualStyleBackColor = false;
            btnSuaThongTin.Click += btnSuaThongTin_Click;
            // 
            // btnLuuThongTin
            // 
            btnLuuThongTin.BackColor = Color.Black;
            btnLuuThongTin.Enabled = false;
            btnLuuThongTin.FlatAppearance.BorderColor = Color.Black;
            btnLuuThongTin.FlatStyle = FlatStyle.Flat;
            btnLuuThongTin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuuThongTin.ForeColor = Color.White;
            btnLuuThongTin.Location = new Point(98, 459);
            btnLuuThongTin.Margin = new Padding(0);
            btnLuuThongTin.Name = "btnLuuThongTin";
            btnLuuThongTin.Size = new Size(63, 43);
            btnLuuThongTin.TabIndex = 29;
            btnLuuThongTin.Text = "Lưu";
            btnLuuThongTin.UseVisualStyleBackColor = false;
            btnLuuThongTin.Click += btnLuuThongTin_Click;
            // 
            // btnLuuTaiKhoan
            // 
            btnLuuTaiKhoan.BackColor = Color.Black;
            btnLuuTaiKhoan.Enabled = false;
            btnLuuTaiKhoan.FlatAppearance.BorderColor = Color.Black;
            btnLuuTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnLuuTaiKhoan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuuTaiKhoan.ForeColor = Color.White;
            btnLuuTaiKhoan.Location = new Point(430, 459);
            btnLuuTaiKhoan.Margin = new Padding(0);
            btnLuuTaiKhoan.Name = "btnLuuTaiKhoan";
            btnLuuTaiKhoan.Size = new Size(63, 43);
            btnLuuTaiKhoan.TabIndex = 30;
            btnLuuTaiKhoan.Text = "Lưu";
            btnLuuTaiKhoan.UseVisualStyleBackColor = false;
            btnLuuTaiKhoan.Click += btnLuuTaiKhoan_Click;
            // 
            // grpThongTinTaiKhoan
            // 
            grpThongTinTaiKhoan.Controls.Add(txtXacNhanMatKhau);
            grpThongTinTaiKhoan.Controls.Add(lblXacNhanMatKhau);
            grpThongTinTaiKhoan.Controls.Add(txtMatKhau);
            grpThongTinTaiKhoan.Controls.Add(lblMatKhau);
            grpThongTinTaiKhoan.Controls.Add(lblTenDangNhap);
            grpThongTinTaiKhoan.Controls.Add(txtTenDangNhap);
            grpThongTinTaiKhoan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpThongTinTaiKhoan.Location = new Point(358, 76);
            grpThongTinTaiKhoan.Name = "grpThongTinTaiKhoan";
            grpThongTinTaiKhoan.Size = new Size(296, 380);
            grpThongTinTaiKhoan.TabIndex = 16;
            grpThongTinTaiKhoan.TabStop = false;
            grpThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Enabled = false;
            txtXacNhanMatKhau.Location = new Point(123, 225);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '●';
            txtXacNhanMatKhau.Size = new Size(167, 29);
            txtXacNhanMatKhau.TabIndex = 5;
            // 
            // lblXacNhanMatKhau
            // 
            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblXacNhanMatKhau.Location = new Point(6, 228);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new Size(73, 21);
            lblXacNhanMatKhau.TabIndex = 4;
            lblXacNhanMatKhau.Text = "Xác nhận";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Enabled = false;
            txtMatKhau.Location = new Point(123, 183);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(167, 29);
            txtMatKhau.TabIndex = 3;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(6, 186);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(75, 21);
            lblMatKhau.TabIndex = 2;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(6, 144);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(111, 21);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Enabled = false;
            txtTenDangNhap.Location = new Point(123, 141);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(167, 29);
            txtTenDangNhap.TabIndex = 0;
            // 
            // grpThongTinChung
            // 
            grpThongTinChung.Controls.Add(txtBienSo);
            grpThongTinChung.Controls.Add(lblBienSo);
            grpThongTinChung.Controls.Add(txtPhuongTien);
            grpThongTinChung.Controls.Add(lblPhuongTien);
            grpThongTinChung.Controls.Add(txtSoCCCD);
            grpThongTinChung.Controls.Add(lblSoCCCD);
            grpThongTinChung.Controls.Add(txtSoDienThoai);
            grpThongTinChung.Controls.Add(lblSoDienThoai);
            grpThongTinChung.Controls.Add(txtHoVaTen);
            grpThongTinChung.Controls.Add(lblHoVaTen);
            grpThongTinChung.Controls.Add(lblMaTaiXe);
            grpThongTinChung.Controls.Add(txtMaTaiXe);
            grpThongTinChung.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpThongTinChung.Location = new Point(26, 76);
            grpThongTinChung.Name = "grpThongTinChung";
            grpThongTinChung.Size = new Size(296, 380);
            grpThongTinChung.TabIndex = 2;
            grpThongTinChung.TabStop = false;
            grpThongTinChung.Text = "Thông tin chung";
            // 
            // lblSoCCCD
            // 
            lblSoCCCD.AutoSize = true;
            lblSoCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoCCCD.Location = new Point(6, 206);
            lblSoCCCD.Name = "lblSoCCCD";
            lblSoCCCD.Size = new Size(93, 21);
            lblSoCCCD.TabIndex = 6;
            lblSoCCCD.Text = "Số căn cước";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Enabled = false;
            txtSoDienThoai.Location = new Point(111, 161);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(179, 29);
            txtSoDienThoai.TabIndex = 5;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoDienThoai.Location = new Point(6, 164);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(101, 21);
            lblSoDienThoai.TabIndex = 4;
            lblSoDienThoai.Text = "Số điện thoại";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Enabled = false;
            txtHoVaTen.Location = new Point(111, 119);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(179, 29);
            txtHoVaTen.TabIndex = 3;
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.AutoSize = true;
            lblHoVaTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoVaTen.Location = new Point(6, 122);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(76, 21);
            lblHoVaTen.TabIndex = 2;
            lblHoVaTen.Text = "Họ và tên";
            // 
            // lblMaTaiXe
            // 
            lblMaTaiXe.AutoSize = true;
            lblMaTaiXe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaTaiXe.Location = new Point(6, 80);
            lblMaTaiXe.Name = "lblMaTaiXe";
            lblMaTaiXe.Size = new Size(52, 21);
            lblMaTaiXe.TabIndex = 1;
            lblMaTaiXe.Text = "Mã số";
            // 
            // txtMaTaiXe
            // 
            txtMaTaiXe.Enabled = false;
            txtMaTaiXe.Location = new Point(111, 77);
            txtMaTaiXe.Name = "txtMaTaiXe";
            txtMaTaiXe.Size = new Size(179, 29);
            txtMaTaiXe.TabIndex = 0;
            // 
            // panelNhanDon
            // 
            panelNhanDon.BackColor = Color.FromArgb(255, 224, 192);
            panelNhanDon.Controls.Add(btnNhanGiao);
            panelNhanDon.Controls.Add(dgvNhanDon);
            panelNhanDon.Controls.Add(lblTieuDeNhanDon);
            panelNhanDon.Location = new Point(228, 0);
            panelNhanDon.Name = "panelNhanDon";
            panelNhanDon.Size = new Size(681, 566);
            panelNhanDon.TabIndex = 20;
            // 
            // btnNhanGiao
            // 
            btnNhanGiao.BackColor = Color.Black;
            btnNhanGiao.FlatAppearance.BorderColor = Color.Black;
            btnNhanGiao.FlatStyle = FlatStyle.Flat;
            btnNhanGiao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhanGiao.ForeColor = Color.White;
            btnNhanGiao.Location = new Point(546, 494);
            btnNhanGiao.Margin = new Padding(0);
            btnNhanGiao.Name = "btnNhanGiao";
            btnNhanGiao.Size = new Size(108, 43);
            btnNhanGiao.TabIndex = 17;
            btnNhanGiao.Text = "Nhận giao";
            btnNhanGiao.UseVisualStyleBackColor = false;
            btnNhanGiao.Click += btnNhanGiao_Click;
            // 
            // dgvNhanDon
            // 
            dgvNhanDon.AllowUserToAddRows = false;
            dgvNhanDon.AllowUserToDeleteRows = false;
            dgvNhanDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanDon.Location = new Point(32, 69);
            dgvNhanDon.MultiSelect = false;
            dgvNhanDon.Name = "dgvNhanDon";
            dgvNhanDon.Size = new Size(622, 416);
            dgvNhanDon.TabIndex = 45;
            // 
            // lblTieuDeNhanDon
            // 
            lblTieuDeNhanDon.AutoSize = true;
            lblTieuDeNhanDon.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDeNhanDon.ForeColor = Color.FromArgb(255, 128, 0);
            lblTieuDeNhanDon.Location = new Point(26, 24);
            lblTieuDeNhanDon.Name = "lblTieuDeNhanDon";
            lblTieuDeNhanDon.Size = new Size(388, 32);
            lblTieuDeNhanDon.TabIndex = 1;
            lblTieuDeNhanDon.Text = "NHẬN ĐƠN HÀNG VÀ BƯU KIỆN";
            // 
            // panelLichSuGiaoHang
            // 
            panelLichSuGiaoHang.BackColor = Color.FromArgb(255, 224, 192);
            panelLichSuGiaoHang.Controls.Add(btnDanhDauDaGiao);
            panelLichSuGiaoHang.Controls.Add(lblDiemDanhGia);
            panelLichSuGiaoHang.Controls.Add(lblTongThuNhap);
            panelLichSuGiaoHang.Controls.Add(lblDiemDanhGiaText);
            panelLichSuGiaoHang.Controls.Add(lblTongThuNhapText);
            panelLichSuGiaoHang.Controls.Add(dgvLichSuGiaoHang);
            panelLichSuGiaoHang.Controls.Add(lblLichSuGiaoHang);
            panelLichSuGiaoHang.Location = new Point(228, 0);
            panelLichSuGiaoHang.Name = "panelLichSuGiaoHang";
            panelLichSuGiaoHang.Size = new Size(681, 566);
            panelLichSuGiaoHang.TabIndex = 42;
            // 
            // btnDanhDauDaGiao
            // 
            btnDanhDauDaGiao.BackColor = Color.Black;
            btnDanhDauDaGiao.FlatAppearance.BorderColor = Color.Black;
            btnDanhDauDaGiao.FlatStyle = FlatStyle.Flat;
            btnDanhDauDaGiao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDanhDauDaGiao.ForeColor = Color.White;
            btnDanhDauDaGiao.Location = new Point(481, 488);
            btnDanhDauDaGiao.Margin = new Padding(0);
            btnDanhDauDaGiao.Name = "btnDanhDauDaGiao";
            btnDanhDauDaGiao.Size = new Size(173, 43);
            btnDanhDauDaGiao.TabIndex = 25;
            btnDanhDauDaGiao.Text = "Đánh dấu là đã giao";
            btnDanhDauDaGiao.UseVisualStyleBackColor = false;
            btnDanhDauDaGiao.Click += btnDanhDauDaGiao_Click;
            // 
            // lblDiemDanhGia
            // 
            lblDiemDanhGia.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiemDanhGia.Location = new Point(220, 508);
            lblDiemDanhGia.Name = "lblDiemDanhGia";
            lblDiemDanhGia.Size = new Size(159, 32);
            lblDiemDanhGia.TabIndex = 24;
            lblDiemDanhGia.Text = "0";
            lblDiemDanhGia.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTongThuNhap
            // 
            lblTongThuNhap.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongThuNhap.Location = new Point(220, 473);
            lblTongThuNhap.Name = "lblTongThuNhap";
            lblTongThuNhap.Size = new Size(159, 32);
            lblTongThuNhap.TabIndex = 23;
            lblTongThuNhap.Text = "0";
            lblTongThuNhap.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDiemDanhGiaText
            // 
            lblDiemDanhGiaText.AutoSize = true;
            lblDiemDanhGiaText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiemDanhGiaText.Location = new Point(32, 516);
            lblDiemDanhGiaText.Name = "lblDiemDanhGiaText";
            lblDiemDanhGiaText.Size = new Size(191, 21);
            lblDiemDanhGiaText.TabIndex = 22;
            lblDiemDanhGiaText.Text = "Điểm đánh giá trung bình:";
            // 
            // lblTongThuNhapText
            // 
            lblTongThuNhapText.AutoSize = true;
            lblTongThuNhapText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongThuNhapText.Location = new Point(32, 481);
            lblTongThuNhapText.Name = "lblTongThuNhapText";
            lblTongThuNhapText.Size = new Size(114, 21);
            lblTongThuNhapText.TabIndex = 21;
            lblTongThuNhapText.Text = "Tổng thu nhập:";
            // 
            // panelTaiXe
            // 
            panelTaiXe.BackColor = Color.White;
            panelTaiXe.BackgroundImage = Properties.Resources.icons8_driver_96;
            panelTaiXe.BackgroundImageLayout = ImageLayout.None;
            panelTaiXe.Controls.Add(lblTenTaiXe);
            panelTaiXe.Location = new Point(0, 0);
            panelTaiXe.Name = "panelTaiXe";
            panelTaiXe.Size = new Size(229, 93);
            panelTaiXe.TabIndex = 8;
            panelTaiXe.Click += panelTaiXe_Click;
            // 
            // lblTenTaiXe
            // 
            lblTenTaiXe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenTaiXe.ForeColor = Color.FromArgb(255, 128, 0);
            lblTenTaiXe.Location = new Point(88, 9);
            lblTenTaiXe.Name = "lblTenTaiXe";
            lblTenTaiXe.Size = new Size(134, 78);
            lblTenTaiXe.TabIndex = 1;
            lblTenTaiXe.Text = "NGUYỄN VĂN A";
            // 
            // Form_TaiXe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 566);
            Controls.Add(navbarTaiXe);
            Controls.Add(panelTaiXe);
            Controls.Add(panelLichSuGiaoHang);
            Controls.Add(panelNhanDon);
            Controls.Add(panelThongTin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_TaiXe";
            Text = "Tài xế";
            Load += Form_TaiXe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLichSuGiaoHang).EndInit();
            navbarTaiXe.ResumeLayout(false);
            panelThongTin.ResumeLayout(false);
            panelThongTin.PerformLayout();
            grpThongTinTaiKhoan.ResumeLayout(false);
            grpThongTinTaiKhoan.PerformLayout();
            grpThongTinChung.ResumeLayout(false);
            grpThongTinChung.PerformLayout();
            panelNhanDon.ResumeLayout(false);
            panelNhanDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanDon).EndInit();
            panelLichSuGiaoHang.ResumeLayout(false);
            panelLichSuGiaoHang.PerformLayout();
            panelTaiXe.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnXoaTaiKhoan;
        private DataGridView dgvLichSuGiaoHang;
        private TextBox txtLuongThang;
        private Label lblLuongThang;
        private TextBox txtHeSoLuong;
        private Label lblHeSoLuong;
        private TextBox txtBienSo;
        private Label lblBienSo;
        private TextBox txtPhuongTien;
        private Label lblPhuongTien;
        private TextBox txtSoCCCD;
        private Label lblTieuDeThongTin;
        private Label lblLichSuGiaoHang;
        private Panel navbarTaiXe;
        private Button btnDangXuat;
        private Button btnLichSuGiaoHang;
        private Button btnNhanDon;
        private Panel panelThongTin;
        private Panel panelNhanDon;
        private Panel panelLichSuGiaoHang;
        private Label lblKhoiLuong;
        private TextBox txtKhoiLuong;
        private Label lblMaBuuKien;
        private TextBox txtMaBuuKien;
        private Button btnNhanGiao;
        private DataGridView dgvNhanDon;
        private Label lblTieuDeNhanDon;
        private GroupBox grpThongTinTaiKhoan;
        private TextBox txtXacNhanMatKhau;
        private Label lblXacNhanMatKhau;
        private TextBox txtMatKhau;
        private Label lblMatKhau;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private GroupBox grpThongTinChung;
        private Label lblSoCCCD;
        private TextBox txtSoDienThoai;
        private Label lblSoDienThoai;
        private TextBox txtHoVaTen;
        private Label lblHoVaTen;
        private Label lblMaTaiXe;
        private TextBox txtMaTaiXe;
        private Panel panelTaiXe;
        private Label lblTenTaiXe;
        private Button btnDanhDauDaGiao;
        private Label lblDiemDanhGia;
        private Label lblTongThuNhap;
        private Label lblDiemDanhGiaText;
        private Label lblTongThuNhapText;
        private Button btnSuaTaiKhoan;
        private Button btnSuaThongTin;
        private Button btnLuuThongTin;
        private Button btnLuuTaiKhoan;
    }
}