using OOP_Logistics.Quản_Trị_Viên;

namespace OOP_Logistics
{
    public partial class Form_ThongTinPhuongTien : Form
    {
        private readonly PhuongTien? PhuongTienHienTai;
        public Form_ThongTinPhuongTien(PhuongTien? pt)
        {
            InitializeComponent();
            PhuongTienHienTai = pt;
        }

        private void Form_ThongTinPhuongTien_Load(object sender, EventArgs e)
        {
            txtBienSo.Text = PhuongTienHienTai?.BienSoXe;
            txtLoaiPhuongTien.Text = PhuongTienHienTai?.LayLoaiXe();
            txtTrongTai.Text = PhuongTienHienTai?.TaiTrong.ToString();
            txtSoChuyenDaCho.Text = PhuongTienHienTai?.DemSoChuyenDaCho().ToString();
            txtTinhTrangPhuongTien.Text = PhuongTienHienTai?.LayTinhTrang();
            if (PhuongTienHienTai?.TinhTrangXe == TinhTrangXe.OnDinh)
            {
                btnBaoDuong.Enabled = false;
            }
            if (PhuongTienHienTai?.TinhTrangXe == TinhTrangXe.CanBaoDuong)
            {
                btnBaoDuong.Enabled = true;
            }
        }

        private void btnBaoDuong_Click(object sender, EventArgs e)
        {
            PhuongTienHienTai?.BaoDuong();
            MessageBox.Show("Đã bảo dưỡng", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
