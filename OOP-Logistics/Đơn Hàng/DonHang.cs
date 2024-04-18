using OOP_Logistics.Nhân_Viên;
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
    public class DonHang(int maDonHang, int maKhachHang, KhoGiaoNhan? khoLuu, LoaiXe loaiPhuongTien, int cuocPhi)
    {
        public int MaDonHang { get; set; } = maDonHang;
        public DateTime ThoiDiemDatHang { get; set; } = DateTime.Now;
        public int MaKhachHang { get; set; } = maKhachHang;
        public KhoGiaoNhan? KhoLuu { get; set; } = khoLuu;
        public int MaBuuKien { get; set; } = 0;
        public LoaiXe LoaiPhuongTien { get; set; } = loaiPhuongTien;
        public DateTime CapNhatCuoiCung { get; set; } = DateTime.Now;
        public TrangThaiDonHang TrangThaiDonHang { get; set; } = TrangThaiDonHang.DaTao;
        public int CuocPhi { get; set; } = cuocPhi;
        public int DanhGia { get; set; } = 0;
        public TaiXeCoHuu? TaiXeGiaoGap { get; set; } = null;
        public void SuaThongTin(KhoGiaoNhan? khoLuu, LoaiXe loaiPhuongTien, int cuocPhi)
        {
            KhoLuu = khoLuu;
            LoaiPhuongTien = loaiPhuongTien;
            CapNhatCuoiCung = DateTime.Now;
            CuocPhi = cuocPhi;
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
        public void XepVaoBuuKien(int maBuuKien)
        {
            MaBuuKien = maBuuKien;
        }
        public void NhanDon()
        {
            TrangThaiDonHang = TrangThaiDonHang.DangXuLy;
            CapNhatCuoiCung = DateTime.Now;
        }
        public void NhanGiaoGap(TaiXeCoHuu? taiXe)
        {
            TaiXeGiaoGap = taiXe;
        }
        public void DanhDauGiaoThanhCong()
        {
            TrangThaiDonHang = TrangThaiDonHang.GiaoThanhCong;
            CapNhatCuoiCung = DateTime.Now;
        }
        public static IEnumerable<DonHang> LayDonLuuChuaXep(KhoGiaoNhan kgn)
        {
            foreach (DonHang dh in Data.DanhSachDonHang!)
            {
                if (dh.TrangThaiDonHang == TrangThaiDonHang.DaTao && dh.KhoLuu == kgn && dh.MaBuuKien == 0)
                {
                    yield return dh;
                }
            }
        }
        public static IEnumerable<DonHang> LayDonHoaToc()
        {
            foreach (DonHang dh in Data.DanhSachDonHang!)
            {
                if (dh.TrangThaiDonHang == TrangThaiDonHang.DaTao && dh.LayChiTiet().LoaiVanChuyen == LoaiVanChuyen.HoaToc)
                {
                    yield return dh;
                }
            }
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
