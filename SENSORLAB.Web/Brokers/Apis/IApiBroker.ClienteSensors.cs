using SENSORLAB.Web.Models;

namespace SENSORLAB.Web.Brokers.Apis
{
    public partial interface IApiBroker
    {
        ValueTask<List<ClienteSensor>> GetAllClienteSensorAsync();
        ValueTask<ClienteSensor> PostClienteSensorAsync(ClienteSensor clientesensor);
        ValueTask<ClienteSensor> DeleteClienteSensorAsync(int idEvento, int idCliente, int idSensor);
        ValueTask<ClienteSensor> UpdateClienteSensorAsync(int idEvento, ClienteSensor clientesensor);
    }
}
