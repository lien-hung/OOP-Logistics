using OOP_Logistics.Khách_Hàng;

namespace OOP_Logistics
{
    public partial class Form_DangKyKhachHang : Form
    {
        private void ToggleBusinessRegister(bool isOn)
        {
            txtTenCongTy.Enabled = txtLinhVuc.Enabled = isOn;
            if (!isOn)
            {
                txtTenCongTy.Text = txtLinhVuc.Text = "N/A";
            }
            else
            {
                txtTenCongTy.Text = txtLinhVuc.Text = string.Empty;
            }
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

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!Util.ExistsEmptyTextbox(this) && txtEmail.Text.Contains('@') && txtMatKhau.Text == txtXacNhanMatKhau.Text && TaiKhoan.SearchByUsername(txtTenDangNhap.Text) == null)
            {
                int newCustomerId = KhachHang.MaTiepTheo();
                if (cboLoaiKhachHang.SelectedIndex == 0)
                {
                    Data.DanhSachKhachHang?.Add(new KhachHangCaNhan(newCustomerId, txtHoVaTen.Text, txtSoDienThoai.Text, txtSoCCCD.Text, txtEmail.Text, txtDiaChi.Text));
                }
                if (cboLoaiKhachHang.SelectedIndex == 1)
                {
                    Data.DanhSachKhachHang?.Add(new KhachHangDoanhNghiep(newCustomerId, txtHoVaTen.Text, txtSoDienThoai.Text, txtSoCCCD.Text, txtTenCongTy.Text, txtLinhVuc.Text, txtDiaChi.Text, txtEmail.Text));
                }
                Data.DanhSachTaiKhoan?.Add(new TaiKhoanKH(newCustomerId, txtTenDangNhap.Text, txtMatKhau.Text));
                MessageBox.Show("Đăng ký tài khoản thành công.", "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Form_ChaoMung().Show();
                Close();
            }
            else if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng!", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!txtEmail.Text.Contains('@'))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (TaiKhoan.SearchByUsername(txtTenDangNhap.Text) != null)
            {
                MessageBox.Show("Tên tài khoản đã được sử dụng. Vui lòng chọn tên khác.", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Không được để thông tin trống!", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
