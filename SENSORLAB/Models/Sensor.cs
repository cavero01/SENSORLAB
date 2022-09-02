using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace SENSORLAB.Models
{
    public partial class Sensor
    {
        public Sensor()
        {
            ClienteSensors = new HashSet<ClienteSensor>();
        }
        [Key]
        public int IdSensor { get; set; }
        public string? Fabricante { get; set; }

        [JsonIgnore]
        public virtual ICollection<ClienteSensor> ClienteSensors { get; set; }
    }
}
