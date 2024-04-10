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
            pictureBox1 = new PictureBox();
            btnKhachHang = new Button();
            btnNhanVien = new Button();
            btnQuanTriVien = new Button();
            lblMoTa = new Label();
            panelChaoMung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelChaoMung
            // 
            panelChaoMung.BackColor = Color.White;
            panelChaoMung.Controls.Add(pictureBox1);
            panelChaoMung.Controls.Add(btnKhachHang);
            panelChaoMung.Controls.Add(btnNhanVien);
            panelChaoMung.Controls.Add(btnQuanTriVien);
            panelChaoMung.Controls.Add(lblMoTa);
            panelChaoMung.Location = new Point(338, 0);
            panelChaoMung.Name = "panelChaoMung";
            panelChaoMung.Size = new Size(336, 431);
            panelChaoMung.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.X_Delivery;
            pictureBox1.Location = new Point(72, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
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
            btnNhanVien.MouseEnter += btnNhanVien_MouseEnter;
            btnNhanVien.MouseLeave += btnNhanVien_MouseLeave;
            // 
            // btnQuanTriVien
            // 
            btnQuanTriVien.BackColor = Color.FromArgb(255, 128, 0);
            btnQuanTriVien.FlatAppearance.BorderSize = 0;
            btnQuanTriVien.FlatStyle = FlatStyle.Flat;
            btnQuanTriVien.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuanTriVien.ForeColor = Color.White;
            btnQuanTriVien.Image = Properties.Resources.icons8_admin_96;
            btnQuanTriVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuanTriVien.Location = new Point(40, 343);
            btnQuanTriVien.Name = "btnQuanTriVien";
            btnQuanTriVien.Size = new Size(256, 67);
            btnQuanTriVien.TabIndex = 4;
            btnQuanTriVien.Text = "Dành cho\r\nQUẢN TRỊ VIÊN";
            btnQuanTriVien.TextAlign = ContentAlignment.MiddleRight;
            btnQuanTriVien.UseVisualStyleBackColor = false;
            btnQuanTriVien.MouseEnter += btnQuanTriVien_MouseEnter;
            btnQuanTriVien.MouseLeave += btnQuanTriVien_MouseLeave;
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
            Load += Form_ChaoMung_Load;
            panelChaoMung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChaoMung;
        private Label lblMoTa;
        private Button btnQuanTriVien;
        private Button btnKhachHang;
        private Button btnNhanVien;
        private PictureBox pictureBox1;
    }
}