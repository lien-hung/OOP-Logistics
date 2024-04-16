namespace OOP_Logistics.Nhân_Viên
{
    public class TaiKhoanNV(int maNV, string username, string password) : TaiKhoan(username, password)
    {
        public int MaNV { get; set; } = maNV;
        public NhanVien? GetEmployee()
        {
            foreach (NhanVien nv in Data.DanhSachNhanVien!)
            {
                if (MaNV == nv.ID)
                {
                    return nv;
                }
            }
            return null;
        }
    }
}
