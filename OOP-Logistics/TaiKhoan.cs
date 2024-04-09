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
    internal class MainClass
    {
        private static void Main()
        {
            TaiKhoan taiKhoan = new();

            // Tạo tài khoản mặc định cho quản trị viên
            taiKhoan.Register("admin", "123");

            // Đăng nhập và thực hiện các hoạt động khác
            taiKhoan.Login("admin", "123");
            taiKhoan.Logout();
            taiKhoan.DeleteAccount("admin");
        }
    }
}
