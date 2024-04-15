using OOP_Logistics.Khách_Hàng;
using OOP_Logistics.Nhân_Viên;

namespace OOP_Logistics
{
    public class Util
    {
        private static Color baseColor = Color.FromArgb(0, 0, 0, 0);
        public static void DarkenButtonColor(Button? btn)
        {
            if (btn is not null)
            {
                baseColor = btn.BackColor;
                btn.BackColor = Color.FromArgb(50, baseColor);
            }
        }
        public static void NormalizeButtonColor(Button? btn)
        {
            if (btn is not null)
            {
                btn.BackColor = baseColor;
            }
        }
        public static bool ExistsEmptyTextbox(Form frm)
        {
            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(ctrl.Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static async Task<string> GetRedirectedUrl(string url)
        {
            HttpClientHandler clientHandler = new() { AllowAutoRedirect = false };
            HttpClient client = new(clientHandler);
            HttpResponseMessage response = await client.GetAsync(url);
            try
            {
                string? location = response.Headers.GetValues("Location").FirstOrDefault();
                if (!Uri.IsWellFormedUriString(location, UriKind.Absolute))
                {
                    Uri pageUri = new(url);
                    location = $"{pageUri.Scheme}://{pageUri.Host}{location}";
                }
                return location;
            }
            catch
            {
                return string.Empty;
            }
        }
        public static void GetDataFromGoogleMaps(string url, out double latitude, out double longitude)
        {
            string partWithCoords = url[(url.IndexOf("/@") + 2)..];
            string coords = partWithCoords[..partWithCoords.IndexOf('/')];
            latitude = double.Parse(coords.Split(',')[0]);
            longitude = double.Parse(coords.Split(',')[1]);
        }
        public static int MaKHTiepTheo()
        {
            int i = 1;
            if (Data.DanhSachKhachHang != null)
            {
                foreach (KhachHang kh in Data.DanhSachKhachHang)
                {
                    if (kh.ID != i)
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
        public static int MaNVTiepTheo()
        {
            int i = 1;
            if (Data.DanhSachNhanVien != null)
            {
                foreach (NhanVien kh in Data.DanhSachNhanVien)
                {
                    if (kh.ID != i)
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
        public static TaiKhoan? SearchAccountByUsername(string username)
        {
            if (Data.DanhSachTaiKhoan != null)
            {
                foreach (TaiKhoan tk in Data.DanhSachTaiKhoan)
                {
                    if (tk.Username == username)
                    {
                        return tk;
                    }
                }
                return null;
            }
            return null;
        }
    }
}
