namespace OOP_Logistics.Khách_Hàng
{
    public class TaiKhoanKH(int maKH, string username, string password) : TaiKhoan(username, password)
    {
        public int MaKH { get; set; } = maKH;
        public KhachHang? GetCustomer()
        {
            foreach (KhachHang kh in Data.DanhSachKhachHang!)
            {
                if (MaKH == kh.ID)
                {
                    return kh;
                }
            }
            return null;
        }
    }
}
