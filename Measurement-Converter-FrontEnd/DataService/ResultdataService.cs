using Measurement_Converter_Library.DTOs;
using Measurement_Converter_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Measurement_Converter_FrontEnd.DataService
{
    public class ResultdataService : IResultDataService
    {
        private readonly HttpClient _httpClient;
        public ResultdataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ConversionTypeResult> Get(double value)
        {
            return await JsonSerializer.DeserializeAsync<ConversionTypeResult>
                           (await _httpClient.GetStreamAsync($"api/api/{value}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
