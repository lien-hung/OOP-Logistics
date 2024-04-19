using OOP_Logistics.Quản_Trị_Viên;

namespace OOP_Logistics.Nhân_Viên
{
    public enum ChucVu
    {
        TruongKho,
        QuanLy,
        NhanVienThuong
    }
    public class NhanVienLuanChuyen(int id, string name, string phoneNumber, string citizenID, ChucVu chucVu, KhoGiaoNhan khoLamViec) : NhanVien(id, name, phoneNumber, citizenID)
    {
        public ChucVu ChucVu { get; set; } = chucVu;
        public KhoGiaoNhan KhoLamViec { get; set; } = khoLamViec;
        public string LayChucVu()
        {
            switch (ChucVu)
            {
                case ChucVu.TruongKho:
                    return "Trưởng kho";
                case ChucVu.QuanLy:
                    return "Quản lý";
                case ChucVu.NhanVienThuong:
                    return "Nhân viên thường";
                default:
                    return string.Empty;
            }
        }
        public double LayHeSoLuong()
        {
            switch (ChucVu)
            {
                case ChucVu.TruongKho:
                    return 3.5;
                case ChucVu.QuanLy:
                    return 2.4;
                case ChucVu.NhanVienThuong:
                    return 1.6;
                default:
                    return 0;
            }
        }
        public void ThayDoiChucVu(ChucVu chucVu)
        {
            ChucVu = chucVu;
        }
        public override double TinhThuNhap()
        {
            return 1_800_000 * LayHeSoLuong();
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
