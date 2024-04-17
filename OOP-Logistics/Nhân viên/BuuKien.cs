using OOP_Logistics.Khách_Hàng;

namespace OOP_Logistics.Nhân_Viên
{
    public enum TrangThaiBuuKien
    {
        DaNhan,
        ChuaNhan
    }
    public class BuuKien(int id, List<DonHang> danhSachDon, double khoiLuong)
    {
        public int BuuKienID { get; set; } = id;
        public List<DonHang>? DanhSachDon { get; set; } = danhSachDon;
        public TaiXeCoHuu? ChuyenHang { get; set; } = null;
        public double KhoiLuong { get; set; } = khoiLuong;
        public TrangThaiBuuKien TrangThai { get; set; } = TrangThaiBuuKien.ChuaNhan;
        public void NhanBuuKien(TaiXeCoHuu? taiXe)
        {
            ChuyenHang = taiXe;
            TrangThai = TrangThaiBuuKien.DaNhan;
        }
        public static IEnumerable<BuuKien> LayBuuKienChoNhan()
        {
            foreach (BuuKien bk in Data.DanhSachBuuKien!)
            {
                if (bk.TrangThai == TrangThaiBuuKien.ChuaNhan)
                {
                    yield return bk;
                }
            }
        }
        public static int MaTiepTheo()
        {
            int i = 1;
            if (Data.DanhSachBuuKien!.Count != 0)
            {
                foreach (BuuKien bk in Data.DanhSachBuuKien)
                {
                    if (bk.BuuKienID != i)
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
