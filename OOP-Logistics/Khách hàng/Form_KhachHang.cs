using OOP_Logistics.Khách_Hàng;
using OOP_Logistics.Quản_Trị_Viên;

namespace OOP_Logistics
{
    public partial class Form_KhachHang : Form
    {
        private readonly TaiKhoanKH? TaiKhoanHienTai;
        private readonly KhachHang? KhachHangHienTai;
        private DiaDiem DiemDau, DiemCuoi;

        private void HideAllPanels()
        {
            panelDatHang.Visible = panelLichSuDatHang.Visible = panelThongTin.Visible = false;
        }

        private void ToggleModifyCustomerButton(bool allowed)
        {
            btnSuaThongTin.Enabled = allowed;
            btnLuuThongTin.Enabled = !allowed;
        }

        private void ToggleModifyAccountButton(bool allowed)
        {
            btnSuaTaiKhoan.Enabled = allowed;
            btnLuuTaiKhoan.Enabled = !allowed;
        }

        private void ToggleCustomerInfoTextboxes(bool isOn)
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

        private void GetDistanceFee(double distance)
        {
            lblKhoangCach.Text = $"{distance:N3} km";
            switch (cboLoaiXe.SelectedIndex)
            {
                case 0:
                    lblCuocCoSo.Text = $"{(distance > 2 ? 180000 + (distance - 2) * 30000 : 180000):N0}";
                    break;
                case 1:
                    lblCuocCoSo.Text = $"{(distance > 2 ? 75000 + (distance - 2) * 12000 : 75000):N0}";
                    break;
                case 2:
                    lblCuocCoSo.Text = $"{(distance > 2 ? 20000 + (distance - 2) * 4000 : 20000):N0}";
                    break;
            }
        }

        private void GetTypeFee()
        {
            switch (cboLoaiHang.SelectedIndex)
            {
                case 1:
                    lblPhuThuHangDacBiet.Text = $"{5000:N0}";
                    break;
                case 2:
                    lblPhuThuHangDacBiet.Text = $"{20000:N0}";
                    break;
                case 3:
                    lblPhuThuHangDacBiet.Text = $"{30000:N0}";
                    break;
                case 4:
                    lblPhuThuHangDacBiet.Text = $"{10000:N0}";
                    break;
                default:
                    lblPhuThuHangDacBiet.Text = $"{0:N0}";
                    break;
            }
        }

        private void GetDeliveryFee()
        {
            int cuocCoSo = int.Parse(lblCuocCoSo.Text, System.Globalization.NumberStyles.AllowThousands);
            int phuThuGiaTriCao = int.Parse(lblPhuThuGiaTriCao.Text, System.Globalization.NumberStyles.AllowThousands);
            int phuThuHangDacBiet = int.Parse(lblPhuThuHangDacBiet.Text, System.Globalization.NumberStyles.AllowThousands);
            switch (cboLoaiVanChuyen.SelectedIndex)
            {
                case 1:
                    lblPhuThuVanChuyen.Text = $"{(cuocCoSo + phuThuGiaTriCao + phuThuHangDacBiet) * 0.4:N0}";
                    break;
                case 2:
                    lblPhuThuVanChuyen.Text = $"{(cuocCoSo + phuThuGiaTriCao + phuThuHangDacBiet) * -0.25:N0}";
                    break;
                default:
                    lblPhuThuVanChuyen.Text = $"{0:N0}";
                    break;
            }
        }

        private void GetTotalFee()
        {
            int cuocCoSo = int.Parse(lblCuocCoSo.Text, System.Globalization.NumberStyles.AllowThousands);
            int phuThuVanChuyen = int.Parse(lblPhuThuVanChuyen.Text, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowLeadingSign);
            int phuThuGiaTriCao = int.Parse(lblPhuThuGiaTriCao.Text, System.Globalization.NumberStyles.AllowThousands);
            int phuThuHangDacBiet = int.Parse(lblPhuThuHangDacBiet.Text, System.Globalization.NumberStyles.AllowThousands);
            lblThanhTien.Text = $"{cuocCoSo + phuThuVanChuyen + phuThuGiaTriCao + phuThuHangDacBiet:N0}";
        }

        private void GetTemporaryWarehouse()
        {
            if (cboLoaiVanChuyen.SelectedIndex == 1)
            {
                lblKhoLuuTam.Text = "Không lưu kho";
            }
            else
            {
                lblKhoLuuTam.Text = DiemDau.GetNearestWarehouse().DiaDiemKho?.Address;
            }
        }

        private LoaiHang GetTypeProduct()
        {
            switch (cboLoaiHang.SelectedIndex)
            {
                case 1:
                    return LoaiHang.ChungNhanHoSo;
                case 2:
                    return LoaiHang.HangDeVo;
                case 3:
                    return LoaiHang.HangNguyenKhoiQuaKho;
                case 4:
                    return LoaiHang.ChatLong;
                default:
                    return LoaiHang.KhongCo;
            }
        }

        private LoaiVanChuyen GetDeliveryType()
        {
            switch (cboLoaiVanChuyen.SelectedIndex)
            {
                case 1:
                    return LoaiVanChuyen.HoaToc;
                case 2:
                    return LoaiVanChuyen.TietKiem;
                default:
                    return LoaiVanChuyen.Thuong;
            }
        }

        private LoaiXe GetVehicleType()
        {
            switch (cboLoaiXe.SelectedIndex)
            {
                case 1:
                    return LoaiXe.XeBanTai;
                case 2:
                    return LoaiXe.XeMay;
                default:
                    return LoaiXe.XeTai;
            }
        }

        private void LoadLocations()
        {
            cboDiemDau.Items.AddRange(DiaDiem.GetAddresses().ToArray());
            cboDiemCuoi.Items.AddRange(DiaDiem.GetAddresses().ToArray());
        }

        private void LoadCustomerData()
        {
            ToggleCustomerInfoTextboxes(false);
            txtMaKhachHang.Text = KhachHangHienTai?.ID.ToString();
            txtHoVaTen.Text = KhachHangHienTai?.Name;
            txtSoDienThoai.Text = KhachHangHienTai?.PhoneNumber;
            txtSoCCCD.Text = KhachHangHienTai?.CitizenID;
            if (KhachHangHienTai is KhachHangCaNhan khcn)
            {
                txtEmail.Text = khcn.EmailCaNhan;
                txtDiaChi.Text = khcn.DiaChiLienLac;
                txtTenCongTy.Text = txtLinhVuc.Text = "N/A";
            }
            if (KhachHangHienTai is KhachHangDoanhNghiep khdn)
            {
                txtEmail.Text = khdn.EmailCongTy;
                txtDiaChi.Text = khdn.NoiDongTruSo;
                txtTenCongTy.Text = khdn.TenCongTy;
                txtLinhVuc.Text = khdn.LinhVucHoatDong;
            }
        }

        private void AllowModifyCustomerInfo()
        {
            ToggleModifyCustomerButton(false);
            ToggleCustomerInfoTextboxes(true);
            txtMaKhachHang.Enabled = false;
            if (KhachHangHienTai is KhachHangCaNhan)
            {
                txtTenCongTy.Enabled = txtLinhVuc.Enabled = false;
            }
        }

        private void ModifyCustomerInfo()
        {
            if (!Util.ExistsEmptyTextbox(grpThongTinChung) && txtEmail.Text.Contains('@'))
            {
                if (KhachHangHienTai is KhachHangCaNhan khcn)
                {
                    khcn.SuaThongTin(Convert.ToInt32(txtMaKhachHang.Text), txtHoVaTen.Text, txtSoDienThoai.Text, txtSoCCCD.Text, txtEmail.Text, txtDiaChi.Text);
                }
                if (KhachHangHienTai is KhachHangDoanhNghiep khdn)
                {
                    khdn.SuaThongTin(Convert.ToInt32(txtMaKhachHang.Text), txtHoVaTen.Text, txtSoDienThoai.Text, txtSoCCCD.Text, txtTenCongTy.Text, txtLinhVuc.Text, txtDiaChi.Text, txtEmail.Text);
                }
                MessageBox.Show("Sửa thông tin thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ToggleModifyCustomerButton(true);
                ToggleCustomerInfoTextboxes(false);
                lblTenKhachHang.Text = KhachHangHienTai?.Name?.ToUpper();
            }
            else if (!txtEmail.Text.Contains('@'))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ!", "Sửa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void CreateOrder()
        {
            if (DiaDiem.GetLocation(cboDiemDau.Text) != null && DiaDiem.GetLocation(cboDiemCuoi.Text) != null && !string.IsNullOrWhiteSpace(txtMoTaDon.Text) && !string.IsNullOrWhiteSpace(txtGiaTriDon.Text))
            {
                int nextOrderId = DonHang.MaTiepTheo();
                if (cboLoaiVanChuyen.SelectedIndex == 1)
                {
                    Data.DanhSachDonHang?.Add(new DonHang(nextOrderId, KhachHangHienTai!.ID, null, GetVehicleType(), int.Parse(lblThanhTien.Text, System.Globalization.NumberStyles.AllowThousands)));
                }
                else
                {
                    Data.DanhSachDonHang?.Add(new DonHang(nextOrderId, KhachHangHienTai!.ID, DiemDau.GetNearestWarehouse(), GetVehicleType(), int.Parse(lblThanhTien.Text, System.Globalization.NumberStyles.AllowThousands)));
                }
                Data.DanhSachChiTietDon?.Add(new ChiTietDonHang(nextOrderId, DiemDau, DiemCuoi, txtMoTaDon.Text, int.Parse(txtGiaTriDon.Text), GetTypeProduct(), GetDeliveryType()));
                MessageBox.Show("Tạo đơn thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            else
            {
                MessageBox.Show("Có thông tin không hợp lệ.", "Tạo đơn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            cboDiemDau.Text = cboDiemCuoi.Text = txtMoTaDon.Text = txtGiaTriDon.Text = lblKhoLuuTam.Text = string.Empty;
            cboLoaiHang.SelectedIndex = cboLoaiVanChuyen.SelectedIndex = 0;
            lblKhoangCach.Text = "0 km";
            lblCuocCoSo.Text = lblPhuThuGiaTriCao.Text = lblPhuThuHangDacBiet.Text = lblPhuThuVanChuyen.Text = lblThanhTien.Text = "0";
        }

        public Form_KhachHang(TaiKhoanKH? tk)
        {
            InitializeComponent();
            TaiKhoanHienTai = tk;
            KhachHangHienTai = tk?.GetCustomer();
            DiemDau = DiemCuoi = Data.DanhSachKhoGiaoNhan?[0].DiaDiemKho!;
        }

        private void Form_KhachHang_Load(object sender, EventArgs e)
        {
            HideAllPanels();
            panelThongTin.Visible = true;
            lblTenKhachHang.Text = KhachHangHienTai?.Name?.ToUpper();
            LoadCustomerData();
            LoadAccountData();
            LoadLocations();
            cboLoaiHang.SelectedIndex = cboLoaiVanChuyen.SelectedIndex = 0;
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
            AllowModifyCustomerInfo();
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            ModifyCustomerInfo();
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
                Data.DanhSachKhachHang?.Remove(KhachHangHienTai!);
                new Form_ChaoMung().Show();
                Close();
            }
        }

        private void panelKhachHang_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelThongTin.Visible = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            new Form_ChaoMung().Show();
            Close();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelDatHang.Visible = true;
        }

        private void cboDiemDau_Leave(object sender, EventArgs e)
        {
            if (DiaDiem.GetLocation(cboDiemDau.Text) != null)
            {
                DiemDau = DiaDiem.GetLocation(cboDiemDau.Text)!;
            }
            GetDistanceFee(DiaDiem.Distance(DiemDau, DiemCuoi));
            GetDeliveryFee();
            GetTotalFee();
            GetTemporaryWarehouse();
        }

        private void cboDiemCuoi_Leave(object sender, EventArgs e)
        {
            if (DiaDiem.GetLocation(cboDiemCuoi.Text) != null)
            {
                DiemCuoi = DiaDiem.GetLocation(cboDiemCuoi.Text)!;
            }
            GetDistanceFee(DiaDiem.Distance(DiemDau, DiemCuoi));
            GetDeliveryFee();
            GetTotalFee();
        }

        private void txtGiaTriDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaTriDon_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtGiaTriDon.Text, out int giaTriDon))
            {
                if (giaTriDon > 5_000_000)
                {
                    lblPhuThuGiaTriCao.Text = $"{giaTriDon * 0.001:N0}";
                }
            }
            GetDeliveryFee();
            GetTotalFee();
        }

        private void cboLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTypeFee();
            GetDeliveryFee();
            GetTotalFee();
        }

        private void cboLoaiVanChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDeliveryFee();
            GetTotalFee();
            GetTemporaryWarehouse();
        }

        private void cboLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDistanceFee(DiaDiem.Distance(DiemDau, DiemCuoi));
            GetDeliveryFee();
            GetTotalFee();
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            CreateOrder();
        }

        private void btnLichSuDatHang_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelLichSuDatHang.Visible = true;
            dgvLichSuDatHang.DataSource = new List<DonHang>(KhachHangHienTai?.LayLichSuDatHang()!);
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            if (dgvLichSuDatHang.SelectedRows.Count > 0)
            {
                if (dgvLichSuDatHang.SelectedRows[0].DataBoundItem is DonHang donDaChon && donDaChon.TrangThaiDonHang == TrangThaiDonHang.GiaoThanhCong)
                {
                    if (donDaChon.DanhGia == 0)
                    {
                        new Form_DanhGiaDonHang(donDaChon).Show();
                    }
                    else
                    {
                        MessageBox.Show("Đã đánh giá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Đơn không tồn tại hoặc chưa giao.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn đơn hàng nào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaDonHang_Click(object sender, EventArgs e)
        {
            if (dgvLichSuDatHang.SelectedRows.Count > 0)
            {
                if (dgvLichSuDatHang.SelectedRows[0].DataBoundItem is DonHang donDaChon)
                {
                    new Form_ThongTinDonHang(donDaChon).Show();
                    dgvLichSuDatHang.DataSource = new List<DonHang>(KhachHangHienTai?.LayLichSuDatHang()!);
                }
                else
                {
                    MessageBox.Show("Đơn không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn đơn hàng nào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (dgvLichSuDatHang.SelectedRows.Count > 0)
            {
                if (dgvLichSuDatHang.SelectedRows[0].DataBoundItem is DonHang donDaChon)
                {
                    if (donDaChon.TrangThaiDonHang == TrangThaiDonHang.DaTao)
                    {
                        Data.DanhSachDonHang?.Remove(donDaChon);
                        Data.DanhSachChiTietDon?.Remove(donDaChon.LayChiTiet());
                        MessageBox.Show("Hủy đơn thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvLichSuDatHang.DataSource = new List<DonHang>(KhachHangHienTai?.LayLichSuDatHang()!);
                    }
                    else
                    {
                        MessageBox.Show("Không thể hủy đơn đang xử lý hoặc đã giao.", "Hủy đơn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Đơn không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn đơn hàng nào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
