using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace SENSORLAB.Web.Models
{

    public partial class Cliente
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public DateTime fecha { get; set; }
        public string nacionalidad { get; set; }
        public int premium { get; set; }
   
    }
}
