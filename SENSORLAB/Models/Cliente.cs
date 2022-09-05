using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
// git test 

namespace SENSORLAB.Models
{

    public partial class Cliente
    {
        
        public Cliente()
        {
            ClienteSensors = new HashSet<ClienteSensor>();
        }
        [Key]
        public int IdCliente { get; set; }
        public string? Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Nacionalidad { get; set; }
        public int Premium { get; set; }
        [JsonIgnore]
        public virtual ICollection<ClienteSensor> ClienteSensors { get; set; }

    }
}
