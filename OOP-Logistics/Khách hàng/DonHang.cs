namespace OOP_Logistics.Khách_Hàng
{
    public class DonHang
    {
        public string? MaDonHang { get; set; }
        public DateTime NgayDatHang { get; set; }
        public List<ChiTietDonHang> ChiTietDon { get; set; }
        public KhachHang? KhachHang { get; set; }
        public string? MaBuuKien { get; set; }
        public string? TrangThai { get; set; }
        public DateTime CapNhatCuoiCung { get; set; }

        public enum TrangThaiDonHang
        {
            DaTao,
            DangXuLy,
            DaHuy,
            GiaoThanhCong
        }
        private TrangThaiDonHang _trangThaiDonHang;
        public DonHang()
        {
            ChiTietDon = []; // Khởi tạo danh sách chi tiết đơn hàng
        }
        public void ThemChiTietDonHang(ChiTietDonHang chiTiet)
        {
            if (ChiTietDon != null)
                ChiTietDon.Add(chiTiet);
            else
                ChiTietDon = [chiTiet];
        }

        public void SuaDonHang(DateTime ngayDatHang, List<ChiTietDonHang> chiTietDonHangs, KhachHang khachHang, string maBuuKien, string trangThai, DateTime capNhatCuoiCung)
        {
            if (_trangThaiDonHang == TrangThaiDonHang.DaTao)
            {
                NgayDatHang = ngayDatHang;
                ChiTietDon = chiTietDonHangs;
                KhachHang = khachHang;
                MaBuuKien = maBuuKien;
                TrangThai = trangThai;
                CapNhatCuoiCung = capNhatCuoiCung;
            }
            else
            {
                throw new InvalidOperationException("Không thể sửa đơn hàng sau khi đã xác nhận.");
            }
        }

        public void HuyDonHang()
        {
            if (_trangThaiDonHang == TrangThaiDonHang.DaTao)
            {
                TrangThai = "Đã hủy";
                CapNhatCuoiCung = DateTime.Now;
                _trangThaiDonHang = TrangThaiDonHang.DaHuy;
            }
            else
            {
                throw new InvalidOperationException("Không thể hủy đơn hàng sau khi đã xác nhận.");
            }
        }

        // Phương thức để xác nhận đơn hàng
        public void XacNhanDonHang()
        {
            TrangThai = "Đang xử lý";
            CapNhatCuoiCung = DateTime.Now;
            _trangThaiDonHang = TrangThaiDonHang.DangXuLy;
        }
    }

    public class ChiTietDonHang(string maDonHang, string moTa, double giaTri, bool giaTriCao)
    {
        public string MaDonHang { get; set; } = maDonHang;
        public string MoTa { get; set; } = moTa;
        public double GiaTri { get; set; } = giaTri;
        public bool GiaTriCao { get; set; } = giaTriCao;
    }
}
