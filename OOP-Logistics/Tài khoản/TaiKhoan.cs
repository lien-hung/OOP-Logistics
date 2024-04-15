namespace OOP_Logistics
{
    public abstract class TaiKhoan(string username, string password) : ITaiKhoan
    {
        public string? Username { get; set; } = username;
        public string? Password { get; set; } = password;

        public void ChangePassword(string matKhauMoi)
        {
            Password = matKhauMoi;
        }

        public bool Login(string tenDangNhap, string matKhau)
        {
            if (Username == tenDangNhap && Password == matKhau)
            {
                return true;
            }
            return false;
        }

        public void Logout()
        {

        }
    }
}
