namespace OOP_Logistics.Khách_Hàng
{
    class KhachHangDoanhNghiep(int MaKhachHang, string HoTen, string SoDienThoai, string SoCCCD, string TenCTy, string LinhVuc, string DiaChiTruSo, string EmailCTy) : KhachHang(MaKhachHang, HoTen, SoDienThoai, SoCCCD)
    {
        public string? TenCongTy { get; set; } = TenCTy;
        public string? LinhVucHoatDong { get; set; } = LinhVuc;
        public string? NoiDongTruSo { get; set; } = DiaChiTruSo;
        public string? EmailCongTy { get; set; } = EmailCTy;
        public void SuaThongTin(int MaKhachHang, string HoTen, string SoDienThoai, string SoCCCD, string TenCTy, string LinhVuc, string DiaChiTruSo, string EmailCTy)
        {
            base.SuaThongTin(MaKhachHang, HoTen, SoDienThoai, SoCCCD);
            TenCongTy = TenCTy;
            LinhVucHoatDong = LinhVuc;
            NoiDongTruSo = DiaChiTruSo;
            EmailCongTy = EmailCTy;
        }
    }
}
