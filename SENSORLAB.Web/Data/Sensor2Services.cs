
using SENSORLAB.Web.Models;
using System.Text;
using System.Text.Json;

namespace SENSORLAB.Web.Data
{
    public class Sensor2Services
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public Sensor2Services(IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }
        public async Task<List<Sensor>> GetSensorAsync()
        {
            var client = _httpClientFactory.CreateClient("sensorWebApi");
            var response = await client.GetAsync("ControladorSensor/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                try
                {
                    List<Sensor> result = JsonSerializer.Deserialize<List<Sensor>>(responseBody);
                    return result;
                }
                catch (Exception ex)
                {

                    throw;
                }


            return new List<Sensor>();
        }
        public async Task<Sensor> PostSensorAsync(Sensor sensor)
        {

            var client = _httpClientFactory.CreateClient("sensorWebApi");
            var stringContent = new StringContent(JsonSerializer.Serialize(sensor), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("ControladorSensor/", stringContent);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                try
                {
                    Sensor result = JsonSerializer.Deserialize<Sensor>(responseBody);
                    return result;
                }
                catch (Exception ex)
                {

                    throw;
                }
            
            return new Sensor();
        }
        public async ValueTask<int> DeleteSensorAsync(int IdSensor)
        {
            var client = _httpClientFactory.CreateClient("sensorWebApi");

            //var stringContent = new StringContent(JsonSerializer.Serialize(sensor), Encoding.UTF8, "application/json");
            var response = await client.DeleteAsync("ControladorSensor/" + IdSensor);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                try
                {
                 
                    return 1;
                }
                catch (Exception ex)
                {

                    throw;
                }
            
            return 1;
        }
        public async ValueTask<int> UpdateSensorAsync(int IdSensor,Sensor sensor)
        {
            var client = _httpClientFactory.CreateClient("sensorWebApi");
            var stringContent = new StringContent(JsonSerializer.Serialize(sensor), Encoding.UTF8, "application/json");
                var response = await client.PutAsync("ControladorSensor/" + IdSensor,stringContent);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                try
                {
                    return 1;
                }
                catch (Exception ex)
                {

                    throw;
                }
            
            return 1;
        }

    }
}