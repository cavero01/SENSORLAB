using System.Text;
using System.Text.Json;
using SENSORLAB.Web.Models;

namespace SENSORLAB.Web.Brokers.Apis
{
    public partial class ApiBroker
    {
        private const string SensorsRelativeUrl = "api/ControladorSensor";

        public async ValueTask<List<Sensor>> GetAllSensorAsync() =>

            await this.GetAsync<List<Sensor>>(SensorsRelativeUrl);

        public async ValueTask<Sensor> PostSensorAsync(Sensor sensor) =>
            await this.PostAsync(SensorsRelativeUrl, sensor);

        public async ValueTask<Sensor> DeleteSensorAsync(int idSensor) =>
            await this.DeleteAsync<Sensor>(SensorsRelativeUrl + "/" + idSensor);

        public async ValueTask<Sensor> UpdateSensorAsync(int idSensor, Sensor sensor) =>
            await this.PutAsync(SensorsRelativeUrl + "/" + idSensor, sensor);
    }
}
