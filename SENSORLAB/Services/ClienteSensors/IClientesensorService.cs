using SENSORLAB.Models;
namespace SENSORLAB.Services.Clientesensors
{
    public interface IClientesensorService
    {
        ValueTask<ClienteSensor> AddClientesensorAsync(ClienteSensor clienteSensor);    
        ValueTask<ClienteSensor> ModifyClientesensorAsync(ClienteSensor clienteSensor);
        ValueTask<ClienteSensor> RemoveClientesensorByIdAsync(int idclientesensor, int idcliente, int idsensor);
        IQueryable<ClienteSensor> RetrieveAllClientesensors();
        ValueTask<ClienteSensor> RetrieveClientesensorByIdAsync(int idclientesensor, int idcliente, int idsensor);
    }
}