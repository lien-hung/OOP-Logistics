namespace OOP_Logistics.Quản_Trị_Viên
{
    public class QuanTriVien
    {
        public void XemThongTin()
        {
            // Logic để xem thông tin quản trị viên
        }

        public void SuaThongTin()
        {
            // Logic để sửa thông tin quản trị viên
        }
        public string? TenTaiKhoan { get; set; }
        public string? Password { get; set; }

        // Constructor mặc định
        public QuanTriVien()
        {
            // Thiết lập tài khoản quản trị viên mặc định
            TenTaiKhoan = "admin";
            Password = "123";
        }

        // Phương thức đăng nhập
        public bool Login(string username, string password)
        {
            if (TenTaiKhoan == username && Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Logout()
        {
            // Logic để đăng xuất
        }

        public void DeleteAccount()
        {
            // Logic để xóa tài khoản quản trị viên
        }

        // Các phương thức hoặc tính năng khác cho quản trị viên
        public void TaoNhanVien()
        {
            // Logic để tạo tài khoản nhân viên mới
        }

        public void XoaNhanVien(string NhanVienID)
        {
            // Logic để xóa tài khoản nhân viên
        }
    }
}
