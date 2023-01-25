using SENSORLAB.Web.Models;

namespace SENSORLAB.Web.Brokers.Apis
{
    public partial interface IApiBroker
    {
        ValueTask<List<ClienteSensor>> GetAllClienteSensorAsync();
        ValueTask<ClienteSensor> PostClienteSensorAsync(ClienteSensor clientesensor);
        ValueTask<ClienteSensor> DeleteClienteSensorAsync(Guid idEvento, int idCliente, int idSensor);
        ValueTask<ClienteSensor> UpdateClienteSensorAsync(Guid idEvento, ClienteSensor clientesensor);
    }
}
