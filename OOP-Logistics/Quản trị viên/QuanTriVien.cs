namespace OOP_Logistics.Quản_Trị_Viên
{
    public class QuanTriVien : IHuman
    {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CitizenID { get; set; }

        public void ThongTin(string id, string name, string phoneNumber, string citizenID)
        {
            ID = id;
            Name = name;
            PhoneNumber = phoneNumber;
            CitizenID = citizenID;
        }

        public void XemThongTin()
        {
            // Logic để xem thông tin quản trị viên
        }

        public void ChinhSuaThongTin()
        {
            // Logic để sửa thông tin quản trị viên
        }

        public string? Username { get; set; }
        public string? Password { get; set; }

        // Constructor mặc định
        public QuanTriVien()
        {
            // Thiết lập tài khoản quản trị viên mặc định
            Username = "admin";
            Password = "123";
        }

        // Phương thức đăng nhập
        public bool Login(string username, string password)
        {
            if (Username == username && Password == password)
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
