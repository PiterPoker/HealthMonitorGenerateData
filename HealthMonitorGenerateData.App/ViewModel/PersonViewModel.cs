using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HealthMonitorGenerateData.App.ViewModel
{
    public record PersonViewModel
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        [Required]
        [JsonPropertyName("family")]
        public string Family { get; set; }
        [Required]
        [JsonPropertyName("use")]
        public string RecordType { get; set; }
        [JsonPropertyName("given")]
        public string[] Given { get; set; }
    }
}
