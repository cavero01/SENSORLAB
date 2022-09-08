using System.Text;
using System.Text.Json;
using SENSORLAB.Web.Models;

namespace SENSORLAB.Web.Brokers.Apis
{
    public partial class ApiBroker 
    {
        private const string ClientesRelativeUrl = "api/ControladorCliente";

        public async ValueTask<List<Cliente>> GetAllClienteAsync() =>
        
            await this.GetAsync<List<Cliente>>(ClientesRelativeUrl);

        public async ValueTask<Cliente> PostClienteAsync(Cliente cliente) =>
            await this.PostAsync(ClientesRelativeUrl, cliente);

        public async ValueTask<Cliente> DeleteClienteAsync(int idCliente) =>
            await this.DeleteAsync<Cliente>(ClientesRelativeUrl + "/" + idCliente);

        public async ValueTask<Cliente> UpdateClienteAsync(int idCliente, Cliente cliente) =>
            await this.PutAsync(ClientesRelativeUrl + "/" + idCliente, cliente);     
    }
    //    public async Task<Cliente> PostClienteAsync(Cliente cliente)
    //    {
          
    //        var stringContent = new StringContent(JsonSerializer.Serialize(cliente), Encoding.UTF8, "application/json");
    //        var response = await client.PostAsync("ControladorCliente/", stringContent);
    //        response.EnsureSuccessStatusCode();
    //        string responseBody = await response.Content.ReadAsStringAsync();
    //        try
    //        {
    //            Cliente result = JsonSerializer.Deserialize<Cliente>(responseBody);
    //            return result;
    //        }
    //        catch (Exception ex)
    //        {

    //            throw;
    //        }
    //        return new Cliente();
    //    }
    //    public async ValueTask<int> DeleteClienteAsync(int IdCliente)
    //    {
    //        var client = _httpClientFactory.CreateClient("sensorWebApi");
    //        //var stringContent = new StringContent(JsonSerializer.Serialize(sensor), Encoding.UTF8, "application/json");
    //        var response = await client.DeleteAsync("ControladorCliente/" + IdCliente);
    //        response.EnsureSuccessStatusCode();
    //        string responseBody = await response.Content.ReadAsStringAsync();
    //        try
    //        {

    //            return 1;
    //        }
    //        catch (Exception ex)
    //        {

    //            throw;
    //        }
    //        return 1;
    //    }
    //    public async ValueTask<int> UpdateClienteAsync(int IdCliente, Cliente cliente)
    //    {
    //        var client = _httpClientFactory.CreateClient("sensorWebApi");


    //        var stringContent = new StringContent(JsonSerializer.Serialize(cliente), Encoding.UTF8, "application/json");
    //        var response = await client.PutAsync("ControladorCliente/" + IdCliente, stringContent);
    //        response.EnsureSuccessStatusCode();
    //        string responseBody = await response.Content.ReadAsStringAsync();
    //        try
    //        {
    //            return 1;
    //        }
    //        catch (Exception ex)
    //        {

    //            throw;
    //        }

    //        return 1;
    //    }
    //}
//}


//}
}
