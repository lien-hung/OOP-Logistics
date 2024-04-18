using OOP_Logistics.Nhân_Viên;
using System.Text.Json.Serialization;

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
    public class PhuongTien
    {
        public string BienSoXe { get; set; }
        public LoaiXe LoaiXe { get; set; }
        public double TaiTrong { get; set; }
        public TinhTrangXe TinhTrangXe { get; set; }
        public PhuongTien(string bienSoXe, LoaiXe loaiXe)
        {
            BienSoXe = bienSoXe;
            LoaiXe = loaiXe;
            TaiTrong = (double)loaiXe;
            TinhTrangXe = TinhTrangXe.OnDinh;
        }
        [JsonConstructor]
        public PhuongTien(string bienSoXe, LoaiXe loaiXe, double taiTrong, TinhTrangXe tinhTrangXe)
        {
            BienSoXe = bienSoXe;
            LoaiXe = loaiXe;
            TaiTrong = taiTrong;
            TinhTrangXe = tinhTrangXe;
        }
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
