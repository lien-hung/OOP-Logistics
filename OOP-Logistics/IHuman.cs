namespace OOP_Logistics
{
    interface IHuman
    {
        int ID { get; set; }
        string? Name { get; set; }
        string? PhoneNumber { get; set; }
        string? CitizenID { get; set; }
        void SuaThongTin(int MaDinhDanh, string HoTen, string SoDienThoai, string SoCCCD);
    }
}
