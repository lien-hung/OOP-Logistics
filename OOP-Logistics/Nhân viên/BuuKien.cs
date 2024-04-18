using OOP_Logistics.Khách_Hàng;
using System.Text.Json.Serialization;

namespace OOP_Logistics.Nhân_Viên
{
    public enum TrangThaiBuuKien
    {
        DaNhan,
        ChuaNhan
    }
    public class BuuKien
    {
        public int BuuKienID { get; set; }
        public List<DonHang> DanhSachDon { get; set; }
        public TaiXeCoHuu? ChuyenHang { get; set; }
        public double KhoiLuong { get; set; }
        public TrangThaiBuuKien TrangThai { get; set; }
        public BuuKien(int id, List<DonHang> danhSachDon, double khoiLuong)
        {
            BuuKienID = id;
            DanhSachDon = danhSachDon;
            ChuyenHang = null;
            KhoiLuong = khoiLuong;
            TrangThai = TrangThaiBuuKien.ChuaNhan;
        }
        [JsonConstructor]
        public BuuKien(int buuKienID, List<DonHang> danhSachDon, TaiXeCoHuu? chuyenHang, double khoiLuong, TrangThaiBuuKien trangThai)
        {
            BuuKienID = buuKienID;
            DanhSachDon = danhSachDon;
            ChuyenHang = chuyenHang;
            KhoiLuong = khoiLuong;
            TrangThai = trangThai;
        }
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
