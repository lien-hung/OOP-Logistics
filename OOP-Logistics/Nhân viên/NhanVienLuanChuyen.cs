using OOP_Logistics.Quản_Trị_Viên;

namespace OOP_Logistics.Nhân_Viên
{
    public enum ChucVu
    {
        TruongKho,
        QuanLy,
        NhanVienThuong
    }
    public class NhanVienLuanChuyen(int MaNhanVien, string HoTen, string SoDienThoai, string SoCCCD, ChucVu chucVu, KhoGiaoNhan khoLamViec) : NhanVien(MaNhanVien, HoTen, SoDienThoai, SoCCCD)
    {
        public ChucVu ChucVu { get; set; } = chucVu;
        public KhoGiaoNhan KhoLamViec { get; set; } = khoLamViec;
        public double HeSoLuong { get; set; }
        public string LayChucVuVaHeSoLuong()
        {
            switch (ChucVu)
            {
                case ChucVu.TruongKho:
                    HeSoLuong = 3.5;
                    return "Trưởng kho";
                case ChucVu.QuanLy:
                    HeSoLuong = 2.4;
                    return "Quản lý";
                case ChucVu.NhanVienThuong:
                    HeSoLuong = 1.6;
                    return "Nhân viên thường";
                default:
                    HeSoLuong = 0;
                    return string.Empty;
            }
        }
        public void ThayChucVu(ChucVu chucVu)
        {
            ChucVu = chucVu;
            LayChucVuVaHeSoLuong();
        }
        public override double TinhThuNhap()
        {
            return 1_800_000 * HeSoLuong;
        }
        public IEnumerable<LichSuLuongThuong> LayLichSuLuong()
        {
            foreach (LichSuLuongThuong ls in Data.DanhSachLichSuLuong!)
            {
                if (ls.ID == ID)
                {
                    yield return ls;
                }
            }
        }
    }
}
