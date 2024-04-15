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
    }
}
