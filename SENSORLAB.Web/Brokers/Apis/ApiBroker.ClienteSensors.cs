using System.Text;
using System.Text.Json;
using SENSORLAB.Web.Models;

namespace SENSORLAB.Web.Brokers.Apis
{
    
        public partial class ApiBroker
        {
            private const string ClienteSensorRelativeUrl = "api/ControladorClienteSensors";

            public async ValueTask<List<ClienteSensor>> GetAllClienteSensorAsync() =>

                await this.GetAsync<List<ClienteSensor>>(ClienteSensorRelativeUrl);

            public async ValueTask<ClienteSensor> PostClienteSensorAsync(ClienteSensor clientesensor) =>
                await this.PostAsync(ClienteSensorRelativeUrl, clientesensor);

            public async ValueTask<ClienteSensor> DeleteClienteSensorAsync(Guid idClienteSensor, int idCliente, int idSensor) =>
                await this.DeleteAsync<ClienteSensor>(ClienteSensorRelativeUrl + "/" + idClienteSensor + "/" + idCliente + "/" + idSensor);

            public async ValueTask<ClienteSensor> UpdateClienteSensorAsync(Guid idClienteSensor, ClienteSensor clientesensor) =>
                await this.PutAsync(ClienteSensorRelativeUrl + "/" + idClienteSensor, clientesensor);
        }

    
}
