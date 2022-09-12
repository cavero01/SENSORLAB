using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SENSORLAB.Models
{
    //cliente view test
    public class ClienteView
    {

        
       
        public int IdCliente { get; set; }
        public string? Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Nacionalidad { get; set; }

        
        public int Premium { get; set; }


        
    }
}
