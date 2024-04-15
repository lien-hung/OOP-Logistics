namespace OOP_Logistics.Nhân_Viên
{
    public class TaiKhoanNV(int maNV, string username, string password) : TaiKhoan(username, password)
    {
        public int MaNV { get; set; } = maNV;
    }
}
