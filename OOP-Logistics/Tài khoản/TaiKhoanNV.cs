namespace OOP_Logistics.Nhân_Viên
{
    internal class TaiKhoanNV : ITaiKhoan
    {
        public string? MaNV { get; set; }
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
