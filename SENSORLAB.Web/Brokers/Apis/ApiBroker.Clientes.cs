using System.Text;
using System.Text.Json;
using SENSORLAB.Web.Models;

namespace SENSORLAB.Web.Brokers.Apis
{
    public partial class ApiBroker 
    {
        private const string ClientesRelativeUrl = "api/ControladorCliente";

        public async ValueTask<List<Cliente>> GetAllClienteAsync() =>
        
            await this.GetAsync<List<Cliente>>(ClientesRelativeUrl);

        public async ValueTask<Cliente> PostClienteAsync(Cliente cliente) =>
            await this.PostAsync(ClientesRelativeUrl, cliente);

        public async ValueTask<Cliente> DeleteClienteAsync(int idCliente) =>
            await this.DeleteAsync<Cliente>(ClientesRelativeUrl + "/" + idCliente);

        public async ValueTask<Cliente> UpdateClienteAsync(int idCliente, Cliente cliente) =>
            await this.PutAsync(ClientesRelativeUrl + "/" + idCliente, cliente);     
    }
    
}
