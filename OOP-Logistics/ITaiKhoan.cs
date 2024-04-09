namespace OOP_Logistics
{
    internal interface ITaiKhoan
    {
        string? Username { get; set; }
        string? Password { get; set; }
        bool Register(string tenDangNhap, string matKhau);
        bool Login(string tenDangNhap, string matKhau);
        void Logout();
        bool DeleteAccount(string tenDangNhap);
    }
}
