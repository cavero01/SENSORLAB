using SENSORLAB.Web.Models;

namespace SENSORLAB.Web.Brokers.Apis
{
    public partial interface IApiBroker
    {
        ValueTask<List<Cliente>> GetAllClienteAsync();
        ValueTask<Cliente> PostClienteAsync(Cliente cliente);
        ValueTask<Cliente> DeleteClienteAsync(int idcliente);
        ValueTask<Cliente> UpdateClienteAsync(int idcliente ,Cliente cliente);
    }
}
