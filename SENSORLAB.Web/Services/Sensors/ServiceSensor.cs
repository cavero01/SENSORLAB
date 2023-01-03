using SENSORLAB.Web.Brokers.Apis;
using SENSORLAB.Web.Models;

namespace SENSORLAB.Web.Services.Sensors
{
    public class ServiceSensor : IServiceSensor
    {
        private readonly IApiBroker apiBroker;

        public ServiceSensor(IApiBroker apiBroker)
        {
            this.apiBroker = apiBroker;
        }

        public async ValueTask<List<Sensor>> RetrieveAllSensorAsync()
        {
            return await this.apiBroker.GetAllSensorAsync();
        }

        public async ValueTask<Sensor> AddSensorAsync(Sensor sensor)
        {
            return await this.apiBroker.PostSensorAsync(sensor);
        }

        public async ValueTask<Sensor> RemoveSensorAsync(int idsensor)
        {
            return await this.apiBroker.DeleteSensorAsync(idsensor);
        }

        public async ValueTask<Sensor> ModifySensorAsync(int idsensor, Sensor sensor)
        {
            return await this.apiBroker.UpdateSensorAsync(idsensor, sensor);
        }


    }
}
