using SENSORLAB.Brokers.Storages;
using SENSORLAB.Models;

namespace SENSORLAB.Services.Clientes
{
    public class ClienteService : IClienteService
    {
        private readonly IStorageBroker storageBroker;

        public ClienteService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public ValueTask<Cliente> AddClienteAsync(Cliente Cliente)
        {
            try
            {
                return this.storageBroker.InsertClienteAsync(Cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<Cliente> RetrieveAllClientes()
        {
            try
            {
                return this.storageBroker.SelectAllClientes();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ValueTask<Cliente> RetrieveClienteByIdAsync(int ClienteId)
        {
            try
            {
                return this.storageBroker.SelectClienteByIdAsync(ClienteId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ValueTask<Cliente> ModifyClienteAsync(Cliente Cliente)
        {
            try
            {
                return this.storageBroker.UpdateClienteAsync(Cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ValueTask<Cliente> RemoveClienteByIdAsync(int ClienteId)
        {
            try
            {
                Cliente maybeCliente = this.storageBroker.SelectClienteByIdAsync(ClienteId).Result;

                return this.storageBroker.DeleteClienteAsync(maybeCliente);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
