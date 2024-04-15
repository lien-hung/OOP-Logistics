namespace OOP_Logistics
{
    internal interface ITaiKhoan
    {
        string? Username { get; set; }
        string? Password { get; set; }
        bool Login(string tenDangNhap, string matKhau);
        void Logout();
    }
}
