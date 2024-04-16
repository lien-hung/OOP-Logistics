using OOP_Logistics.Khách_Hàng;

namespace OOP_Logistics
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_MouseEnter(object sender, EventArgs e)
        {
            Util.DarkenButtonColor(sender as Button);
        }

        private void btnDangKy_MouseEnter(object sender, EventArgs e)
        {
            Util.DarkenButtonColor(sender as Button);
        }

        private void btnDangNhap_MouseLeave(object sender, EventArgs e)
        {
            Util.NormalizeButtonColor(sender as Button);
        }

        private void btnDangKy_MouseLeave(object sender, EventArgs e)
        {
            Util.NormalizeButtonColor(sender as Button);
        }

        private void lblVeTrangChu_Click(object sender, EventArgs e)
        {
            new Form_ChaoMung().Show();
            Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            new Form_DangKy().Show();
            Close();
        }

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            new Form_DatLaiMatKhau().Show();
            Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan? tk = TaiKhoan.SearchByUsername(txtTenDangNhap.Text);
            if (tk != null && tk.Login(txtTenDangNhap.Text, txtMatKhau.Text))
            {
                if (tk is TaiKhoanKH)
                {
                    new Form_KhachHang(tk as TaiKhoanKH).Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
