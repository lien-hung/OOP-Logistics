using OOP_Logistics.Khách_Hàng;
using OOP_Logistics.Nhân_Viên;

namespace OOP_Logistics
{
    public partial class Form_TaiXe : Form
    {
        private readonly TaiKhoanNV? TaiKhoanHienTai;
        private readonly TaiXeCoHuu? TaiXeHienTai;

        private void HideAllPanels()
        {
            panelNhanDon.Visible = panelLichSuGiaoHang.Visible = panelThongTin.Visible = false;
        }

        private void ToggleModifyDriverButton(bool allowed)
        {
            btnSuaThongTin.Enabled = allowed;
            btnLuuThongTin.Enabled = !allowed;
        }

        private void ToggleModifyAccountButton(bool allowed)
        {
            btnSuaTaiKhoan.Enabled = allowed;
            btnLuuTaiKhoan.Enabled = !allowed;
        }

        private void ToggleDriverInfoTextboxes(bool isOn)
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

        private void LoadDriverData()
        {
            ToggleDriverInfoTextboxes(false);
            txtMaTaiXe.Text = TaiXeHienTai?.ID.ToString();
            txtHoVaTen.Text = TaiXeHienTai?.Name;
            txtSoDienThoai.Text = TaiXeHienTai?.PhoneNumber;
            txtSoCCCD.Text = TaiXeHienTai?.CitizenID;
            txtPhuongTien.Text = TaiXeHienTai?.PhuongTienGiaoHang?.LayLoaiXe();
            txtBienSo.Text = TaiXeHienTai?.PhuongTienGiaoHang?.BienSoXe;
        }

        private void AllowModifyDriverInfo()
        {
            ToggleModifyDriverButton(false);
            ToggleDriverInfoTextboxes(true);
            txtMaTaiXe.Enabled = txtPhuongTien.Enabled = false;
        }

        private void ModifyDriverInfo()
        {
            if (!Util.ExistsEmptyTextbox(grpThongTinChung))
            {
                TaiXeHienTai?.SuaThongTin(Convert.ToInt32(txtMaTaiXe.Text), txtHoVaTen.Text, txtSoDienThoai.Text, txtSoCCCD.Text);
                TaiXeHienTai?.PhuongTienGiaoHang?.SuaThongTin(txtBienSo.Text);
                MessageBox.Show("Sửa thông tin thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToggleModifyDriverButton(true);
                ToggleDriverInfoTextboxes(false);
                lblTenTaiXe.Text = TaiXeHienTai?.Name?.ToUpper();
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

        public void ResetDeliveryHistory()
        {
            dgvLichSuGiaoHang.DataSource = new List<DonHang>(TaiXeHienTai?.LayDonHangDaNhan()!);
            lblTongThuNhap.Text = $"{TaiXeHienTai?.LayTongThuNhap():N0}";
            lblDiemDanhGia.Text = $"{TaiXeHienTai?.LayDiemDanhGia():N2}";
        }

        public Form_TaiXe(TaiKhoanNV? tk)
        {
            InitializeComponent();
            TaiKhoanHienTai = tk;
            TaiXeHienTai = tk?.GetEmployee() as TaiXeCoHuu;
        }

        private void Form_TaiXe_Load(object sender, EventArgs e)
        {
            HideAllPanels();
            panelThongTin.Visible = true;
            lblTenTaiXe.Text = TaiXeHienTai?.Name?.ToUpper();
            LoadDriverData();
            LoadAccountData();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            AllowModifyDriverInfo();
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            ModifyDriverInfo();
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
                Data.DanhSachNhanVien?.Remove(TaiXeHienTai!);
                new Form_ChaoMung().Show();
                Close();
            }
        }

        private void panelTaiXe_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelThongTin.Visible = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            new Form_ChaoMung().Show();
            Close();
        }

        private void btnNhanDon_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelNhanDon.Visible = true;
            dgvNhanDon.DataSource = new List<BuuKien>(BuuKien.LayBuuKienChoNhan());
        }

        private void btnNhanGiao_Click(object sender, EventArgs e)
        {
            if (dgvNhanDon.SelectedRows.Count > 0)
            {
                if (dgvNhanDon.SelectedRows[0].DataBoundItem is BuuKien buuKienDaChon)
                {
                    if (buuKienDaChon.DanhSachDon?[0].LoaiPhuongTien == TaiXeHienTai?.PhuongTienGiaoHang?.LoaiXe && buuKienDaChon.KhoiLuong <= TaiXeHienTai?.PhuongTienGiaoHang?.TaiTrong)
                    {
                        buuKienDaChon.NhanBuuKien(TaiXeHienTai);
                        foreach (DonHang dh in buuKienDaChon.DanhSachDon!)
                        {
                            dh.NhanDon();
                        }
                        MessageBox.Show("Nhận bưu kiện thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvNhanDon.DataSource = new List<BuuKien>(BuuKien.LayBuuKienChoNhan());
                    }
                    else if (buuKienDaChon.DanhSachDon?[0].LoaiPhuongTien != TaiXeHienTai?.PhuongTienGiaoHang?.LoaiXe)
                    {
                        MessageBox.Show("Loại xe của bạn không khớp với loại phương tiện mà bưu kiện được chuyên chở.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Khối lượng bưu kiện vượt quá tải trọng cho phép.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Bưu kiện không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có bưu kiện nào được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLichSuGiaoHang_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelLichSuGiaoHang.Visible = true;
            ResetDeliveryHistory();
        }

        private void btnDanhDauDaGiao_Click(object sender, EventArgs e)
        {
            if (dgvLichSuGiaoHang.SelectedRows.Count > 0)
            {
                if (dgvLichSuGiaoHang.SelectedRows[0].DataBoundItem is DonHang donDaChon)
                {
                    donDaChon.DanhDauGiaoThanhCong();
                    ResetDeliveryHistory();
                    MessageBox.Show($"Giao thành công! Bạn đã được cộng thêm {donDaChon.CuocPhi:N0} vào thu nhập.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đơn hàng không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có đơn hàng nào được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
