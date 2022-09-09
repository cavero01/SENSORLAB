using SENSORLAB.Web.Models;

namespace SENSORLAB.Web.Services.ClienteSensors
{
    public interface IServiceClienteSensor
    {
        ValueTask<ClienteSensor> AddClienteSensorAsync(ClienteSensor clientesensor);
        ValueTask<ClienteSensor> ModifyClienteSensorAsync(int idEvento, ClienteSensor clientesensor);
        ValueTask<ClienteSensor> RemoveClienteSensorAsync(int idEvento, int idCliente, int idSensor);
        ValueTask<List<ClienteSensor>> RetrieveAllClienteSensorAsync();
    }
}