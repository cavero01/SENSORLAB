using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SENSORLAB.Models;

namespace SENSORLAB.Brokers.Storages
{
    public partial class StorageBroker
    {
        public virtual DbSet<ClienteSensor> ClienteSensors { get; set; } = null!;

        public async ValueTask<ClienteSensor> InsertClienteSensorAsync(ClienteSensor ClienteSensor)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<ClienteSensor> ClienteSensorEntityEntry =
                await broker.ClienteSensors.AddAsync(entity:ClienteSensor);

            await broker.SaveChangesAsync();

            return ClienteSensorEntityEntry.Entity;
        }

        public IQueryable<ClienteSensor> SelectAllClienteSensor() => this.ClienteSensors;

        public async ValueTask<ClienteSensor> SelectClienteSensorByIdAsync(int IdEvento)
        {
            using var broker = new StorageBroker(this.configuration);
            broker.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return await broker.ClienteSensors.FindAsync(IdEvento);
        }

        public async ValueTask<ClienteSensor> UpdateClienteSensorAsync(ClienteSensor ClienteSensor)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<ClienteSensor> ClienteSensorEntityEntry =
                broker.ClienteSensors.Update(entity: ClienteSensor);

            await broker.SaveChangesAsync();

            return ClienteSensorEntityEntry.Entity;
        }

        public async ValueTask<ClienteSensor> DeleteClienteSensorAsync(ClienteSensor ClienteSensor)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<ClienteSensor> ClienteEntityEntry = broker.ClienteSensors.Remove(entity: ClienteSensor);

            await broker.SaveChangesAsync();

            return ClienteEntityEntry.Entity;
        }

    }
}

