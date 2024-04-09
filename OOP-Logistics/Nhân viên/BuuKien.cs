namespace OOP_Logistics.Nhân_Viên
{
    internal class BuuKien
    {
        public string? BuuKienID { get; set; }
        public TaiXeCoHuu? ChuyenHang { get; set; }
        public string? DiaChiKho { get; set; }
        public string? DiaChiGiaoNhan { get; set; }
        public string? KichThuoc { get; set; }
        public string? LoaiBuuKien { get; set; }

        public double TinhKhoangCach(string batdau, string kethuc)
        {
            return 0;
        }

        public double TinhTrongLuong(string size)
        {
            return 0;
        }

        public double TinhCuocPhi(double weight, double distance, string loaibuukien)
        {
            return 0;
        }
    }
}
