using OOP_Logistics.Khách_Hàng;

namespace OOP_Logistics
{
    public partial class Form_ThongTinKhachHang : Form
    {
        private readonly KhachHang? KhachHangHienTai;

        public Form_ThongTinKhachHang(KhachHang kh)
        {
            InitializeComponent();
            KhachHangHienTai = kh;
        }

        private void Form_ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            txtHoVaTen.Text = KhachHangHienTai?.Name;
            txtSoDienThoai.Text = KhachHangHienTai?.PhoneNumber;
            txtSoCCCD.Text = KhachHangHienTai?.CitizenID;
            if (KhachHangHienTai is KhachHangCaNhan khcn)
            {
                cboLoaiKhachHang.SelectedIndex = 0;
                txtTenCongTy.Text = txtLinhVuc.Text = "N/A";
                txtDiaChi.Text = khcn.DiaChiLienLac;
                txtEmail.Text = khcn.EmailCaNhan;
            }
            if (KhachHangHienTai is KhachHangDoanhNghiep khdn)
            {
                cboLoaiKhachHang.SelectedIndex = 1;
                txtTenCongTy.Text = khdn.TenCongTy;
                txtLinhVuc.Text = khdn.LinhVucHoatDong;
                txtDiaChi.Text = khdn.NoiDongTruSo;
                txtEmail.Text = khdn.EmailCongTy;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
