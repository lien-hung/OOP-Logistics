using OOP_Logistics.Quản_Trị_Viên;

namespace OOP_Logistics.Khách_Hàng
{
    public enum LoaiHang
    {
        KhongCo,
        ChungNhanHoSo,
        HangDeVo,
        HangNguyenKhoiQuaKho,
        ChatLong
    }
    public enum LoaiVanChuyen
    {
        Thuong,
        HoaToc,
        TietKiem
    }
    public enum TrangThaiDonHang
    {
        DaTao,
        DangXuLy,
        GiaoThanhCong
    }
    public class DonHang(int maDonHang, int maKhachHang, KhoGiaoNhan? khoLuu)
    {
        public int MaDonHang { get; set; } = maDonHang;
        public DateTime ThoiDiemDatHang { get; set; } = DateTime.Now;
        public int MaKhachHang { get; set; } = maKhachHang;
        public KhoGiaoNhan? KhoLuu { get; set; } = khoLuu;
        public int MaBuuKien { get; set; } = 0;
        public DateTime CapNhatCuoiCung { get; set; } = DateTime.Now;
        public TrangThaiDonHang TrangThaiDonHang { get; set; } = TrangThaiDonHang.DaTao;
        public int DanhGia { get; set; } = 0;
        public void SuaThongTin(KhoGiaoNhan? khoLuu)
        {
            KhoLuu = khoLuu;
        }
        public void ChoDanhGia(int diem)
        {
            DanhGia = diem;
        }
        public ChiTietDonHang LayChiTiet()
        {
            foreach (ChiTietDonHang ctdh in Data.DanhSachChiTietDon!)
            {
                if (ctdh.MaDonHang == MaDonHang)
                {
                    return ctdh;
                }
            }
            return null!;
        }
        public static int MaTiepTheo()
        {
            int i = 1;
            if (Data.DanhSachDonHang!.Count != 0)
            {
                foreach (DonHang dh in Data.DanhSachDonHang)
                {
                    if (dh.MaDonHang != i)
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
