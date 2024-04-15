using OOP_Logistics.Khách_Hàng;

namespace OOP_Logistics
{
    public partial class Form_KhachHang : Form
    {
        private TaiKhoanKH? TaiKhoanHienTai;
        public Form_KhachHang(TaiKhoanKH? tk)
        {
            InitializeComponent();
            TaiKhoanHienTai = tk;
        }
    }
}
