namespace OOP_Logistics
{
    partial class Form_DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangKy));
            panelChaoMung = new Panel();
            lblVeTrangChu = new Label();
            ptbLogo = new PictureBox();
            btnKhachHang = new Button();
            btnNhanVien = new Button();
            lblMoTa = new Label();
            panelChaoMung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // panelChaoMung
            // 
            panelChaoMung.BackColor = Color.White;
            panelChaoMung.Controls.Add(lblVeTrangChu);
            panelChaoMung.Controls.Add(ptbLogo);
            panelChaoMung.Controls.Add(btnKhachHang);
            panelChaoMung.Controls.Add(btnNhanVien);
            panelChaoMung.Controls.Add(lblMoTa);
            panelChaoMung.Location = new Point(338, 0);
            panelChaoMung.Name = "panelChaoMung";
            panelChaoMung.Size = new Size(336, 431);
            panelChaoMung.TabIndex = 1;
            // 
            // lblVeTrangChu
            // 
            lblVeTrangChu.AutoSize = true;
            lblVeTrangChu.ForeColor = Color.Blue;
            lblVeTrangChu.Location = new Point(96, 356);
            lblVeTrangChu.Name = "lblVeTrangChu";
            lblVeTrangChu.Size = new Size(145, 15);
            lblVeTrangChu.TabIndex = 16;
            lblVeTrangChu.Text = "Quay lại trang chào mừng";
            lblVeTrangChu.Click += lblVeTrangChu_Click;
            // 
            // ptbLogo
            // 
            ptbLogo.Image = Properties.Resources.X_Delivery;
            ptbLogo.Location = new Point(72, 34);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(189, 72);
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLogo.TabIndex = 5;
            ptbLogo.TabStop = false;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.FromArgb(255, 128, 0);
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.Image = Properties.Resources.icons8_person_96;
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(40, 197);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(256, 67);
            btnKhachHang.TabIndex = 2;
            btnKhachHang.Text = "Dành cho\r\nKHÁCH HÀNG";
            btnKhachHang.TextAlign = ContentAlignment.MiddleRight;
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            btnKhachHang.MouseEnter += btnKhachHang_MouseEnter;
            btnKhachHang.MouseLeave += btnKhachHang_MouseLeave;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.FromArgb(255, 128, 0);
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.Image = Properties.Resources.icons8_worker_96;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(40, 270);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(256, 67);
            btnNhanVien.TabIndex = 3;
            btnNhanVien.Text = "Dành cho\r\nNHÂN VIÊN";
            btnNhanVien.TextAlign = ContentAlignment.MiddleRight;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            btnNhanVien.MouseEnter += btnNhanVien_MouseEnter;
            btnNhanVien.MouseLeave += btnNhanVien_MouseLeave;
            // 
            // lblMoTa
            // 
            lblMoTa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoTa.ForeColor = Color.Black;
            lblMoTa.Location = new Point(21, 130);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(294, 37);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Chọn đối tượng đăng ký";
            lblMoTa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_DangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DangKy_background;
            ClientSize = new Size(674, 431);
            Controls.Add(panelChaoMung);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_DangKy";
            Text = "Đăng ký";
            panelChaoMung.ResumeLayout(false);
            panelChaoMung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChaoMung;
        private PictureBox ptbLogo;
        private Button btnKhachHang;
        private Button btnNhanVien;
        private Label lblMoTa;
        private Label lblVeTrangChu;
    }
}