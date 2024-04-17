using OOP_Logistics.Khách_Hàng;
using OOP_Logistics.Nhân_Viên;

namespace OOP_Logistics
{
    public partial class Form_NhanVienLuanChuyen : Form
    {
        private readonly TaiKhoanNV? TaiKhoanHienTai;
        private readonly NhanVienLuanChuyen? NhanVienHienTai;

        private void HideAllPanels()
        {
            panelXepHang.Visible = panelLichSuLuongThuong.Visible = panelThongTin.Visible = false;
        }

        private void ToggleModifyWorkerButton(bool allowed)
        {
            btnSuaThongTin.Enabled = allowed;
            btnLuuThongTin.Enabled = !allowed;
        }

        private void ToggleModifyAccountButton(bool allowed)
        {
            btnSuaTaiKhoan.Enabled = allowed;
            btnLuuTaiKhoan.Enabled = !allowed;
        }

        private void ToggleWorkerInfoTextboxes(bool isOn)
        {
            foreach (Control ctrl in grpThongTinChung.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = isOn;
                }
            }
        }

        private void ToggleAccountInfoTextboxes(bool isOn)
        {
            foreach (Control ctrl in grpThongTinTaiKhoan.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = isOn;
                }
            }
        }

        private void LoadWorkerData()
        {
            ToggleWorkerInfoTextboxes(false);
            txtMaNhanVien.Text = NhanVienHienTai?.ID.ToString();
            txtHoVaTen.Text = NhanVienHienTai?.Name;
            txtSoDienThoai.Text = NhanVienHienTai?.PhoneNumber;
            txtSoCCCD.Text = NhanVienHienTai?.CitizenID;
            txtKhoLamViec.Text = NhanVienHienTai?.KhoLamViec.DiaDiemKho?.Address;
            txtChucVu.Text = NhanVienHienTai?.LayChucVuVaHeSoLuong();
            txtHeSoLuong.Text = NhanVienHienTai?.HeSoLuong.ToString();
            txtLuongThang.Text = NhanVienHienTai?.TinhThuNhap().ToString();
        }

        private void AllowModifyWorkerInfo()
        {
            ToggleModifyWorkerButton(false);
            ToggleWorkerInfoTextboxes(true);
            txtMaNhanVien.Enabled = txtKhoLamViec.Enabled = txtChucVu.Enabled = txtHeSoLuong.Enabled = txtLuongThang.Enabled = false;
        }

        private void ModifyWorkerInfo()
        {
            if (!Util.ExistsEmptyTextbox(grpThongTinChung))
            {
                NhanVienHienTai?.SuaThongTin(Convert.ToInt32(txtMaNhanVien.Text), txtHoVaTen.Text, txtSoDienThoai.Text, txtSoCCCD.Text);
                MessageBox.Show("Sửa thông tin thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToggleModifyWorkerButton(true);
                ToggleWorkerInfoTextboxes(false);
                lblTenNhanVien.Text = NhanVienHienTai?.Name?.ToUpper();
            }
            else
            {
                MessageBox.Show("Không được để thông tin trống!", "Sửa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void LoadAccountData()
        {
            ToggleAccountInfoTextboxes(false);
            txtTenDangNhap.Text = TaiKhoanHienTai?.Username;
            txtMatKhau.Text = txtXacNhanMatKhau.Text = TaiKhoanHienTai?.Password;
        }

        private void AllowModifyAccountInfo()
        {
            ToggleModifyAccountButton(false);
            ToggleAccountInfoTextboxes(true);
        }

        private void ModifyAccountInfo()
        {
            if (!Util.ExistsEmptyTextbox(grpThongTinTaiKhoan) && txtMatKhau.Text == txtXacNhanMatKhau.Text)
            {
                TaiKhoanHienTai?.ModifyAccount(txtTenDangNhap.Text, txtMatKhau.Text);
                MessageBox.Show("Sửa tài khoản thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToggleModifyAccountButton(true);
                ToggleAccountInfoTextboxes(false);
            }
            else if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng!", "Sửa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Không được để thông tin trống!", "Sửa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void RefreshPanelCreatePackage()
        {
            txtMaBuuKien.Text = BuuKien.MaTiepTheo().ToString();
            txtKhoiLuong.Text = string.Empty;
            dgvTaoBuuKien.DataSource = new List<DonHang>(DonHang.LayDonLuuChuaXep(NhanVienHienTai!.KhoLamViec));
        }

        public Form_NhanVienLuanChuyen(TaiKhoanNV? tk)
        {
            InitializeComponent();
            TaiKhoanHienTai = tk;
            NhanVienHienTai = tk?.GetEmployee() as NhanVienLuanChuyen;
        }

        private void Form_NhanVienLuanChuyen_Load(object sender, EventArgs e)
        {
            HideAllPanels();
            panelThongTin.Visible = true;
            lblTenNhanVien.Text = NhanVienHienTai?.Name?.ToUpper();
            LoadWorkerData();
            LoadAccountData();
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

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            AllowModifyWorkerInfo();
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            ModifyWorkerInfo();
        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            AllowModifyAccountInfo();
        }

        private void btnLuuTaiKhoan_Click(object sender, EventArgs e)
        {
            ModifyAccountInfo();
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Data.DanhSachTaiKhoan?.Remove(TaiKhoanHienTai!);
                Data.DanhSachNhanVien?.Remove(NhanVienHienTai!);
                new Form_ChaoMung().Show();
                Close();
            }
        }

        private void panelNhanVien_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelThongTin.Visible = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            new Form_ChaoMung().Show();
            Close();
        }

        private void btnXepHang_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelXepHang.Visible = true;
            RefreshPanelCreatePackage();
        }

        private void btnTaoBuuKien_Click(object sender, EventArgs e)
        {
            if (dgvTaoBuuKien.SelectedRows.Count > 0 && double.TryParse(txtKhoiLuong.Text, out double khoiLuong))
            {
                List<DonHang> donHangSeXep = [];
                for (int i = 0; i < dgvTaoBuuKien.SelectedRows.Count; i++)
                {
                    if (dgvTaoBuuKien.SelectedRows[i].DataBoundItem is DonHang donDaChon)
                    {
                        donDaChon.XepVaoBuuKien(Convert.ToInt32(txtMaBuuKien.Text));
                        donHangSeXep.Add(donDaChon);
                    }
                    else
                    {
                        MessageBox.Show("Đơn không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Data.DanhSachBuuKien?.Add(new BuuKien(Convert.ToInt32(txtMaBuuKien.Text), donHangSeXep, khoiLuong));
                RefreshPanelCreatePackage();
            }
            else
            {
                MessageBox.Show("Tạo đơn hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLichSuLuongThuong_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelLichSuLuongThuong.Visible = true;
            dgvLichSuLuongThuong.DataSource = new List<LichSuLuongThuong>(NhanVienHienTai!.LayLichSuLuong());
        }
    }
}
