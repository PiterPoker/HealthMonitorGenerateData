using HealthMonitorGenerateData.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HealthMonitorGenerateData.App.Services
{
    public class ApiClient
    {

        private readonly HttpClient _httpClient;

        public ApiClient(string baseAddress, GeneratePacient pacient)
        {
            pacient.RegistrationPublished += RegistrationAsync;
            _httpClient = new HttpClient { BaseAddress = new Uri(baseAddress) };
        }

        public async Task<HttpResponseMessage> RegistrationAsync(string url, PatientViewModel patient)
        {
            return await _httpClient.PostAsJsonAsync(url, patient);
        }
    }
}
