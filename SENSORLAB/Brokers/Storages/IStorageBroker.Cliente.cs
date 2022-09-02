using SENSORLAB.Models;

namespace SENSORLAB.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Cliente> DeleteClienteAsync(Cliente Cliente);
        ValueTask<Cliente> InsertClienteAsync(Cliente Cliente);
        IQueryable<Cliente> SelectAllClientes();
        ValueTask<Cliente> SelectClienteByIdAsync(int ClienteId);
        ValueTask<Cliente> UpdateClienteAsync(Cliente Cliente);
    }
}
