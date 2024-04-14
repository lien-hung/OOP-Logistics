namespace OOP_Logistics
{
    partial class Form_ChaoMung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChaoMung));
            panelChaoMung = new Panel();
            btnDangKy = new Button();
            btnDangNhap = new Button();
            lblDisclaimer = new Label();
            ptbLogo = new PictureBox();
            lblMoTa = new Label();
            panelChaoMung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // panelChaoMung
            // 
            panelChaoMung.BackColor = Color.White;
            panelChaoMung.Controls.Add(btnDangKy);
            panelChaoMung.Controls.Add(btnDangNhap);
            panelChaoMung.Controls.Add(lblDisclaimer);
            panelChaoMung.Controls.Add(ptbLogo);
            panelChaoMung.Controls.Add(lblMoTa);
            panelChaoMung.Location = new Point(338, 0);
            panelChaoMung.Name = "panelChaoMung";
            panelChaoMung.Size = new Size(336, 431);
            panelChaoMung.TabIndex = 0;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.White;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.FromArgb(255, 128, 0);
            btnDangKy.Location = new Point(86, 271);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(161, 46);
            btnDangKy.TabIndex = 7;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            btnDangKy.MouseEnter += btnDangKy_MouseEnter;
            btnDangKy.MouseLeave += btnDangKy_MouseLeave;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(255, 128, 0);
            btnDangNhap.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(86, 219);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(161, 46);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            btnDangNhap.MouseEnter += btnDangNhap_MouseEnter;
            btnDangNhap.MouseLeave += btnDangNhap_MouseLeave;
            // 
            // lblDisclaimer
            // 
            lblDisclaimer.BackColor = Color.Transparent;
            lblDisclaimer.Location = new Point(53, 368);
            lblDisclaimer.Name = "lblDisclaimer";
            lblDisclaimer.Size = new Size(230, 38);
            lblDisclaimer.TabIndex = 1;
            lblDisclaimer.Text = "Lưu ý: Phần mềm chỉ phục vụ môn học, không có giá trị giao nhận trên thực tế";
            lblDisclaimer.TextAlign = ContentAlignment.MiddleCenter;
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
            // lblMoTa
            // 
            lblMoTa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMoTa.ForeColor = Color.Black;
            lblMoTa.Location = new Point(21, 120);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(294, 63);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Nền tảng giao nhận tiết kiệm, chất lượng. Trải nghiệm ngay!";
            lblMoTa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_ChaoMung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChaoMung_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(674, 431);
            Controls.Add(panelChaoMung);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_ChaoMung";
            Text = "Chào mừng";
            panelChaoMung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChaoMung;
        private Label lblMoTa;
        private PictureBox ptbLogo;
        private Label lblDisclaimer;
        private Button btnDangNhap;
        private Button btnDangKy;
    }
}