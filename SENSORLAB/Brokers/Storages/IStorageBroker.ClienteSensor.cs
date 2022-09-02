using SENSORLAB.Models;

namespace SENSORLAB.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<ClienteSensor> DeleteClienteSensorAsync(ClienteSensor clientesensor);
        ValueTask<ClienteSensor> InsertClienteSensorAsync(ClienteSensor clientesensor);
        IQueryable<ClienteSensor> SelectAllClienteSensor();
        ValueTask<ClienteSensor> SelectClienteSensorByIdAsync(int clientesensorId);
        ValueTask<ClienteSensor> SelectClienteSensorByIdAsync(int IdEvento, int IdCliente, int IdSensores);
        ValueTask<ClienteSensor> UpdateClienteSensorAsync(ClienteSensor clientesensor);
    }
}