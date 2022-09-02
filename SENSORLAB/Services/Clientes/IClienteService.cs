using SENSORLAB.Models;

namespace SENSORLAB.Services.Clientes
{
    public interface IClienteService
    {
        ValueTask<Cliente> AddClienteAsync(Cliente Cliente);
        ValueTask<Cliente> ModifyClienteAsync(Cliente Cliente);
        ValueTask<Cliente> RemoveClienteByIdAsync(int ClienteId);
        IQueryable<Cliente> RetrieveAllClientes();
        ValueTask<Cliente> RetrieveClienteByIdAsync(int ClienteId);
    }
}