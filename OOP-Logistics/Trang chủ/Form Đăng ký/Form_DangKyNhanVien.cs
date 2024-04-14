namespace OOP_Logistics
{
    public partial class Form_DangKyNhanVien : Form
    {
        private void ToggleRegisterWarehouse(bool isOn)
        {
            cboNoiLamViec.Enabled = isOn;
            cboLoaiXe.Enabled = txtBienSo.Enabled = !isOn;
        }

        public Form_DangKyNhanVien()
        {
            InitializeComponent();
        }

        private void Form_DangKyNhanVien_Load(object sender, EventArgs e)
        {
            cboLoaiNhanVien.SelectedIndex = 0;
            ToggleRegisterWarehouse(true);
        }

        private void cboLoaiNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiNhanVien.SelectedIndex == 0)
            {
                ToggleRegisterWarehouse(true);
                cboNoiLamViec.SelectedIndex = 0;
            }
            if (cboLoaiNhanVien.SelectedIndex == 1)
            {
                ToggleRegisterWarehouse(false);
                cboLoaiXe.SelectedIndex = 0;
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
