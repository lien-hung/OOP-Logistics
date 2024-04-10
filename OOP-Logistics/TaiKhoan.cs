namespace OOP_Logistics
{
    internal class TaiKhoan : ITaiKhoan
    {
        public string? Username { get; set; }
        public string? Password { get; set; }

        public bool Register(string tenDangNhap, string matKhau)
        {
            return true;
        }

        public bool Login(string tenDangNhap, string matKhau)
        {
            return true;
        }

        public void Logout()
        {

        }

        public bool DeleteAccount(string tenDangNhap)
        {
            return true;
        }
    }
}
