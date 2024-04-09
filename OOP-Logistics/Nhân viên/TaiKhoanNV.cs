namespace OOP_Logistics.Nhân_Viên
{
    internal class TaiKhoanNV : ITaiKhoan
    {
        public string? MaNV { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public bool Register(string tênĐăngNhập, string mậtKhẩu)
        {
            return true;
        }

        public bool Login(string tênĐăngNhập, string mậtKhẩu)
        {
            return true;
        }

        public void Logout()
        {

        }

        public bool DeleteAccount(string tênĐăngNhập)
        {
            return true;
        }
    }

    internal class MainClass
    {
        private static void Main()
        {
            TaiKhoanNV taiKhoan = new();
            taiKhoan.Register("user1", "password1");
            taiKhoan.Login("user1", "password1");
            taiKhoan.Logout();
            taiKhoan.DeleteAccount("user1");
        }
    }
}
