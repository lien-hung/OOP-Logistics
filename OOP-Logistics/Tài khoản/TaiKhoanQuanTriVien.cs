using OOP_Logistics.Nhân_Viên;

namespace OOP_Logistics.Quản_Trị_Viên
{
    public class TaiKhoanQuanTriVien(string username, string password) : TaiKhoan(username, password)
    {
        public static void ChiTraLuong(NhanVienLuanChuyen? nv)
        {
            Data.DanhSachLichSuLuong?.Add(new LichSuLuongThuong(nv!.ID, DateTime.Now, nv.TinhThuNhap()));
        }
    }
}
