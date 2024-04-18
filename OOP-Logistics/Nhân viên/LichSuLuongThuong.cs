namespace OOP_Logistics.Nhân_Viên
{
    public class LichSuLuongThuong(int id, DateTime ngayChiTra, double soTienChiTra)
    {
        public int ID { get; set; } = id;
        public DateTime NgayChiTra { get; set; } = ngayChiTra;
        public double SoTienChiTra { get; set; } = soTienChiTra;
    }
}
