using OOP_Logistics.Khách_Hàng;
using OOP_Logistics.Nhân_Viên;
using OOP_Logistics.Quản_Trị_Viên;
using System.Text.Json.Serialization;

namespace OOP_Logistics
{
    [JsonDerivedType(typeof(TaiKhoanKH), nameof(TaiKhoanKH))]
    [JsonDerivedType(typeof(TaiKhoanNV), nameof(TaiKhoanNV))]
    [JsonDerivedType(typeof(TaiKhoanQuanTriVien), nameof(TaiKhoanQuanTriVien))]
    public abstract class TaiKhoan(string username, string password)
    {
        public string? Username { get; set; } = username;
        public string? Password { get; set; } = password;
        public bool Login(string tenDangNhap, string matKhau)
        {
            if (Username == tenDangNhap && Password == matKhau)
            {
                return true;
            }
            return false;
        }
        public void ChangePassword(string matKhauMoi)
        {
            Password = matKhauMoi;
        }
        public void ModifyAccount(string tenDangNhapMoi, string matKhauMoi)
        {
            Username = tenDangNhapMoi;
            Password = matKhauMoi;
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
