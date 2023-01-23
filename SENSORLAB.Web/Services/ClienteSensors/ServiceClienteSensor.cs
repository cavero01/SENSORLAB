using SENSORLAB.Web.Brokers.Apis;
using SENSORLAB.Web.Models;

namespace SENSORLAB.Web.Services.ClienteSensors
{
    public class ServiceClienteSensor : IServiceClienteSensor
    {
        private readonly IApiBroker apiBroker;

        public ServiceClienteSensor(IApiBroker apiBroker)
        {
            this.apiBroker = apiBroker;
        }

        public async ValueTask<List<ClienteSensor>> RetrieveAllClienteSensorAsync()
        {
            return await this.apiBroker.GetAllClienteSensorAsync();
        }

        public async ValueTask<ClienteSensor> AddClienteSensorAsync(ClienteSensor clientesensor)
        {
            return await this.apiBroker.PostClienteSensorAsync(clientesensor);
        }

        public async ValueTask<ClienteSensor> RemoveClienteSensorAsync(Guid idEvento, int idCliente, int idSensor)
        {
            return await this.apiBroker.DeleteClienteSensorAsync(idEvento, idCliente, idSensor);
        }

        public async ValueTask<ClienteSensor> ModifyClienteSensorAsync(Guid idEvento, ClienteSensor clientesensor)
        {
            return await this.apiBroker.UpdateClienteSensorAsync(idEvento, clientesensor);
        }


    }
}
