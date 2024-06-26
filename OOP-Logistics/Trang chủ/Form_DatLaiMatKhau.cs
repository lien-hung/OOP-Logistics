﻿namespace OOP_Logistics
{
    public partial class Form_DatLaiMatKhau : Form
    {
        public Form_DatLaiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDatLai_MouseEnter(object sender, EventArgs e)
        {
            Util.DarkenButtonColor(sender as Button);
        }

        private void btnHuy_MouseEnter(object sender, EventArgs e)
        {
            Util.DarkenButtonColor(sender as Button);
        }

        private void btnDatLai_MouseLeave(object sender, EventArgs e)
        {
            Util.NormalizeButtonColor(sender as Button);
        }

        private void btnHuy_MouseLeave(object sender, EventArgs e)
        {
            Util.NormalizeButtonColor(sender as Button);
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            TaiKhoan? tk = TaiKhoan.SearchByUsername(txtTenDangNhap.Text);
            if (tk != null && txtMatKhauMoi.Text == txtXacNhanMatKhau.Text)
            {
                tk.ChangePassword(txtMatKhauMoi.Text);
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại hoặc xác nhận mật khẩu không đúng.", "Đặt lại thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            new Form_DangNhap().Show();
            Close();
        }
    }
}
