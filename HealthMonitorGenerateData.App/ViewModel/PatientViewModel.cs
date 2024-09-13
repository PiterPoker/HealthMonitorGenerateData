using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HealthMonitorGenerateData.App.ViewModel
{
    public record PatientViewModel
    {
        [JsonPropertyName("gender")]
        public string Gender { get; set; }
        [Required]
        [JsonPropertyName("birthDate")]
        public DateTime BirthDate { get; set; }
        [JsonPropertyName("active")]
        public string? Status { get; set; }
        [DisplayName("name")]
        [JsonPropertyName("name")]
        public PersonViewModel Person { get; set; }

    }
}
