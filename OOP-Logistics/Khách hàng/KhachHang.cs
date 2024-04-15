namespace OOP_Logistics.Khách_Hàng
{
    public abstract class KhachHang(int MaKhachHang, string HoTen, string SoDienThoai, string SoCCCD) : IHuman
    {
        public int ID { get; set; } = MaKhachHang;
        public string? Name { get; set; } = HoTen;
        public string? PhoneNumber { get; set; } = SoDienThoai;
        public string? CitizenID { get; set; } = SoCCCD;

        public void XemThongTin()
        {
            Console.WriteLine($"Thông tin khách hàng: {Name}");
            Console.WriteLine($"Số điện thoại: {PhoneNumber}");
            Console.WriteLine($"Mã khách hàng: {ID}");
            Console.WriteLine($"Số căn cước: {CitizenID}");
        }

        public virtual void ChinhSuaThongTin(int MaDinhDanh, string HoTen, string SoDienThoai, string SoCCCD)
        {
            ID = MaDinhDanh;
            Name = HoTen;
            PhoneNumber = SoDienThoai;
            CitizenID = SoCCCD;
        }

        private readonly List<DonHang> lichSuDonHang = [];

        // Phương thức để xem lịch sử đơn hàng
        public void XemLichSuDonHang()
        {
            Console.WriteLine($"Lịch Sử Đơn Hàng của Khách Hàng: {Name}");
            foreach (var donHang in lichSuDonHang)
            {
                Console.WriteLine($"ID Đơn Hàng: {donHang.MaDonHang}, Ngày: {donHang.NgayDatHang}");
            }
        }

        // Phương thức để tính toán thống kê
        public void TinhToanThongKe()
        {

        }

        // Phương thức bổ sung để thêm đơn hàng vào lịch sử
        public void ThemDonHang(DonHang donHang)
        {
            lichSuDonHang.Add(donHang);
        }
    }
}