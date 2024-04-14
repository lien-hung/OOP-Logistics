namespace OOP_Logistics
{
    public partial class Form_ChaoMung : Form
    {
        public Form_ChaoMung()
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            new Form_DangNhap().Show();
            Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            new Form_DangKy().Show();
            Close();
        }
    }
}
