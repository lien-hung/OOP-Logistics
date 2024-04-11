namespace OOP_Logistics
{
    interface IHuman
    {
        string? ID { get; set; }
        string? Name { get; set; }
        string? PhoneNumber { get; set; }
        string? CitizenID { get; set; }
        void ThongTin(string MaDinhDanh, string HoTen, string SoDienThoai, string SoCCCD);
        void XemThongTin();
        void ChinhSuaThongTin();
    }
}
