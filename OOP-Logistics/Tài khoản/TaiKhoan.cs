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

        public void ModifyAccount(string tenDangNhapMoi, string matKhauMoi)
        {
            Username = tenDangNhapMoi;
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

        public static TaiKhoan? SearchByUsername(string username)
        {
            foreach (TaiKhoan tk in Data.DanhSachTaiKhoan!)
            {
                if (tk.Username == username)
                {
                    return tk;
                }
            }
            return null;
        }
    }
}
