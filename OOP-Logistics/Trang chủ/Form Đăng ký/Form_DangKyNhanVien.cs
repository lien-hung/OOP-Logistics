using OOP_Logistics.Nhân_Viên;
using OOP_Logistics.Quản_Trị_Viên;

namespace OOP_Logistics
{
    public partial class Form_DangKyNhanVien : Form
    {
        private void ToggleRegisterWarehouse(bool isOn)
        {
            cboNoiLamViec.Enabled = isOn;
            cboLoaiXe.Enabled = txtBienSo.Enabled = !isOn;
            if (isOn)
            {
                txtBienSo.Text = "N/A";
            }
            else
            {
                txtBienSo.Text = string.Empty;
            }
        }

        private LoaiXe ChosenVehicleType()
        {
            if (cboLoaiXe.SelectedIndex == 0)
            {
                return LoaiXe.XeTai;
            }
            if (cboLoaiXe.SelectedIndex == 1)
            {
                return LoaiXe.XeBanTai;
            }
            return LoaiXe.XeMay;
        }

        public Form_DangKyNhanVien()
        {
            InitializeComponent();
        }

        private void Form_DangKyNhanVien_Load(object sender, EventArgs e)
        {
            cboLoaiNhanVien.SelectedIndex = cboNoiLamViec.SelectedIndex = cboLoaiXe.SelectedIndex = 0;
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
            if (!Util.ExistsEmptyTextbox(this) && txtMatKhau.Text == txtXacNhanMatKhau.Text && TaiKhoan.SearchByUsername(txtTenDangNhap.Text) == null)
            {
                int newEmployeeId = NhanVien.MaTiepTheo();
                if (cboLoaiNhanVien.SelectedIndex == 0)
                {
                    Data.DanhSachNhanVien?.Add(new NhanVienLuanChuyen(newEmployeeId, txtHoVaTen.Text, txtSoDienThoai.Text, txtSoCCCD.Text, ChucVu.NhanVienThuong, Data.DanhSachKhoGiaoNhan![cboNoiLamViec.SelectedIndex], 2));
                }
                if (cboLoaiNhanVien.SelectedIndex == 1)
                {
                    PhuongTien vehicle = new(txtBienSo.Text, ChosenVehicleType(), TinhTrangXe.OnDinh);
                    Data.DanhSachPhuongTien?.Add(vehicle);
                    Data.DanhSachNhanVien?.Add(new TaiXeCoHuu(newEmployeeId, txtHoVaTen.Text, txtSoDienThoai.Text, txtSoCCCD.Text, vehicle));
                }
                Data.DanhSachTaiKhoan?.Add(new TaiKhoanNV(newEmployeeId, txtTenDangNhap.Text, txtMatKhau.Text));
                MessageBox.Show("Đăng ký tài khoản thành công.", "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Form_ChaoMung().Show();
                Close();
            }
            else if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng!", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
