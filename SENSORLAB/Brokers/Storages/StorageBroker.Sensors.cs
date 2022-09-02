using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SENSORLAB.Models;


namespace SENSORLAB.Brokers.Storages
{ 
public partial class StorageBroker
{
    public virtual DbSet<Sensor> Sensors { get; set; } = null!;

    public async ValueTask<Sensor> InsertSensorAsync(Sensor Sensor)
    {
        using var broker = new StorageBroker(this.configuration);

        EntityEntry<Sensor> SensorEntityEntry =
            await broker.Sensors.AddAsync(entity: Sensor);

        await broker.SaveChangesAsync();

        return SensorEntityEntry.Entity;
    }

    public IQueryable<Sensor> SelectAllSensor() => this.Sensors;

    public async ValueTask<Sensor> SelectSensorByIdAsync(int SensorId)
    {
        using var broker = new StorageBroker(this.configuration);
        broker.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

        return await broker.Sensors.FindAsync(SensorId);
    }

    public async ValueTask<Sensor> UpdateSensorAsync(Sensor sensor)
    {
        using var broker = new StorageBroker(this.configuration);

        EntityEntry<Sensor> SensorEntityEntry =
            broker.Sensors.Update(entity: sensor);

        await broker.SaveChangesAsync();

        return SensorEntityEntry.Entity;
    }

    public async ValueTask<Sensor> DeleteSensorAsync(Sensor Sensor)
    {
        using var broker = new StorageBroker(this.configuration);

        EntityEntry<Sensor> SensorEntityEntry = broker.Sensors.Remove(entity: Sensor);

        await broker.SaveChangesAsync();

        return SensorEntityEntry.Entity;
    }

}
}