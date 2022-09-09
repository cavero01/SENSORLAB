

using SENSORLAB.Web.Models;
using System.Text;
using System.Text.Json;

namespace SENSORLAB.Web.Data

{
    public class Sensor3Services
    {
    //    private readonly IHttpClientFactory _httpClientFactory;

    //    public Sensor3Services(IHttpClientFactory httpClientFactory)
    //    {
    //        this._httpClientFactory = httpClientFactory;
    //    }
    //    public async Task<List<ClienteSensor>> GetClienteSensorsAsync()
    //    {
    //        var client = _httpClientFactory.CreateClient("sensorWebApi");
    //        var response = await client.GetAsync("ControladorClienteSensors");
    //            response.EnsureSuccessStatusCode();
    //            string responseBody = await response.Content.ReadAsStringAsync();
    //            try
    //            {
    //                List<ClienteSensor> result = JsonSerializer.Deserialize<List<ClienteSensor>>(responseBody);
    //                return result;
    //            }
    //            catch (Exception ex)
    //            {
    //                throw;
    //            }

            
    //        return new List<ClienteSensor>();
    //    }
    //    public async Task<ClienteSensor>PostClienteSensorsAsync(ClienteSensor clienteSensor)
    //    {
    //        var client = _httpClientFactory.CreateClient("sensorWebApi");
    //        var stringContent = new StringContent(JsonSerializer.Serialize(clienteSensor),Encoding.UTF8, "application/json");
    //            var response = await client.PostAsync("ControladorClienteSensors/", stringContent);
    //            response.EnsureSuccessStatusCode();
    //            string responseBody = await response.Content.ReadAsStringAsync();
    //            try
    //            {
    //                ClienteSensor result = JsonSerializer.Deserialize<ClienteSensor>(responseBody);
    //                return result;
    //            }
    //            catch (Exception ex)
    //            {
    //                throw;
    //            }
            
    //        return new ClienteSensor();
    //    }
    //    public async ValueTask<int> DeleteClienteSensorAsync(int idEvento, int idCliente, int idSensor)
    //    {
    //        var client = _httpClientFactory.CreateClient("sensorWebApi");
    //            //var stringContent = new StringContent(JsonSerializer.Serialize(sensor), Encoding.UTF8, "application/json");
    //            var response = await client.DeleteAsync("ControladorClienteSensors/" + idEvento + "/" + idCliente + "/" + idSensor);
    //            response.EnsureSuccessStatusCode();
    //            string responseBody = await response.Content.ReadAsStringAsync();
    //            try
    //            {

    //                return 1;
    //            }
    //            catch (Exception ex)
    //            {

    //                throw;
    //            }
            
    //        return 1;
    //    }
    //    public async ValueTask<int> UpdateClienteSensorAsync(int IdCliente, ClienteSensor clienteSensor)
    //    {
    //        var client = _httpClientFactory.CreateClient("sensorWebApi");

    //        var stringContent = new StringContent(JsonSerializer.Serialize(clienteSensor), Encoding.UTF8, "application/json");
    //            var response = await client.PutAsync("ControladorClienteSensors/" + IdCliente, stringContent);
    //            response.EnsureSuccessStatusCode();
    //            string responseBody = await response.Content.ReadAsStringAsync();
    //            try
    //            {
    //                return 1;
    //            }
    //            catch (Exception ex)
    //            {

    //                throw;
    //            }
    //        return 1;
    //    }

    }
}
