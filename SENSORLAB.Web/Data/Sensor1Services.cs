

using SENSORLAB.Web.Models;
using System.Text;
using System.Text.Json;

namespace SENSORLAB.Web.Data
{
    public class Sensor1Services
    {
        //    private readonly IHttpClientFactory _httpClientFactory;

        //    //public Sensor1Services(IHttpClientFactory httpClientFactory)
        //    //{
        //    //    this._httpClientFactory = httpClientFactory;
        //    //}
        //    //public async Task<List<Cliente>> GetClienteAsync()
        //    //{
        //    //    var client = _httpClientFactory.CreateClient("sensorWebApi");

        //    //    var response = await client.GetAsync("ControladorCliente");
        //    //        response.EnsureSuccessStatusCode();
        //    //        string responseBody = await response.Content.ReadAsStringAsync();
        //    //        try
        //    //        {
        //    //            List<Cliente> result = JsonSerializer.Deserialize<List<Cliente>>(responseBody);
        //    //            return result;
        //    //        }
        //    //        catch (Exception ex)
        //    //        {

        //    //            throw;
        //    //        }


        //    //return new List<Cliente>();
        //    //}
        //    //public async Task<Cliente> PostClienteAsync(Cliente cliente)
        //    //{
        //    //    var client = _httpClientFactory.CreateClient("sensorWebApi");
        //    //    var stringContent = new StringContent(JsonSerializer.Serialize(cliente), Encoding.UTF8, "application/json");
        //    //        var response = await client.PostAsync("ControladorCliente/", stringContent);
        //    //        response.EnsureSuccessStatusCode();
        //    //        string responseBody = await response.Content.ReadAsStringAsync();
        //    //        try
        //    //        {
        //    //            Cliente result = JsonSerializer.Deserialize<Cliente>(responseBody);
        //    //            return result;
        //    //        }
        //    //        catch (Exception ex)
        //    //        {

        //    //            throw;
        //    //        }
        //    //    return new Cliente();
        //    //}
        //    //public async ValueTask<int> DeleteClienteAsync(int IdCliente)
        //    //{
        //    //    var client = _httpClientFactory.CreateClient("sensorWebApi");
        //    //        //var stringContent = new StringContent(JsonSerializer.Serialize(sensor), Encoding.UTF8, "application/json");
        //    //        var response = await client.DeleteAsync("ControladorCliente/" + IdCliente);
        //    //        response.EnsureSuccessStatusCode();
        //    //        string responseBody = await response.Content.ReadAsStringAsync();
        //    //        try
        //    //        {

        //    //            return 1;
        //    //        }
        //    //        catch (Exception ex)
        //    //        {

        //    //            throw;
        //    //        }
        //    //    return 1;
        //    //}
        //    public async ValueTask<int> UpdateClienteAsync(int IdCliente, Cliente cliente)
        //    {
        //        var client = _httpClientFactory.CreateClient("sensorWebApi");


        //            var stringContent = new StringContent(JsonSerializer.Serialize(cliente), Encoding.UTF8, "application/json");
        //            var response = await client.PutAsync("ControladorCliente/" + IdCliente, stringContent);
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
        //}
    }
}
