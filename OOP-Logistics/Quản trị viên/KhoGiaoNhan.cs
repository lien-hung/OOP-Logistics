namespace OOP_Logistics.Quản_Trị_Viên
{
    public class KhoGiaoNhan(int maKho, DiaDiem? diaDiemKho)
    {
        public int MaKho { get; set; } = maKho;
        public DiaDiem? DiaDiemKho { get; set; } = diaDiemKho;
    }
}
