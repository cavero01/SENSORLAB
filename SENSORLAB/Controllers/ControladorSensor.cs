using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using SENSORLAB.Models;
using SENSORLAB.Services.Sensors;



namespace SENSORLAB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControladorSensor : ControllerBase
    {
        private readonly ISensorService sensorService;

        public ControladorSensor(ISensorService sensorService)
        {
            this.sensorService = sensorService;
        }

        // GET: api/ControladorSensor
        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<Sensor>>> GetSensors()
        {
          if (sensorService.RetrieveAllSensor() == null)
          {
              return NotFound();
          }
            return await sensorService.RetrieveAllSensor().ToListAsync();
        }

        // GET: api/ControladorSensor/5
        [HttpGet("{id}")]
        [EnableQuery]
        public async Task<ActionResult<Sensor>> GetSensor(int id)
        {
          if (sensorService.RetrieveAllSensor() == null)
          {
              return NotFound();
          }
            var sensor = await sensorService.RetrieveSensorByIdAsync(id);

            if (sensor == null)
            {
                return NotFound();
            }

            return sensor;
        }

        // PUT: api/ControladorSensor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [EnableQuery]
        public async Task<IActionResult> PutSensor(int id, Sensor sensor)
        {
            if (id != sensor.IdSensor)
            {
                return BadRequest();
            }

            Sensor sensor1 = new();
            sensor1.IdSensor = sensor.IdSensor;
            sensor1.Fabricante = sensor.Fabricante;
            

            try
            {
                await sensorService.AddSensorAsync(sensor1);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SensorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ControladorSensor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [EnableQuery]

        public async Task<ActionResult<Sensor>> PostSensor(Sensor sensor)
        {
          if (sensorService.RetrieveAllSensor() == null)
          {
              return Problem("Entity set 'SENSORLABContext.Sensors'  is null.");
          }
            Sensor sensor1 = new();
            sensor1.IdSensor = sensor.IdSensor;
            sensor1.Fabricante = sensor.Fabricante;
            try
            {
                await sensorService.ModifySensorAsync(sensor1);
            }
            catch (DbUpdateException)
            {
                if (SensorExists(sensor.IdSensor))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return new ActionResult<Sensor>(sensor1);
        }

        // DELETE: api/ControladorSensor/5
        [HttpDelete("{id}")]
        [EnableQuery]
        public async Task<IActionResult> DeleteSensor(int id)
        {
            if (sensorService.RetrieveAllSensor == null)
            {
                return NotFound();
            }
            var sensor = await sensorService.RetrieveSensorByIdAsync(id);
            if (sensor == null)
            {
                return NotFound();
            }
            Sensor sensorResult = sensorService.RemoveSensorByIdAsync(id).Result;
            return Ok(sensorResult);
        }

        private bool SensorExists(int id)
        {
            return (sensorService.RetrieveAllSensor()?.Any(e => e.IdSensor == id)).GetValueOrDefault();
        }
    }
}
