using OOP_Logistics.Quản_Trị_Viên;

namespace OOP_Logistics.Khách_Hàng
{
    public class ChiTietDonHang(int maDonHang, DiaDiem diemDau, DiaDiem diemCuoi, string moTaDon, int giaTri, LoaiHang loaiHang, LoaiVanChuyen loaiVanChuyen)
    {
        public int MaDonHang { get; set; } = maDonHang;
        public DiaDiem? DiemDau { get; set; } = diemDau;
        public DiaDiem? DiemCuoi { get; set; } = diemCuoi;
        public string? MoTaDon { get; set; } = moTaDon;
        public int GiaTri { get; set; } = giaTri;
        public LoaiHang LoaiHang { get; set; } = loaiHang;
        public LoaiVanChuyen LoaiVanChuyen { get; set; } = loaiVanChuyen;
        public void SuaThongTin(DiaDiem diemDau, DiaDiem diemCuoi, string moTa, int giaTri, LoaiHang loaiHang, LoaiVanChuyen loaiVanChuyen)
        {
            DiemDau = diemDau;
            DiemCuoi = diemCuoi;
            MoTaDon = moTa;
            GiaTri = giaTri;
            LoaiHang = loaiHang;
            LoaiVanChuyen = loaiVanChuyen;
        }
    }
}
