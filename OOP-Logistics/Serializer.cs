using System.Text.Encodings.Web;
using System.Text.Json;

namespace OOP_Logistics
{
    public class Serializer
    {
        private static readonly JsonSerializerOptions writeOptions = new() { 
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true
        };
        private static readonly JsonSerializerOptions readOptions = new() { AllowTrailingCommas = true };
        public static void WriteJsonToFile(string path, object? data)
        {
            string json = JsonSerializer.Serialize(data, writeOptions);
            File.WriteAllText(path, json);
        }
        public static T? DeserializeJsonFromFile<T>(string path)
        {
            try
            {
                string newJson = File.ReadAllText(path);
                return JsonSerializer.Deserialize<T>(newJson, readOptions)!;
            }
            catch
            {
                return default;
            }
        }
    }
}
