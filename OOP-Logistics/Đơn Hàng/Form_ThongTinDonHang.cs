using OOP_Logistics.Khách_Hàng;
using OOP_Logistics.Quản_Trị_Viên;

namespace OOP_Logistics
{
    public partial class Form_ThongTinDonHang : Form
    {
        private readonly DonHang DonDangSua;
        private readonly ChiTietDonHang? ChiTiet;
        private DiaDiem DiemDau, DiemCuoi;

        private void ToggleEditableFields(bool enabled)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox)
                {
                    ctrl.Enabled = enabled;
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

        private void GetHighValueFee()
        {
            if (int.TryParse(txtGiaTriDon.Text, out int giaTriDon))
            {
                if (giaTriDon > 5_000_000)
                {
                    lblPhuThuGiaTriCao.Text = $"{giaTriDon * 0.001:N0}";
                }
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

        private int GetVehicleIndex()
        {
            switch (DonDangSua.LoaiPhuongTien)
            {
                case LoaiXe.XeTai:
                    return 0;
                case LoaiXe.XeBanTai:
                    return 1;
                case LoaiXe.XeMay:
                    return 2;
                default:
                    return -1;
            }
        }

        private void LoadLocations()
        {
            cboDiemDau.Items.AddRange(DiaDiem.GetAddresses().ToArray());
            cboDiemCuoi.Items.AddRange(DiaDiem.GetAddresses().ToArray());
        }

        private void LoadOrderInformation()
        {
            txtMaDon.Text = DonDangSua.MaDonHang.ToString();
            txtMoTaDon.Text = ChiTiet?.MoTaDon;
            txtGiaTriDon.Text = ChiTiet?.GiaTri.ToString();
            cboLoaiHang.SelectedIndex = (int)ChiTiet?.LoaiHang!;
            cboLoaiVanChuyen.SelectedIndex = (int)ChiTiet?.LoaiVanChuyen!;
            txtThoiDiemTaoDon.Text = DonDangSua.ThoiDiemDatHang.ToString();
            txtThoiDiemCapNhat.Text = DonDangSua.CapNhatCuoiCung.ToString();
            cboDiemDau.Text = DiemDau?.Address;
            cboDiemCuoi.Text = DiemCuoi?.Address;
            cboLoaiXe.SelectedIndex = GetVehicleIndex();
        }

        public Form_ThongTinDonHang(DonHang dh)
        {
            InitializeComponent();
            DonDangSua = dh;
            ChiTiet = dh.LayChiTiet();
            DiemDau = ChiTiet?.DiemDau!;
            DiemCuoi = ChiTiet?.DiemCuoi!;
        }

        private void Form_ThongTinDonHang_Load(object sender, EventArgs e)
        {
            LoadLocations();
            LoadOrderInformation();
            GetDistanceFee(DiaDiem.Distance(DiemDau, DiemCuoi));
            GetHighValueFee();
            GetTypeFee();
            GetDeliveryFee();
            GetTotalFee();
            GetTemporaryWarehouse();
            if (DonDangSua.TrangThaiDonHang == TrangThaiDonHang.DaTao)
            {
                btnLuuThongTin.Enabled = true;
                ToggleEditableFields(true);
            }
            else
            {
                btnLuuThongTin.Enabled = false;
                ToggleEditableFields(false);
            }
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
            GetHighValueFee();
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            if (DiaDiem.GetLocation(cboDiemDau.Text) != null && DiaDiem.GetLocation(cboDiemCuoi.Text) != null && !string.IsNullOrWhiteSpace(txtMoTaDon.Text) && !string.IsNullOrWhiteSpace(txtGiaTriDon.Text))
            {
                if (cboLoaiVanChuyen.SelectedIndex == 1)
                {
                    DonDangSua.SuaThongTin(null, GetVehicleType(), int.Parse(lblThanhTien.Text, System.Globalization.NumberStyles.AllowThousands));
                }
                else
                {
                    DonDangSua.SuaThongTin(DiemDau.GetNearestWarehouse(), GetVehicleType(), int.Parse(lblThanhTien.Text, System.Globalization.NumberStyles.AllowThousands));
                }
                ChiTiet?.SuaThongTin(DiemDau, DiemCuoi, txtMoTaDon.Text, int.Parse(txtGiaTriDon.Text), GetTypeProduct(), GetDeliveryType());
                MessageBox.Show("Sửa thông tin thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Có thông tin không hợp lệ.", "Tạo đơn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
