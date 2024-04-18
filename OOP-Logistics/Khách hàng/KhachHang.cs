using System.Text.Json.Serialization;

namespace OOP_Logistics.Khách_Hàng
{
    [JsonDerivedType(typeof(KhachHangCaNhan), nameof(KhachHangCaNhan))]
    [JsonDerivedType(typeof(KhachHangDoanhNghiep), nameof(KhachHangDoanhNghiep))]
    public abstract class KhachHang(int MaKhachHang, string HoTen, string SoDienThoai, string SoCCCD) : IHuman
    {
        public int ID { get; set; } = MaKhachHang;
        public string? Name { get; set; } = HoTen;
        public string? PhoneNumber { get; set; } = SoDienThoai;
        public string? CitizenID { get; set; } = SoCCCD;
        public IEnumerable<DonHang> LayLichSuDatHang()
        {
            foreach (DonHang dh in Data.DanhSachDonHang!)
            {
                if (dh.MaKhachHang == ID)
                {
                    yield return dh;
                }
            }
        }
        public virtual void SuaThongTin(int MaKhachHang, string HoTen, string SoDienThoai, string SoCCCD)
        {
            ID = MaKhachHang;
            Name = HoTen;
            PhoneNumber = SoDienThoai;
            CitizenID = SoCCCD;
        }
        public static int MaTiepTheo()
        {
            int i = 1;
            if (Data.DanhSachKhachHang!.Count != 0)
            {
                foreach (KhachHang kh in Data.DanhSachKhachHang)
                {
                    if (kh.ID != i)
                    {
                        return i;
                    }
                    else
                    {
                        i++;
                    }
                }
                return i;
            }
            return 1;
        }
    }
}