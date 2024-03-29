﻿using SENSORLAB.Brokers.Storages;
using SENSORLAB.Models;
namespace SENSORLAB.Services.Clientesensors
{
    public class ClientesensorService : IClientesensorService
    {
        private readonly IStorageBroker storageBroker;

        public ClientesensorService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public ValueTask<ClienteSensor> AddClientesensorAsync(ClienteSensor clientesensor)
        {
            try
            {
                return this.storageBroker.InsertClienteSensorAsync(clientesensor);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<ClienteSensor> RetrieveAllClientesensors()
        {
            try
            {
                return this.storageBroker.SelectAllClienteSensor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ValueTask<ClienteSensor> RetrieveClientesensorByIdAsync(Guid idclientesensor, int idcliente, int idsensor)
        {
            try
            {
                return this.storageBroker.SelectClienteSensorByIdAsync(idclientesensor, idcliente, idsensor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ValueTask<ClienteSensor> ModifyClientesensorAsync(ClienteSensor clientesensor)
        {
            try
            {
                return this.storageBroker.UpdateClienteSensorAsync(clientesensor);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ValueTask<ClienteSensor> RemoveClientesensorByIdAsync(Guid idclientesensor, int idcliente, int idsensor)
        {
            try
            {
                ClienteSensor maybeClientesensor = this.storageBroker.SelectClienteSensorByIdAsync(idclientesensor, idcliente, idsensor ).Result;

                return this.storageBroker.DeleteClienteSensorAsync(maybeClientesensor);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}