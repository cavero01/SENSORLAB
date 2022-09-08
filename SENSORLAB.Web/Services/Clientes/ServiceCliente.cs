using SENSORLAB.Web.Brokers.Apis;
using SENSORLAB.Web.Models;

namespace SENSORLAB.Web.Services.Clientes
{
    public class ServiceCliente : IServiceCliente
    {
        private readonly IApiBroker apiBroker;

        public ServiceCliente(IApiBroker apiBroker)
        {
            this.apiBroker = apiBroker;
        }

        public async ValueTask<List<Cliente>> RetrieveAllClientesAsync()
        {
            return await this.apiBroker.GetAllClienteAsync();
        }

        public async ValueTask<Cliente> AddClienteAsync(Cliente cliente)
        {
            return await this.apiBroker.PostClienteAsync(cliente);
        }

        public async ValueTask<Cliente> RemoveClienteAsync(int idcliente)
        {
            return await this.apiBroker.DeleteClienteAsync(idcliente);
        }

        public async ValueTask<Cliente> ModifyClienteAsync(int idcliente, Cliente cliente)
        {
            return await this.apiBroker.UpdateClienteAsync(idcliente, cliente);
        }


    }
}
