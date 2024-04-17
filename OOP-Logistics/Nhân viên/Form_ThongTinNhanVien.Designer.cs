namespace OOP_Logistics
{
    partial class Form_ThongTinNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ThongTinNhanVien));
            btnThoat = new Button();
            txtSoCCCD = new TextBox();
            lblSoCCCD = new Label();
            txtNoiLamViec = new TextBox();
            lblNoiLamViec = new Label();
            txtSoDienThoai = new TextBox();
            lblSoDienThoai = new Label();
            txtHoVaTen = new TextBox();
            lblHoVaTen = new Label();
            cboLoaiNhanVien = new ComboBox();
            lblLoaiNhanVien = new Label();
            lblTieuDe = new Label();
            btnChiTraLuong = new Button();
            cboChucVu = new ComboBox();
            lblChucVu = new Label();
            btnLuu = new Button();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.White;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.FromArgb(255, 128, 0);
            btnThoat.Location = new Point(19, 249);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(133, 40);
            btnThoat.TabIndex = 73;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtSoCCCD
            // 
            txtSoCCCD.Enabled = false;
            txtSoCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoCCCD.Location = new Point(19, 200);
            txtSoCCCD.Name = "txtSoCCCD";
            txtSoCCCD.Size = new Size(212, 29);
            txtSoCCCD.TabIndex = 63;
            // 
            // lblSoCCCD
            // 
            lblSoCCCD.AutoSize = true;
            lblSoCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoCCCD.Location = new Point(19, 176);
            lblSoCCCD.Name = "lblSoCCCD";
            lblSoCCCD.Size = new Size(93, 21);
            lblSoCCCD.TabIndex = 62;
            lblSoCCCD.Text = "Số căn cước";
            // 
            // txtNoiLamViec
            // 
            txtNoiLamViec.Enabled = false;
            txtNoiLamViec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoiLamViec.Location = new Point(235, 200);
            txtNoiLamViec.Name = "txtNoiLamViec";
            txtNoiLamViec.Size = new Size(212, 29);
            txtNoiLamViec.TabIndex = 65;
            // 
            // lblNoiLamViec
            // 
            lblNoiLamViec.AutoSize = true;
            lblNoiLamViec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoiLamViec.Location = new Point(235, 176);
            lblNoiLamViec.Name = "lblNoiLamViec";
            lblNoiLamViec.Size = new Size(97, 21);
            lblNoiLamViec.TabIndex = 64;
            lblNoiLamViec.Text = "Nơi làm việc";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Enabled = false;
            txtSoDienThoai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoDienThoai.Location = new Point(235, 144);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(212, 29);
            txtSoDienThoai.TabIndex = 61;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoDienThoai.Location = new Point(235, 120);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(101, 21);
            lblSoDienThoai.TabIndex = 60;
            lblSoDienThoai.Text = "Số điện thoại";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Enabled = false;
            txtHoVaTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoVaTen.Location = new Point(19, 144);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(212, 29);
            txtHoVaTen.TabIndex = 59;
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.AutoSize = true;
            lblHoVaTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoVaTen.Location = new Point(19, 120);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(76, 21);
            lblHoVaTen.TabIndex = 58;
            lblHoVaTen.Text = "Họ và tên";
            // 
            // cboLoaiNhanVien
            // 
            cboLoaiNhanVien.Enabled = false;
            cboLoaiNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiNhanVien.FormattingEnabled = true;
            cboLoaiNhanVien.Items.AddRange(new object[] { "Nhân viên trung chuyển", "Tài xế cơ hữu" });
            cboLoaiNhanVien.Location = new Point(19, 88);
            cboLoaiNhanVien.Name = "cboLoaiNhanVien";
            cboLoaiNhanVien.Size = new Size(212, 29);
            cboLoaiNhanVien.TabIndex = 57;
            // 
            // lblLoaiNhanVien
            // 
            lblLoaiNhanVien.AutoSize = true;
            lblLoaiNhanVien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoaiNhanVien.Location = new Point(19, 64);
            lblLoaiNhanVien.Name = "lblLoaiNhanVien";
            lblLoaiNhanVien.Size = new Size(117, 21);
            lblLoaiNhanVien.TabIndex = 56;
            lblLoaiNhanVien.Text = "Loại nhân viên:";
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = Color.FromArgb(255, 128, 0);
            lblTieuDe.Location = new Point(89, 19);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(291, 32);
            lblTieuDe.TabIndex = 55;
            lblTieuDe.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // btnChiTraLuong
            // 
            btnChiTraLuong.BackColor = Color.FromArgb(255, 128, 0);
            btnChiTraLuong.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnChiTraLuong.FlatStyle = FlatStyle.Flat;
            btnChiTraLuong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChiTraLuong.ForeColor = Color.White;
            btnChiTraLuong.Location = new Point(166, 249);
            btnChiTraLuong.Name = "btnChiTraLuong";
            btnChiTraLuong.Size = new Size(133, 40);
            btnChiTraLuong.TabIndex = 74;
            btnChiTraLuong.Text = "Chi trả lương";
            btnChiTraLuong.UseVisualStyleBackColor = false;
            btnChiTraLuong.Click += btnChiTraLuong_Click;
            // 
            // cboChucVu
            // 
            cboChucVu.Enabled = false;
            cboChucVu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Trưởng kho", "Quản lý", "Nhân viên thường" });
            cboChucVu.Location = new Point(235, 88);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(212, 29);
            cboChucVu.TabIndex = 76;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChucVu.Location = new Point(235, 64);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(72, 21);
            lblChucVu.TabIndex = 75;
            lblChucVu.Text = "Chức vụ:";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(255, 128, 0);
            btnLuu.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(314, 249);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(133, 40);
            btnLuu.TabIndex = 77;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // Form_ThongTinNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(467, 301);
            Controls.Add(btnLuu);
            Controls.Add(cboChucVu);
            Controls.Add(lblChucVu);
            Controls.Add(btnChiTraLuong);
            Controls.Add(btnThoat);
            Controls.Add(txtSoCCCD);
            Controls.Add(lblSoCCCD);
            Controls.Add(txtNoiLamViec);
            Controls.Add(lblNoiLamViec);
            Controls.Add(txtSoDienThoai);
            Controls.Add(lblSoDienThoai);
            Controls.Add(txtHoVaTen);
            Controls.Add(lblHoVaTen);
            Controls.Add(cboLoaiNhanVien);
            Controls.Add(lblLoaiNhanVien);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_ThongTinNhanVien";
            Text = "Thông tin nhân viên";
            Load += Form_ThongTinNhanVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private TextBox txtSoCCCD;
        private Label lblSoCCCD;
        private TextBox txtNoiLamViec;
        private Label lblNoiLamViec;
        private TextBox txtSoDienThoai;
        private Label lblSoDienThoai;
        private TextBox txtHoVaTen;
        private Label lblHoVaTen;
        private ComboBox cboLoaiNhanVien;
        private Label lblLoaiNhanVien;
        private Label lblTieuDe;
        private Button btnChiTraLuong;
        private ComboBox cboChucVu;
        private Label lblChucVu;
        private Button btnLuu;
    }
}