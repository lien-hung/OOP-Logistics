namespace OOP_Logistics
{
    interface IHuman
    {
        string? ID { get; set; }
        string? Name { get; set; }
        string? Address { get; set; }
        string? PhoneNumber { get; set; }
        string? CitizenID { get; set; }
        void ThongTin(string a, string b, string c, string d, string e);
        void XemThongTin();
        void ChinhSuaThongTin();
    }
}
