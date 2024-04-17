using OOP_Logistics.Nhân_Viên;

namespace OOP_Logistics.Quản_Trị_Viên
{
    public enum LoaiXe
    {
        XeTai = 5000,
        XeBanTai = 800,
        XeMay = 40
    }
    public enum TinhTrangXe
    {
        OnDinh,
        CanBaoDuong
    }
    public class PhuongTien(string bienSo, LoaiXe loaiXe)
    {
        public string? BienSoXe { get; set; } = bienSo;
        public LoaiXe LoaiXe { get; set; } = loaiXe;
        public double TaiTrong { get; set; } = (double)loaiXe;
        public TinhTrangXe TinhTrangXe { get; set; } = TinhTrangXe.OnDinh;
        public string LayLoaiXe()
        {
            switch (LoaiXe)
            {
                case LoaiXe.XeTai:
                    return "Xe tải";
                case LoaiXe.XeBanTai:
                    return "Xe bán tải";
                case LoaiXe.XeMay:
                    return "Xe máy";
                default:
                    return string.Empty;
            }
        }
        public string LayTinhTrang()
        {
            switch (TinhTrangXe)
            {
                case TinhTrangXe.OnDinh:
                    return "Ổn định";
                case TinhTrangXe.CanBaoDuong:
                    return "Cần bảo dưỡng";
                default:
                    return string.Empty;
            }
        }
        public void SuaThongTin(string bienSo)
        {
            BienSoXe = bienSo;
        }
        public int DemSoChuyenDaCho()
        {
            int soChuyen = 0;
            foreach (BuuKien bk in Data.DanhSachBuuKien!)
            {
                if (bk.ChuyenHang?.PhuongTienGiaoHang?.BienSoXe == BienSoXe && bk.TrangThai == TrangThaiBuuKien.DaNhan)
                {
                    soChuyen += bk.DanhSachDon!.Count;
                }
            }
            return soChuyen;
        }
        public void BaoDuong()
        {
            TinhTrangXe = TinhTrangXe.OnDinh;
        }
    }
}
