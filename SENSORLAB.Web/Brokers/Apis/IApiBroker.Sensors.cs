using SENSORLAB.Web.Models;

namespace SENSORLAB.Web.Brokers.Apis
{
    public partial interface IApiBroker
    {
        ValueTask<List<Sensor>> GetAllSensorAsync();
        ValueTask<Sensor> PostSensorAsync(Sensor sensor);
        ValueTask<Sensor> DeleteSensorAsync(int idsensor);
        ValueTask<Sensor> UpdateSensorAsync(int idsensor, Sensor sensor);
    }
}
