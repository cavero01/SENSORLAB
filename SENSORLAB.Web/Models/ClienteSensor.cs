using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SENSORLAB.Web.Models
{
    public partial class ClienteSensor
    {
      
        public int idEvento { get; set; }
       
        public int idCliente { get; set; }
        
        public int idSensor { get; set; }
        public DateTime? historico { get; set; }
        public int? temp { get; set; }
        public int? hum { get; set; }
        public string? ubi { get; set; }
        public int? custom1 { get; set; }
        public int? custom2 { get; set; }
        public int? custom3 { get; set; }      

    }
}
