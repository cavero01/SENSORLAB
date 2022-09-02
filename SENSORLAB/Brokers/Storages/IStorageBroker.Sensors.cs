using SENSORLAB.Models;

namespace SENSORLAB.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Sensor> DeleteSensorAsync(Sensor sensor);
        ValueTask<Sensor> InsertSensorAsync(Sensor sensor);
        IQueryable<Sensor> SelectAllSensor();
        ValueTask<Sensor> SelectSensorByIdAsync(int sensorId);
        ValueTask<Sensor> UpdateSensorAsync(Sensor sensor);
    }
}
