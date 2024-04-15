namespace OOP_Logistics.Quản_Trị_Viên
{
    public class TaiKhoanQuanTriVien(string username, string password) : TaiKhoan(username, password)
    {
        public void TaoNhanVien()
        {
            // Kiểm tra xem tên đăng nhập đã tồn tại chưa
            if (KiemTraTonTaiTenDangNhap(username))
            {
                Console.WriteLine("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                return;
            }

            // Kiểm tra mật khẩu có đủ mạnh không
            if (!KiemTraMatKhauManh(password))
            {
                Console.WriteLine("Mật khẩu không đủ mạnh. Vui lòng chọn mật khẩu khác.");
                return;
            }

            // Tạo đối tượng tài khoản nhân viên mới
            NhanVien newEmployee = new NhanVien(username, password);

            // Lưu tài khoản nhân viên mới vào cơ sở dữ liệu hoặc nguồn dữ liệu khác
            LuuNhanVienVaoCSDL(newEmployee);

            Console.WriteLine("Tài khoản nhân viên đã được tạo thành công.");
        }
        
        private bool KiemTraTonTaiTenDangNhap(string username)
        {
            // Logic kiểm tra xem tên đăng nhập đã tồn tại trong cơ sở dữ liệu hay chưa
            // Trả về true nếu tên đăng nhập đã tồn tại, ngược lại trả về false
        }

        private bool KiemTraMatKhauManh(string matKhau)
        {
            // Logic kiểm tra tính mạnh của mật khẩu
            // Trả về true nếu mật khẩu đủ mạnh, ngược lại trả về false
        }

        private void LuuNhanVienVaoCSDL(NhanVien nhanVien)
        {
            // Logic lưu tài khoản nhân viên vào cơ sở dữ liệu
        }

        public void XoaNhanVien(string NhanVienID)
        {
            // Logic để xóa tài khoản nhân viên
        }
    }
}
