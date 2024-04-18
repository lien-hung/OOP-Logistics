namespace OOP_Logistics.Khách_Hàng
{
    class KhachHangDoanhNghiep(int id, string name, string phoneNumber, string citizenID, string tenCongTy, string linhVucHoatDong, string noiDongTruSo, string emailCongTy) : KhachHang(id, name, phoneNumber, citizenID)
    {
        public string TenCongTy { get; set; } = tenCongTy;
        public string LinhVucHoatDong { get; set; } = linhVucHoatDong;
        public string NoiDongTruSo { get; set; } = noiDongTruSo;
        public string EmailCongTy { get; set; } = emailCongTy;
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
