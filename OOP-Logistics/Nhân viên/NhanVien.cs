using System.Text.Json.Serialization;

namespace OOP_Logistics.Nhân_Viên
{
    [JsonDerivedType(typeof(NhanVienLuanChuyen), nameof(NhanVienLuanChuyen))]
    [JsonDerivedType(typeof(TaiXeCoHuu), nameof(TaiXeCoHuu))]
    public abstract class NhanVien(int id, string name, string phoneNumber, string citizenID) : IHuman
    {
        public int ID { get; set; } = id;
        public string Name { get; set; } = name;
        public string PhoneNumber { get; set; } = phoneNumber;
        public string CitizenID { get; set; } = citizenID;
        public void SuaThongTin(int MaNhanVien, string HoTen, string SoDienThoai, string SoCCCD)
        {
            ID = MaNhanVien;
            Name = HoTen;
            PhoneNumber = SoDienThoai;
            CitizenID = SoCCCD;
        }
        public abstract double TinhThuNhap();
        public static int MaTiepTheo()
        {
            int i = 1;
            if (Data.DanhSachNhanVien!.Count != 0)
            {
                foreach (NhanVien nv in Data.DanhSachNhanVien)
                {
                    if (nv.ID != i)
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
