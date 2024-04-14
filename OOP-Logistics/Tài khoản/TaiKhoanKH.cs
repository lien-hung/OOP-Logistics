namespace OOP_Logistics.Khách_Hàng
{
    internal class TaiKhoanKH
    {
        internal class TaiKhoan : ITaiKhoan
        {
            private Dictionary<string, string> danhSachTaiKhoan = new Dictionary<string, string>();
            private bool daDangNhap = false;
            private string tenTaiKhoanHienTai = "";

            public string Username { get; set; }
            public string Password { get; set; }

            public TaiKhoan()
            {
                // Khởi tạo danh sách tài khoản mẫu
                danhSachTaiKhoan.Add("KHadmin", "123");
            }

            public bool Register(string tenDangNhap, string matKhau)
            {
                if (!danhSachTaiKhoan.ContainsKey(tenDangNhap))
                {
                    danhSachTaiKhoan.Add(tenDangNhap, matKhau);
                    return true;
                }
                else
                {
                    Console.WriteLine("Tài khoản đã tồn tại!");
                    return false;
                }
            }

            public bool Login(string tenDangNhap, string matKhau)
            {
                if (danhSachTaiKhoan.TryGetValue(tenDangNhap, out string storedPassword) && storedPassword == matKhau)
                {
                    daDangNhap = true;
                    tenTaiKhoanHienTai = tenDangNhap;
                    Console.WriteLine("Đăng nhập thành công!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Tên đăng nhập hoặc mật khẩu không đúng!");
                    return false;
                }
            }

            public void Logout()
            {
                daDangNhap = false;
                tenTaiKhoanHienTai = "";
                Console.WriteLine("Đã đăng xuất!");
            }

            public bool DeleteAccount(string tenDangNhap)
            {
                if (danhSachTaiKhoan.ContainsKey(tenDangNhap))
                {
                    danhSachTaiKhoan.Remove(tenDangNhap);
                    return true;
                }
                else
                {
                    Console.WriteLine("Tài khoản không tồn tại!");
                    return false;
                }
            }
        }
    }
}
