namespace OOP_Logistics
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {
            cboLoaiTaiKhoan.SelectedIndex = 0;
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
    }
}
