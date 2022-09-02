using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SENSORLAB.Models
{
    public partial class ClienteSensor
    {
        [Key]
        public int IdEvento { get; set; }
        [Key]
        public int IdCliente { get; set; }
        [Key]
        public int IdSensor { get; set; }
        public DateTime? Historico { get; set; }
        public int? Temp { get; set; }
        public int? Hum { get; set; }
        public string? Ubi { get; set; }
        public int? Custom1 { get; set; }
        public int? Custom2 { get; set; }
        public int? Custom3 { get; set; }
        [JsonIgnore]
        public virtual  Cliente IdClienteNavigation { get; set; } = null!;
        [JsonIgnore]
        public virtual Sensor IdSensorNavigation { get; set; } = null!;

    }
}
