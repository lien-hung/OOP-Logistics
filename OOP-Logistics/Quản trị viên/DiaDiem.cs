using static System.Math;

namespace OOP_Logistics.Quản_Trị_Viên
{
    public class DiaDiem(string? address, double latitude, double longitude)
    {
        public string? Address { get; set; } = address;
        public double Latitude { get; set; } = latitude;
        public double Longitude { get; set; } = longitude;
        private static double Rad(double angle)
        {
            return angle * PI / 180.0d;
        }
        private static double Havf(double diff)
        {
            return Pow(Sin(Rad(diff) / 2d), 2); // sin^2(diff / 2)
        }
        public static double Distance(DiaDiem pointA, DiaDiem pointB)
        {
            double latA = pointA.Latitude, lonA = pointA.Longitude;
            double latB = pointB.Latitude, lonB = pointB.Longitude;
            return 12745.6 * Asin(Sqrt(Havf(latB - latA) + Cos(Rad(latA)) * Cos(Rad(latB)) * Havf(lonB - lonA))); // (in kilometers; 12745.6 = 2 * Earth's radius)
        }
        public static IEnumerable<string> GetAddresses()
        {
            foreach (DiaDiem loc in Data.DanhSachDiaDiem!)
            {
                yield return loc.Address!;
            }
        }
        public static DiaDiem? GetLocation(string address)
        {
            foreach (DiaDiem loc in Data.DanhSachDiaDiem!)
            {
                if (loc.Address == address)
                {
                    return loc;
                }
            }
            return null;
        }
        public KhoGiaoNhan GetNearestWarehouse()
        {
            List<double> distances = [];
            foreach (KhoGiaoNhan kho in Data.DanhSachKhoGiaoNhan!)
            {
                distances.Add(Distance(this, kho.DiaDiemKho!));
            }
            double min = distances[0];
            int minIndex = 0;
            for (int i = 1; i < distances.Count; ++i)
            {
                if (distances[i] < min)
                {
                    min = distances[i];
                    minIndex = i;
                }
            }
            return Data.DanhSachKhoGiaoNhan[minIndex];
        }
    }
}
