namespace OOP_Logistics.Khách_Hàng
{
    class KhachHangCaNhan(int id, string name, string phoneNumber, string citizenID, string emailCaNhan, string diaChiLienLac) : KhachHang(id, name, phoneNumber, citizenID)
    {
        public string EmailCaNhan { get; set; } = emailCaNhan;
        public string DiaChiLienLac { get; set; } = diaChiLienLac;
        public void SuaThongTin(int MaDinhDanh, string HoTen, string SoDienThoai, string SoCCCD, string Email, string DiaChi)
        {
            base.SuaThongTin(MaDinhDanh, HoTen, SoDienThoai, SoCCCD);
            EmailCaNhan = Email;
            DiaChiLienLac = DiaChi;
        }
    }
}
