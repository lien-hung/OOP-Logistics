namespace OOP_Logistics
{
    partial class Form_DatLaiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DatLaiMatKhau));
            lblTieuDe = new Label();
            txtTenDangNhap = new TextBox();
            lblTenDangNhap = new Label();
            txtMatKhauMoi = new TextBox();
            lblMatKhauMoi = new Label();
            txtXacNhanMatKhau = new TextBox();
            lblXacNhanMatKhau = new Label();
            btnHuy = new Button();
            btnDatLai = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = Color.FromArgb(255, 128, 0);
            lblTieuDe.Location = new Point(55, 21);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(243, 32);
            lblTieuDe.TabIndex = 8;
            lblTieuDe.Text = "ĐẶT LẠI MẬT KHẨU";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(29, 94);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(301, 29);
            txtTenDangNhap.TabIndex = 13;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(29, 70);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(116, 21);
            lblTenDangNhap.TabIndex = 12;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhauMoi.Location = new Point(29, 154);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '●';
            txtMatKhauMoi.Size = new Size(301, 29);
            txtMatKhauMoi.TabIndex = 15;
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatKhauMoi.Location = new Point(29, 130);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(109, 21);
            lblMatKhauMoi.TabIndex = 14;
            lblMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtXacNhanMatKhau.Location = new Point(29, 214);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '●';
            txtXacNhanMatKhau.Size = new Size(301, 29);
            txtXacNhanMatKhau.TabIndex = 17;
            // 
            // lblXacNhanMatKhau
            // 
            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXacNhanMatKhau.Location = new Point(29, 190);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new Size(145, 21);
            lblXacNhanMatKhau.TabIndex = 16;
            lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.FromArgb(255, 128, 0);
            btnHuy.Location = new Point(185, 249);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(145, 40);
            btnHuy.TabIndex = 19;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            btnHuy.MouseEnter += btnHuy_MouseEnter;
            btnHuy.MouseLeave += btnHuy_MouseLeave;
            // 
            // btnDatLai
            // 
            btnDatLai.BackColor = Color.FromArgb(255, 128, 0);
            btnDatLai.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnDatLai.FlatStyle = FlatStyle.Flat;
            btnDatLai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatLai.ForeColor = Color.White;
            btnDatLai.Location = new Point(29, 249);
            btnDatLai.Name = "btnDatLai";
            btnDatLai.Size = new Size(145, 40);
            btnDatLai.TabIndex = 18;
            btnDatLai.Text = "Đặt lại";
            btnDatLai.UseVisualStyleBackColor = false;
            btnDatLai.Click += btnDatLai_Click;
            btnDatLai.MouseEnter += btnDatLai_MouseEnter;
            btnDatLai.MouseLeave += btnDatLai_MouseLeave;
            // 
            // Form_DatLaiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(360, 306);
            Controls.Add(btnHuy);
            Controls.Add(btnDatLai);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(lblXacNhanMatKhau);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(lblMatKhauMoi);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblTieuDe);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_DatLaiMatKhau";
            Text = "Đặt lại mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private TextBox txtTenDangNhap;
        private Label lblTenDangNhap;
        private TextBox txtMatKhauMoi;
        private Label lblMatKhauMoi;
        private TextBox txtXacNhanMatKhau;
        private Label lblXacNhanMatKhau;
        private Button btnHuy;
        private Button btnDatLai;
    }
}