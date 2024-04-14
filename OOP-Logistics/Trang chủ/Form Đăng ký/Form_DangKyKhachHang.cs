namespace OOP_Logistics
{
    public partial class Form_DangKyKhachHang : Form
    {
        private void ToggleBusinessRegister(bool isOn)
        {
            txtTenCongTy.Enabled = txtLinhVuc.Enabled = isOn;
        }

        public Form_DangKyKhachHang()
        {
            InitializeComponent();
        }

        private void Form_DangKyKhachHang_Load(object sender, EventArgs e)
        {
            cboLoaiKhachHang.SelectedIndex = 0;
            ToggleBusinessRegister(false);
        }

        private void cboLoaiKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiKhachHang.SelectedIndex == 0)
            {
                ToggleBusinessRegister(false);
            }
            if (cboLoaiKhachHang.SelectedIndex == 1)
            {
                ToggleBusinessRegister(true);
            }
        }

        private void btnHuy_MouseEnter(object sender, EventArgs e)
        {
            Util.DarkenButtonColor(sender as Button);
        }

        private void btnDangKy_MouseEnter(object sender, EventArgs e)
        {
            Util.DarkenButtonColor(sender as Button);
        }

        private void btnHuy_MouseLeave(object sender, EventArgs e)
        {
            Util.NormalizeButtonColor(sender as Button);
        }

        private void btnDangKy_MouseLeave(object sender, EventArgs e)
        {
            Util.NormalizeButtonColor(sender as Button);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            new Form_DangKy().Show();
            Close();
        }
    }
}
