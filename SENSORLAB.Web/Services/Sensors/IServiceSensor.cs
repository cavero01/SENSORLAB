using SENSORLAB.Web.Models;

namespace SENSORLAB.Web.Services.Sensors
{
    public  interface IServiceSensor
    {
        ValueTask<Sensor> AddSensorAsync(Sensor sensor);
        ValueTask<Sensor> ModifySensorAsync(int idsensor, Sensor sensor);
        ValueTask<Sensor> RemoveSensorAsync(int idsensor);
        ValueTask<List<Sensor>> RetrieveAllSensorAsync();
    }
}