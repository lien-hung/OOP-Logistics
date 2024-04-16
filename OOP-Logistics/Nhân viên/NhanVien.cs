namespace OOP_Logistics.Nhân_Viên
{
    public class NhanVien(int MaNhanVien, string HoTen, string SoDienThoai, string SoCCCD) : IHuman
    {
        public int ID { get; set; } = MaNhanVien;
        public string? Name { get; set; } = HoTen;
        public string? PhoneNumber { get; set; } = SoDienThoai;
        public string? CitizenID { get; set; } = SoCCCD;
        public List<decimal> LichSuThuNhap { get; set; } = [];

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
            Console.WriteLine($"Số điện thoại: {PhoneNumber}");
            Console.WriteLine($"Số CCCD: {CitizenID}");
            XemLichSuThuNhap();
        }

        public void ChinhSuaThongTin(int MaNhanVien, string HoTen, string SoDienThoai, string SoCCCD)
        {
            ID = MaNhanVien;
            Name = HoTen;
            PhoneNumber = SoDienThoai;
            CitizenID = SoCCCD;

            Console.WriteLine("Thông tin nhân viên đã được cập nhật.");
        }

        public static int MaTiepTheo()
        {
            int i = 1;
            if (Data.DanhSachNhanVien!.Count != 0)
            {
                foreach (NhanVien nv in Data.DanhSachNhanVien)
                {
                    if (nv.ID != i)
                    {
                        return i;
                    }
                    else
                    {
                        i++;
                    }
                }
                return i;
            }
            return 1;
        }
    }
}
