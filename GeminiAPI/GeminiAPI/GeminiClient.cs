using GeminiAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace GeminiAPI
{
    public sealed class GeminiClient
    {
        private readonly HttpClient _httpClient;
        private readonly GeminiOptions _options;

        private readonly JsonSerializerSettings _serializerSettings = new()
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            },
            Converters = { new StringEnumConverter() },
            NullValueHandling = NullValueHandling.Ignore
        };

        public GeminiClient(GeminiOptions options)
        {
            _options = options;

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_options.Url + "?key=" + _options.ApiKey);
        }

        public async Task<GeminiResponse> GenerateContentAsync(GeminiRequest request, CancellationToken cancellationToken)
        {
            var content = new StringContent(JsonConvert.SerializeObject(request, Newtonsoft.Json.Formatting.None, _serializerSettings), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("", content, cancellationToken);

            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();

            var geminiResponse = JsonConvert.DeserializeObject<GeminiResponse>(responseBody);

            return geminiResponse;
        }
    }
}
