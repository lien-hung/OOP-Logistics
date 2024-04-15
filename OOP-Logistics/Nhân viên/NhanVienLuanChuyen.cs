using OOP_Logistics.Quản_Trị_Viên;

namespace OOP_Logistics.Nhân_Viên
{
    public enum ChucVu
    {
        TruongKho,
        QuanLy,
        NhanVienThuong
    }
    public class NhanVienLuanChuyen(int MaNhanVien, string HoTen, string SoDienThoai, string SoCCCD, ChucVu chucVu, KhoGiaoNhan khoLamViec, double heSoLuong) : NhanVien(MaNhanVien, HoTen, SoDienThoai, SoCCCD)
    {
        public ChucVu ChucVu { get; set; } = chucVu;
        public KhoGiaoNhan KhoLamViec { get; set; } = khoLamViec;
        public double HeSoLuong { get; set; } = heSoLuong;

        //Phương thức tính lương cố định dựa vào hệ số lương
        public decimal TinhLuongCoDinh()
        {
            // Giả sử lương cố định được tính bằng hệ số lương nhân viên nhân với một giá trị cố định nào đó.
            decimal luongCoDinh = (decimal)HeSoLuong * 1000;
            return luongCoDinh;
        }

        // Phương thức tăng hệ số lương cho nhân viên
        public void TangHeSoLuong(double increaseAmount)
        {
            HeSoLuong += increaseAmount;
            Console.WriteLine($"Hệ số lương của nhân viên {Name} đã được tăng lên thành {HeSoLuong}");
        }
    }
}
