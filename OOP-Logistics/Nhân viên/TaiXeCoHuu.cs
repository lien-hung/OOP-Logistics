using OOP_Logistics.Quản_Trị_Viên;

namespace OOP_Logistics.Nhân_Viên
{
    public class TaiXeCoHuu(int MaNhanVien, string HoTen, string SoDienThoai, string SoCCCD, PhuongTien phuongTien) : NhanVien(MaNhanVien, HoTen, SoDienThoai, SoCCCD)
    {
        public PhuongTien? PhuongTienGiaoHang { get; set; } = phuongTien;
        public int DiemDanhGia { get; set; } = 0;

        public void NhanDon(BuuKien buuKien)
        {
            Console.WriteLine($"Đã nhận đơn {buuKien}. Đang vận chuyển...");
        }

        public decimal TinhThuNhap(List<BuuKien> danhSachDonHang)
        {
            decimal tongThuNhap = 0;
            foreach (var buuKien in danhSachDonHang)
            {
                // tongThuNhap += buuKien.CuocPhi;
            }
            return tongThuNhap;
        }
    }
}
