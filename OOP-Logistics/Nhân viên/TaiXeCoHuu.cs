using OOP_Logistics.Khách_Hàng;
using OOP_Logistics.Quản_Trị_Viên;

namespace OOP_Logistics.Nhân_Viên
{
    public class TaiXeCoHuu(int MaNhanVien, string HoTen, string SoDienThoai, string SoCCCD, PhuongTien phuongTien) : NhanVien(MaNhanVien, HoTen, SoDienThoai, SoCCCD)
    {
        public PhuongTien? PhuongTienGiaoHang { get; set; } = phuongTien;
        public IEnumerable<DonHang> LayDonHangDaNhan()
        {
            foreach (BuuKien bk in Data.DanhSachBuuKien!)
            {
                if (bk.ChuyenHang?.ID == ID)
                {
                    foreach (DonHang dh in bk.DanhSachDon!)
                    {
                        yield return dh;
                    }
                }
            }
            foreach (DonHang dh in Data.DanhSachDonHang!)
            {
                if (dh.TaiXeGiaoGap?.ID == ID)
                {
                    yield return dh;
                }
            }
        }
        public override double TinhThuNhap()
        {
            double totalIncome = 0;
            List<DonHang> donHangDaNhan = new(LayDonHangDaNhan());
            foreach (DonHang dh in donHangDaNhan)
            {
                if (dh.TrangThaiDonHang == TrangThaiDonHang.GiaoThanhCong)
                {
                    totalIncome += dh.CuocPhi;
                }
            }
            return totalIncome;
        }
        public double LayDiemDanhGia()
        {
            int totalStars = 0;
            List<DonHang> donHangDaNhan = new(LayDonHangDaNhan());
            if (donHangDaNhan.Count > 0)
            {
                foreach (DonHang dh in donHangDaNhan)
                {
                    if (dh.TrangThaiDonHang == TrangThaiDonHang.GiaoThanhCong)
                    {
                        totalStars += dh.DanhGia;
                    }
                }
                return totalStars / donHangDaNhan.Count;
            }
            else
            {
                return 0;
            }
        }
    }
}
