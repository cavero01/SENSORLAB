using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SENSORLAB.Models;

namespace SENSORLAB.Brokers.Storages
{
    public partial class StorageBroker
    {
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;

        public async ValueTask<Cliente> InsertClienteAsync(Cliente Cliente)
        {
            using var broker = new StorageBroker(this.configuration);
           
            EntityEntry<Cliente> ClienteEntityEntry =
                await broker.Clientes.AddAsync(entity: Cliente);

            await broker.SaveChangesAsync();

            return ClienteEntityEntry.Entity;
        }

        public IQueryable<Cliente> SelectAllClientes() => this.Clientes;

        public async ValueTask<Cliente> SelectClienteByIdAsync(int ClienteId)
        {
            using var broker = new StorageBroker(this.configuration);
            broker.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return await broker.Clientes.FindAsync(ClienteId);
        }

        public async ValueTask<Cliente> UpdateClienteAsync(Cliente Cliente)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Cliente> ClienteEntityEntry =
                broker.Clientes.Update(entity: Cliente);

            await broker.SaveChangesAsync();

            return ClienteEntityEntry.Entity;
        }

        public async ValueTask<Cliente> DeleteClienteAsync(Cliente Cliente)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Cliente> ClienteEntityEntry = broker.Clientes.Remove(entity: Cliente);

            await broker.SaveChangesAsync();

            return ClienteEntityEntry.Entity;
        }

    }
}
