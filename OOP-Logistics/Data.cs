using OOP_Logistics.Khách_Hàng;
using OOP_Logistics.Nhân_Viên;
using OOP_Logistics.Quản_Trị_Viên;

namespace OOP_Logistics
{
    public class Data
    {
        public static List<KhachHang>? DanhSachKhachHang { get; set; }
        public static List<DonHang>? DanhSachDonHang { get; set; }
        public static List<NhanVien>? DanhSachNhanVien { get; set; }
        public static List<BuuKien>? DanhSachBuuKien { get; set; }
        public static List<PhuongTien>? DanhSachPhuongTien { get; set; }
        public static List<KhoGiaoNhan>? DanhSachKhoGiaoNhan { get; set; }
        public static List<TaiKhoan>? DanhSachTaiKhoan { get; set; }
        private static void CreateWarehouse()
        {
            DanhSachKhoGiaoNhan =
            [
                new KhoGiaoNhan(1, new DiaDiem("59C Nguyễn Đình Chiểu, Q3", 10.7830898, 106.6921685)),
                new KhoGiaoNhan(2, new DiaDiem("279 Nguyễn Tri Phương, Q10", 10.7610585, 106.6657831)),
                new KhoGiaoNhan(3, new DiaDiem("Đại lộ Nguyễn Văn Linh, HBC", 10.7060233, 106.637554))
            ];
        }
        public static void Initialize()
        {
            List<KhachHang>? serializedKhachHang = Serializer.DeserializeJsonFromFile<List<KhachHang>>("KhachHang.json");
            DanhSachKhachHang = serializedKhachHang != default ? serializedKhachHang : [];
            List<DonHang>? serializedDonHang = Serializer.DeserializeJsonFromFile<List<DonHang>>("DonHang.json");
            DanhSachDonHang = serializedDonHang != default ? serializedDonHang : [];
            List<NhanVien>? serializedNhanVien = Serializer.DeserializeJsonFromFile<List<NhanVien>>("NhanVien.json");
            DanhSachNhanVien = serializedNhanVien != default ? serializedNhanVien : [];
            List<BuuKien>? serializedBuuKien = Serializer.DeserializeJsonFromFile<List<BuuKien>>("BuuKien.json");
            DanhSachBuuKien = serializedBuuKien != default ? serializedBuuKien : [];
            List<PhuongTien>? serializedPhuongTien = Serializer.DeserializeJsonFromFile<List<PhuongTien>>("PhuongTien.json");
            DanhSachPhuongTien = serializedPhuongTien != default ? serializedPhuongTien : [];
            List<TaiKhoan>? serializedTaiKhoan = Serializer.DeserializeJsonFromFile<List<TaiKhoan>>("TaiKhoan.json");
            DanhSachTaiKhoan = serializedTaiKhoan != default ? serializedTaiKhoan : [new TaiKhoanQuanTriVien("admin", "123")];

            CreateWarehouse();
        }
        public static void Serialize()
        {
            Serializer.WriteJsonToFile("KhachHang.json", DanhSachKhachHang);
            Serializer.WriteJsonToFile("DonHang.json", DanhSachDonHang);
            Serializer.WriteJsonToFile("NhanVien.json", DanhSachNhanVien);
            Serializer.WriteJsonToFile("BuuKien.json", DanhSachBuuKien);
            Serializer.WriteJsonToFile("PhuongTien.json", DanhSachPhuongTien);
            Serializer.WriteJsonToFile("TaiKhoan.json", DanhSachTaiKhoan);
        }
    }
}
