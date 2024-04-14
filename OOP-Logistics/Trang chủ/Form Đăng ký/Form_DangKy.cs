namespace OOP_Logistics
{
    public partial class Form_DangKy : Form
    {
        public Form_DangKy()
        {
            InitializeComponent();
        }

        private void btnKhachHang_MouseEnter(object sender, EventArgs e)
        {
            Util.DarkenButtonColor(sender as Button);
        }

        private void btnNhanVien_MouseEnter(object sender, EventArgs e)
        {
            Util.DarkenButtonColor(sender as Button);
        }

        private void btnKhachHang_MouseLeave(object sender, EventArgs e)
        {
            Util.NormalizeButtonColor(sender as Button);
        }

        private void btnNhanVien_MouseLeave(object sender, EventArgs e)
        {
            Util.NormalizeButtonColor(sender as Button);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            new Form_DangKyKhachHang().Show();
            Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            new Form_DangKyNhanVien().Show();
            Close();
        }

        private void lblVeTrangChu_Click(object sender, EventArgs e)
        {
            new Form_ChaoMung().Show();
            Close();
        }
    }
}
