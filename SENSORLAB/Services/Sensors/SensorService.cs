using SENSORLAB.Brokers.Storages;
using SENSORLAB.Models;

namespace SENSORLAB.Services.Sensors
{
    public class SensorService : ISensorService
    {
        private readonly IStorageBroker storageBroker;

        public SensorService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public ValueTask<Sensor> AddSensorAsync(Sensor sensor)
        {
            try
            {
                return this.storageBroker.InsertSensorAsync(sensor);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<Sensor> RetrieveAllSensor()
        
        {
            try
            {
                return this.storageBroker.SelectAllSensor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ValueTask<Sensor> RetrieveSensorByIdAsync(int SensorId)
        {
            try
            {
                return this.storageBroker.SelectSensorByIdAsync(SensorId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ValueTask<Sensor> ModifySensorAsync(Sensor Sensor)
        {
            try
            {
                return this.storageBroker.UpdateSensorAsync(Sensor);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ValueTask<Sensor> RemoveSensorByIdAsync(int SensorId)
        {
            try
            {
                Sensor maybeSensor = this.storageBroker.SelectSensorByIdAsync(SensorId).Result;

                return this.storageBroker.DeleteSensorAsync(maybeSensor);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
