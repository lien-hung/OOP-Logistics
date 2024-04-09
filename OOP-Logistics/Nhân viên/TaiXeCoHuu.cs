namespace OOP_Logistics.Nhân_Viên
{
    internal class TaiXeCoHuu : NhanVien
    {
        public string? PhuongTienGiaoHang { get; set; }
        public int DiemDanhGia { get; set; }
        public void NhanDon(BuuKien buuKien)
        {
            Console.WriteLine($"Đã nhận đơn {buuKien}. Đang vận chuyển...");
        }

        public decimal TinhThuNhap(List<BuuKien> danhSachDonHang)
        {
            decimal tongThuNhap = 0;
            foreach (var buuKien in danhSachDonHang)
            {
                // tongThuNhap += buuKien.CuocPhi;
            }
            return tongThuNhap;
        }
    }
}
