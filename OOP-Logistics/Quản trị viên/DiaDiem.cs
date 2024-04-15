using static System.Math;

namespace OOP_Logistics.Quản_Trị_Viên
{
    public class DiaDiem(string? address, double latitude, double longitude)
    {
        public string? Address { get; set; } = address;
        public double Latitude { get; set; } = latitude;
        public double Longitude { get; set; } = longitude;
    }
}
