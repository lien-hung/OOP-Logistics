using OOP_Logistics.Khách_Hàng;
using OOP_Logistics.Nhân_Viên;
using OOP_Logistics.Quản_Trị_Viên;
using System.Text.RegularExpressions;

namespace OOP_Logistics
{
    public partial class Form_QuanTriVien : Form
    {
        private readonly TaiKhoanQuanTriVien? TaiKhoanHienTai;
        private readonly List<IHuman> DanhSachNhanSu;
        private void HideAllPanels()
        {
            panelTimKiem.Visible = panelPhuongTien.Visible = panelThongKe.Visible = panelThongTin.Visible = false;
        }

        private void ToggleModifyAccountButton(bool allowed)
        {
            btnSuaTaiKhoan.Enabled = allowed;
            btnLuuTaiKhoan.Enabled = !allowed;
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

        private int TinhTongCuocPhi()
        {
            int sum = 0;
            foreach (DonHang dh in Data.DanhSachDonHang!)
            {
                if (dh.TrangThaiDonHang == TrangThaiDonHang.GiaoThanhCong)
                {
                    sum += dh.CuocPhi;
                }
            }
            return sum;
        }

        private int DemSoDonThanhCong()
        {
            int count = 0;
            foreach (DonHang dh in Data.DanhSachDonHang!)
            {
                if (dh.TrangThaiDonHang == TrangThaiDonHang.GiaoThanhCong)
                {
                    count++;
                }
            }
            return count;
        }

        private int DemSoTaiXe()
        {
            int count = 0;
            foreach (NhanVien nv in Data.DanhSachNhanVien!)
            {
                if (nv is TaiXeCoHuu)
                {
                    count++;
                }
            }
            return count;
        }

        private double LayTongDanhGia()
        {
            double tongDanhGia = 0;
            foreach (NhanVien nv in Data.DanhSachNhanVien!)
            {
                if (nv is TaiXeCoHuu)
                {
                    TaiXeCoHuu? taiXe = nv as TaiXeCoHuu;
                    tongDanhGia += taiXe!.LayDiemDanhGia();
                }
            }
            return tongDanhGia;
        }

        private List<IHuman> InititalizeHumanList()
        {
            List<IHuman> danhSachNhanSu = [];
            danhSachNhanSu.AddRange(Data.DanhSachKhachHang?.Cast<IHuman>().ToList()!);
            danhSachNhanSu.AddRange(Data.DanhSachNhanVien?.Cast<IHuman>().ToList()!);
            return danhSachNhanSu;
        }

        private IEnumerable<IHuman> SearchHumanByName()
        {
            string keyword = txtTuKhoa.Text;
            List<IHuman> allRecords = InititalizeHumanList();
            if (allRecords != null)
            {
                if (keyword.Contains('?') || keyword.Contains('*'))
                {
                    string pattern = "^" + Regex.Escape(keyword).Replace("\\?", ".").Replace("\\*", ".*") + "$";
                    foreach (IHuman record in allRecords)
                    {
                        if (Regex.IsMatch(record.Name!, pattern, RegexOptions.IgnoreCase))
                        {
                            yield return record;
                        }
                    }
                }
                else
                {
                    foreach (IHuman record in allRecords)
                    {
                        if (record.Name!.Contains(keyword))
                        {
                            yield return record;
                        }
                    }
                }
            }
        }

        private IEnumerable<PhuongTien> SearchVehicleByPlate()
        {
            string keyword = txtTuKhoa.Text;
            List<PhuongTien>? allRecords = Data.DanhSachPhuongTien;
            if (allRecords != null)
            {
                if (keyword.Contains('?') || keyword.Contains('*'))
                {
                    string pattern = "^" + Regex.Escape(keyword).Replace("\\?", ".").Replace("\\*", ".*") + "$";
                    foreach (PhuongTien record in allRecords)
                    {
                        if (Regex.IsMatch(record.BienSoXe!, pattern, RegexOptions.IgnoreCase))
                        {
                            yield return record;
                        }
                    }
                }
                else
                {
                    foreach (PhuongTien record in allRecords)
                    {
                        if (record.BienSoXe!.Contains(keyword))
                        {
                            yield return record;
                        }
                    }
                }
            }
        }

        public Form_QuanTriVien(TaiKhoanQuanTriVien tk)
        {
            InitializeComponent();
            TaiKhoanHienTai = tk;
            DanhSachNhanSu = InititalizeHumanList();
        }

        private void Form_QuanTriVien_Load(object sender, EventArgs e)
        {
            HideAllPanels();
            panelThongTin.Visible = true;
            LoadAccountData();
            lblTenQuanTriVien.Text = "ADMIN";
        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            AllowModifyAccountInfo();
        }

        private void btnLuuTaiKhoan_Click(object sender, EventArgs e)
        {
            ModifyAccountInfo();
        }

        private void panelQuanTriVien_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelThongTin.Visible = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            new Form_ChaoMung().Show();
            Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelTimKiem.Visible = true;
            dgvDuLieu.DataSource = DanhSachNhanSu;
        }

        private void btnDatLaiThongTin_Click(object sender, EventArgs e)
        {
            dgvDuLieu.DataSource = DanhSachNhanSu;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTuKhoa.Text))
            {
                dgvDuLieu.DataSource = new List<IHuman>(SearchHumanByName());
            }
            else
            {
                MessageBox.Show("Không thể để trống từ khóa tìm kiếm.", "Tìm kiếm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXemSuaThongTin_Click(object sender, EventArgs e)
        {
            if (dgvDuLieu.SelectedRows.Count > 0)
            {
                if (dgvDuLieu.SelectedRows[0].DataBoundItem is KhachHang kh)
                {
                    new Form_ThongTinKhachHang(kh).Show();
                }
                if (dgvDuLieu.SelectedRows[0].DataBoundItem is NhanVien nv)
                {
                    new Form_ThongTinNhanVien(nv).Show();
                }
                dgvDuLieu.DataSource = DanhSachNhanSu;
            }
            else
            {
                MessageBox.Show("Không có người được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDuLieu.SelectedRows.Count > 0)
            {
                if (dgvDuLieu.SelectedRows[0].DataBoundItem is KhachHang)
                {
                    MessageBox.Show("Không thể xóa khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dgvDuLieu.SelectedRows[0].DataBoundItem is NhanVien nv)
                {
                    if (MessageBox.Show("Bạn thực sự muốn xóa nhân viên này (vì vi phạm nội quy, lý do cá nhân hay lý do khác?)", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Data.DanhSachNhanVien?.Remove(nv);
                        foreach (TaiKhoan tk in Data.DanhSachTaiKhoan!)
                        {
                            if (tk is TaiKhoanNV && (tk as TaiKhoanNV)?.MaNV == nv.ID)
                            {
                                Data.DanhSachTaiKhoan?.Remove(tk);
                                break;
                            }
                        }
                        MessageBox.Show("Xóa thành công.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvDuLieu.DataSource = DanhSachNhanSu;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có người được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPhuongTien_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelPhuongTien.Visible = true;
            dgvPhuongTien.DataSource = Data.DanhSachPhuongTien;
        }

        private void btnDatLaiPhuongTien_Click(object sender, EventArgs e)
        {
            dgvPhuongTien.DataSource = Data.DanhSachPhuongTien;
        }

        private void btnTimPhuongTien_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTheoBienSo.Text))
            {
                dgvPhuongTien.DataSource = new List<PhuongTien>(SearchVehicleByPlate());
            }
            else
            {
                MessageBox.Show("Không thể để trống biển số tìm kiếm.", "Tìm kiếm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXemSuaPhuongTien_Click(object sender, EventArgs e)
        {
            if (dgvPhuongTien.SelectedRows.Count > 0)
            {
                if (dgvPhuongTien.SelectedRows[0].DataBoundItem is PhuongTien pt)
                {
                    new Form_ThongTinPhuongTien(pt).Show();
                }
                else
                {
                    MessageBox.Show("Phương tiện không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvPhuongTien.DataSource = Data.DanhSachPhuongTien;
            }
            else
            {
                MessageBox.Show("Không có phương tiện được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelThongKe.Visible = true;
            lblSoKhachHang.Text = Data.DanhSachKhachHang?.Count.ToString();
            lblSoDonHang.Text = Data.DanhSachDonHang?.Count.ToString();
            lblSoDonTrungBinh.Text = Data.DanhSachKhachHang?.Count > 0 ? $"{Data.DanhSachDonHang?.Count / Data.DanhSachKhachHang?.Count:N2}" : $"{0:N2}";
            lblTongCuocPhi.Text = $"{TinhTongCuocPhi():N0}";
            lblCuocPhiTrungBinh.Text = DemSoDonThanhCong() > 0 ? $"{TinhTongCuocPhi() / DemSoDonThanhCong():N2}" : $"{0:N2}";
            lblSoNhanVien.Text = Data.DanhSachNhanVien?.Count.ToString();
            lblSoDonThanhCong.Text = DemSoDonThanhCong().ToString();
            lblSoDonGiaoTrungBinh.Text = Data.DanhSachNhanVien?.Count > 0 ? $"{DemSoDonThanhCong() / Data.DanhSachNhanVien?.Count:N2}" : $"{0:N2}";
            lblThuNhapTrungBinh.Text = DemSoTaiXe() > 0 ? $"{TinhTongCuocPhi() / DemSoTaiXe():N2}" : $"{0:N2}";
            lblDanhGiaTrungBinh.Text = DemSoTaiXe() > 0 ? $"{LayTongDanhGia() / DemSoTaiXe():N2}" : $"{0:N2}";
        }
    }
}
