using GestionBiblioteca.Models;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace GestionBiblioteca.Servicios
{
    public class ApiClient
    {
        private readonly string apiKey;
        private readonly string baseUrl;

        public ApiClient()
        {
            var configText = File.ReadAllText("apiConfig.json");
            var config = JsonConvert.DeserializeObject<ApiConfig>(configText);
            apiKey = config.ApiKey;
            baseUrl = config.BaseUrl;
        }

        public async Task<ApiResponse> BuscarPorDniAsync(string dni)
        {
            string apiUrl = $"{baseUrl}{dni}?api_token={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(json);
                    return apiResponse;
                }

                return null;
            }
        }
    }

    public class ApiResponse
    {
        public bool Success { get; set; }
        public Usuario Data { get; set; }
    }

    public class ApiConfig
    {
        public string ApiKey { get; set; }
        public string BaseUrl { get; set; }
    }
}
