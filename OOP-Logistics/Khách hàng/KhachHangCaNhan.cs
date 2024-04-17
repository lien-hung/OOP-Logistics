namespace OOP_Logistics.Khách_Hàng
{
    class KhachHangCaNhan(int MaKhachHang, string HoTen, string SoDienThoai, string SoCCCD, string Email, string DiaChi) : KhachHang(MaKhachHang, HoTen, SoDienThoai, SoCCCD)
    {
        public string? EmailCaNhan { get; set; } = Email;
        public string? DiaChiLienLac { get; set; } = DiaChi;
        public void ChinhSuaThongTin(int MaDinhDanh, string HoTen, string SoDienThoai, string SoCCCD, string Email, string DiaChi)
        {
            base.SuaThongTin(MaDinhDanh, HoTen, SoDienThoai, SoCCCD);
            EmailCaNhan = Email;
            DiaChiLienLac = DiaChi;
        }
    }
}
