using SENSORLAB.Models;

namespace SENSORLAB.Services.Sensors
{
    public interface ISensorService
    {
        ValueTask<Sensor> AddSensorAsync(Sensor Sensor);
        ValueTask<Sensor> ModifySensorAsync(Sensor Sensor);
        ValueTask<Sensor> RemoveSensorByIdAsync(int SensorId);
        IQueryable<Sensor> RetrieveAllSensor();
        ValueTask<Sensor> RetrieveSensorByIdAsync(int SensorId);
    }
}