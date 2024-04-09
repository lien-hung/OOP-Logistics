namespace OOP_Logistics.Nhân_Viên
{
    internal class NhanVienLuanChuyen_Kho : NhanVien
    {
        public string? ChucVu { get; set; }
        public string? KhoLamViec { get; set; }
        public double HeSoLuong { get; set; }

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
