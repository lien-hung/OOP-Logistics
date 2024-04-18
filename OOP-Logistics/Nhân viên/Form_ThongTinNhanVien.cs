using OOP_Logistics.Nhân_Viên;
using OOP_Logistics.Quản_Trị_Viên;

namespace OOP_Logistics
{
    public partial class Form_ThongTinNhanVien : Form
    {
        private readonly NhanVien? NhanVienHienTai;
        public Form_ThongTinNhanVien(NhanVien nv)
        {
            InitializeComponent();
            NhanVienHienTai = nv;
        }

        private void Form_ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            if (NhanVienHienTai is NhanVienLuanChuyen nvlc)
            {
                cboLoaiNhanVien.SelectedIndex = 0;
                cboChucVu.SelectedIndex = (int)nvlc.ChucVu;
                txtNoiLamViec.Text = nvlc.KhoLamViec.DiaDiemKho?.Address;
                btnChiTraLuong.Enabled = cboChucVu.Enabled = btnLuu.Enabled = true;
            }
            if (NhanVienHienTai is TaiXeCoHuu)
            {
                cboLoaiNhanVien.SelectedIndex = 0;
                txtNoiLamViec.Text = "N/A";
                btnChiTraLuong.Enabled = cboChucVu.Enabled = btnLuu.Enabled = false;
            }
            txtHoVaTen.Text = NhanVienHienTai?.Name;
            txtSoDienThoai.Text = NhanVienHienTai?.PhoneNumber;
            txtSoCCCD.Text = NhanVienHienTai?.CitizenID;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChiTraLuong_Click(object sender, EventArgs e)
        {
            if (NhanVienHienTai is NhanVienLuanChuyen nvlc)
            {
                TaiKhoanQuanTriVien.ChiTraLuong(nvlc);
                MessageBox.Show($"Đã chi trả {nvlc.TinhThuNhap():N0}", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (NhanVienHienTai is NhanVienLuanChuyen nvlc)
            {
                switch (cboChucVu.SelectedIndex)
                {
                    case 0:
                        nvlc.ThayDoiChucVu(ChucVu.TruongKho);
                        break;
                    case 1:
                        nvlc.ThayDoiChucVu(ChucVu.QuanLy);
                        break;
                    case 2:
                        nvlc.ThayDoiChucVu(ChucVu.NhanVienThuong);
                        break;
                }
            }
        }
    }
}
