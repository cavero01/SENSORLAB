namespace SENSORLAB.Web.Models
{
    public class ClienteSensorView
    {        
        public int IdEvento { get; set; }        
        public int IdCliente { get; set; }        
        public int IdSensor { get; set; }
        public DateTime? Historico { get; set; }
        public int? Temp { get; set; }
        public int? Hum { get; set; }
        public string? Ubi { get; set; }
        public int? Custom1 { get; set; }
        public int? Custom2 { get; set; }
        public int? Custom3 { get; set; }        
    }
}
