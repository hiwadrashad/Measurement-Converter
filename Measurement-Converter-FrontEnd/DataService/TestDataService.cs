using Measurement_Converter_FrontEnd.Interfaces;
using Measurement_Converter_FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Measurement_Converter_FrontEnd.DataService
{
    public class TestDataService : ITestDataService
    {
        private readonly HttpClient _httpClient;
        public TestDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<TestModel> Get(string id)
        {
            return await JsonSerializer.DeserializeAsync<TestModel>
                           (await _httpClient.GetStreamAsync($"api/api/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
