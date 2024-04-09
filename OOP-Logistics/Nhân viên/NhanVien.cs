namespace OOP_Logistics.Nhân_Viên
{
    internal class NhanVien : IHuman
    {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CitizenID { get; set; }
        public void ThongTin(string MaNhanVien, string HoTen, string DiaChiLienHe, string SoDienThoai, string SoCCCD)
        {
            ID = MaNhanVien;
            Name = HoTen;
            Address = DiaChiLienHe;
            PhoneNumber = SoDienThoai;
            CitizenID = SoCCCD;
        }

        public List<decimal> LichSuThuNhap { get; set; }

        public NhanVien()
        {
            LichSuThuNhap = [];
        }

        public void XemLichSuThuNhap()
        {
            Console.WriteLine("Lịch sử thu nhập của nhân viên:");
            foreach (var thuNhap in LichSuThuNhap)
            {
                Console.WriteLine($"- {thuNhap}");
            }
        }
        public void XemThongTin()
        {
            Console.WriteLine($"Mã định danh: {ID}");
            Console.WriteLine($"Họ tên: {Name}");
            Console.WriteLine($"Địa chỉ: {Address}");
            Console.WriteLine($"Số điện thoại: {PhoneNumber}");
            Console.WriteLine($"Số CCCD: {CitizenID}");
            XemLichSuThuNhap();
        }

        public void ChinhSuaThongTin()
        {
            
        }
    }
}
