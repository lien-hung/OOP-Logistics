namespace OOP_Logistics.Khách_Hàng
{
    class KhachHang : IHuman
    {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CitizenID { get; set; }
        public void ThongTin(string MaKhachHang, string HoTen, string SoDienThoai, string SoCCCD)
        {
            ID = MaKhachHang;
            Name = HoTen;
            PhoneNumber = SoDienThoai;
            CitizenID = SoCCCD;
        }

        public void XemThongTin()
        {
            Console.WriteLine($"Thông tin khách hàng: {Name}");
            Console.WriteLine($"Số điện thoại: {PhoneNumber}");
            Console.WriteLine($"Mã khách hàng: {ID}");
            Console.WriteLine($"Số căn cước: {CitizenID}");
        }

        public void ChinhSuaThongTin()
        {

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