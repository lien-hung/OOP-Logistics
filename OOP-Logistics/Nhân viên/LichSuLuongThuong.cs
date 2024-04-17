namespace OOP_Logistics.Nhân_Viên
{
    public class LichSuLuongThuong(int id, DateTime ngayTra, double tienTra)
    {
        public int ID { get; set; } = id;
        public DateTime NgayChiTra { get; set; } = ngayTra;
        public double SoTienChiTra { get; set; } = tienTra;
    }
}
