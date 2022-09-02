using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace SENSORLAB.Web.Models
{
    public partial class Sensor
    {
        public int idSensor { get; set; }
        public string fabricante { get; set; }
    }
}

