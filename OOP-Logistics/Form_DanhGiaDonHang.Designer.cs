namespace OOP_Logistics
{
    partial class Form_DanhGiaDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DanhGiaDonHang));
            btnHuy = new Button();
            btnSuaThongTin = new Button();
            ptbStar1 = new PictureBox();
            ptbStar2 = new PictureBox();
            ptbStar3 = new PictureBox();
            ptbStar4 = new PictureBox();
            ptbStar5 = new PictureBox();
            lblDiemDau = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbStar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbStar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbStar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbStar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbStar5).BeginInit();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.White;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.FromArgb(255, 128, 0);
            btnHuy.Location = new Point(12, 178);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(130, 40);
            btnHuy.TabIndex = 53;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.BackColor = Color.FromArgb(255, 128, 0);
            btnSuaThongTin.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnSuaThongTin.FlatStyle = FlatStyle.Flat;
            btnSuaThongTin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaThongTin.ForeColor = Color.White;
            btnSuaThongTin.Location = new Point(241, 178);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(130, 40);
            btnSuaThongTin.TabIndex = 52;
            btnSuaThongTin.Text = "Đánh giá";
            btnSuaThongTin.UseVisualStyleBackColor = false;
            // 
            // ptbStar1
            // 
            ptbStar1.Image = Properties.Resources.icons8_star_100_filled;
            ptbStar1.Location = new Point(53, 91);
            ptbStar1.Name = "ptbStar1";
            ptbStar1.Size = new Size(50, 50);
            ptbStar1.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbStar1.TabIndex = 54;
            ptbStar1.TabStop = false;
            // 
            // ptbStar2
            // 
            ptbStar2.Image = Properties.Resources.icons8_star_100_filled;
            ptbStar2.Location = new Point(109, 91);
            ptbStar2.Name = "ptbStar2";
            ptbStar2.Size = new Size(50, 50);
            ptbStar2.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbStar2.TabIndex = 55;
            ptbStar2.TabStop = false;
            // 
            // ptbStar3
            // 
            ptbStar3.Image = Properties.Resources.icons8_star_100_filled;
            ptbStar3.Location = new Point(165, 91);
            ptbStar3.Name = "ptbStar3";
            ptbStar3.Size = new Size(50, 50);
            ptbStar3.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbStar3.TabIndex = 56;
            ptbStar3.TabStop = false;
            // 
            // ptbStar4
            // 
            ptbStar4.Image = Properties.Resources.icons8_star_100_filled;
            ptbStar4.Location = new Point(221, 91);
            ptbStar4.Name = "ptbStar4";
            ptbStar4.Size = new Size(50, 50);
            ptbStar4.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbStar4.TabIndex = 57;
            ptbStar4.TabStop = false;
            // 
            // ptbStar5
            // 
            ptbStar5.Image = Properties.Resources.icons8_star_100_unfilled;
            ptbStar5.Location = new Point(277, 91);
            ptbStar5.Name = "ptbStar5";
            ptbStar5.Size = new Size(50, 50);
            ptbStar5.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbStar5.TabIndex = 58;
            ptbStar5.TabStop = false;
            // 
            // lblDiemDau
            // 
            lblDiemDau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiemDau.Location = new Point(12, 9);
            lblDiemDau.Name = "lblDiemDau";
            lblDiemDau.Size = new Size(359, 61);
            lblDiemDau.TabIndex = 59;
            lblDiemDau.Text = "Cho biết mức độ hài lòng của bạn với đơn hàng để chúng tôi có cơ hội cải thiện tốt hơn\r\n";
            lblDiemDau.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_DanhGiaDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 230);
            Controls.Add(lblDiemDau);
            Controls.Add(ptbStar5);
            Controls.Add(ptbStar4);
            Controls.Add(ptbStar3);
            Controls.Add(ptbStar2);
            Controls.Add(ptbStar1);
            Controls.Add(btnHuy);
            Controls.Add(btnSuaThongTin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_DanhGiaDonHang";
            Text = "Đánh giá";
            ((System.ComponentModel.ISupportInitialize)ptbStar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbStar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbStar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbStar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbStar5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHuy;
        private Button btnSuaThongTin;
        private PictureBox ptbStar1;
        private PictureBox ptbStar2;
        private PictureBox ptbStar3;
        private PictureBox ptbStar4;
        private PictureBox ptbStar5;
        private Label lblDiemDau;
    }
}