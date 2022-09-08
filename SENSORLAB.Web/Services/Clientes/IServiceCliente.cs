using SENSORLAB.Web.Models;

namespace SENSORLAB.Web.Services.Clientes
{
    public interface IServiceCliente
    {
        ValueTask<List<Cliente>> RetrieveAllClientesAsync();
        ValueTask<Cliente> AddClienteAsync(Cliente cliente);
        ValueTask<Cliente> RemoveClienteAsync(int idcliente);
        ValueTask<Cliente> ModifyClienteAsync(int idcliente,Cliente cliente);

    }
}