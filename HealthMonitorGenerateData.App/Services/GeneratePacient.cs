using HealthMonitorGenerateData.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthMonitorGenerateData.App.Services
{
    public class GeneratePacient
    {
        public delegate Task<HttpResponseMessage> NewBirthEventHandler(string url, PatientViewModel patient);
        public event NewBirthEventHandler RegistrationPublished;
        public async Task<HttpResponseMessage> NewBirth(string url, PatientViewModel patient)
        {
            return await RegistrationPublished?.Invoke(url, patient);
        }
    }
}
