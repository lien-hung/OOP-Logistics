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
    public class PhuongTien(string bienSo, LoaiXe loaiXe, TinhTrangXe tinhTrangXe)
    {
        public string? BienSoXe { get; set; } = bienSo;
        public LoaiXe LoaiXe { get; set; } = loaiXe;
        public double TaiTrong { get; set; } = (double)loaiXe;
        public TinhTrangXe TinhTrangXe { get; set; } = tinhTrangXe;
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
        public void SuaThongTin(string bienSo)
        {
            BienSoXe = bienSo;
        }
    }
}
