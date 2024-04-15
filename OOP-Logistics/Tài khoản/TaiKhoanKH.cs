namespace OOP_Logistics.Khách_Hàng
{
    public class TaiKhoanKH(int maKH, string username, string password) : TaiKhoan(username, password)
    {
        public int MaKH { get; set; } = maKH;
    }
}
