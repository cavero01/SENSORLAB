﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using SENSORLAB.Models;
using SENSORLAB.Services.Clientesensors;

namespace SENSORLAB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControladorClienteSensors : ControllerBase
    {
        private readonly IClientesensorService clientesensorService;

        public ControladorClienteSensors(IClientesensorService clientesensorService)
        {
            this.clientesensorService = clientesensorService;
        }

        // GET: api/ControladorClienteSensors
        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<ClienteSensor>>> GetClienteSensors()
        {
          if (clientesensorService.RetrieveAllClientesensors()== null)
          {
              return NotFound();
          }
            return await clientesensorService.RetrieveAllClientesensors().ToListAsync();
        }

        // GET: api/ControladorClienteSensors/5
        //test
        [HttpGet("{idclientesensor}/{idcliente}/{idsensor}")]
        [EnableQuery]
        public async Task<ActionResult<ClienteSensor>> GetClienteSensor(Guid idclientesensor ,int idcliente,int idsensor)
        {
          if (clientesensorService.RetrieveAllClientesensors() == null)
          {
              return NotFound();
          }
            var clienteSensor = await clientesensorService.RetrieveClientesensorByIdAsync(idclientesensor, idcliente, idsensor);

            if (clienteSensor == null)
            {
                return NotFound();
            }

            return clienteSensor;
        }

       

        // PUT: api/ControladorClienteSensors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut()]
        [EnableQuery]
        public async ValueTask<ActionResult<ClienteSensor>> PutClienteSensor( ClienteSensorView clienteSensorView)
        {
            
            ClienteSensor clientesensor1 = new();
            clientesensor1.IdCliente = clienteSensorView.IdCliente;
            clientesensor1.IdSensor = clienteSensorView.IdSensor;
            clientesensor1.IdEvento = clienteSensorView.IdEvento;
            clientesensor1.Historico = clienteSensorView.Historico;
            clientesensor1.Temp = clienteSensorView.Temp;
            clientesensor1.Hum = clienteSensorView.Hum;
            clientesensor1.Ubi = clienteSensorView.Ubi;
            clientesensor1.Custom1 = clienteSensorView.Custom1;
            clientesensor1.Custom2 = clienteSensorView.Custom2;
            clientesensor1.Custom3 = clienteSensorView.Custom3;

            try
            {
                //await clienteService.AddClienteAsync(cliente1);
            }
            catch (DbUpdateConcurrencyException)
            {
              
            }

            return await clientesensorService.ModifyClientesensorAsync(clientesensor1);
        }

        // POST: api/ControladorClienteSensors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [EnableQuery]
        public async Task<ActionResult<ClienteSensor>> PostClienteSensor(ClienteSensorView clienteSensorView)
        {
            if (clientesensorService.RetrieveAllClientesensors() == null)
          {
              return Problem("Entity set 'SENSORLABContext.ClienteSensors'  is null.");
            }
            ClienteSensor clientesensor1 = new();
            clientesensor1.IdCliente = clienteSensorView.IdCliente;
            clientesensor1.IdSensor = clienteSensorView.IdSensor;
            clientesensor1.IdEvento = Guid.NewGuid();
            clientesensor1.Historico = clienteSensorView.Historico;
            clientesensor1.Temp = clienteSensorView.Temp;
            clientesensor1.Hum = clienteSensorView.Hum;
            clientesensor1.Ubi = clienteSensorView.Ubi;
            clientesensor1.Custom1 = clienteSensorView.Custom1;
            clientesensor1.Custom2 = clienteSensorView.Custom2;
            clientesensor1.Custom3 = clienteSensorView.Custom3;

            try
            {
                await clientesensorService.AddClientesensorAsync(clientesensor1);
            }
            catch (DbUpdateException)
            {
                
            }

            return new ActionResult<ClienteSensor>(clientesensor1);


        }

        // DELETE: api/ControladorClienteSensors/5
        [HttpDelete("{idclientesensor}/{idcliente}/{idsensor}")]
        [EnableQuery]
        public async ValueTask<ActionResult<ClienteSensor>> DeleteClienteSensor(Guid idclientesensor, int idcliente, int idsensor)
        {
            if (clientesensorService.RetrieveAllClientesensors() == null)
            {
                return NotFound();
            }
            var clienteSensor = await clientesensorService.RetrieveClientesensorByIdAsync(idclientesensor, idcliente, idsensor);
            if (clienteSensor == null)
            {
                return NotFound();
            }

            
            return clientesensorService.RemoveClientesensorByIdAsync(idclientesensor, idcliente, idsensor).Result;
        }

        private bool ClienteSensorExists(int id)
        {
            return (clientesensorService.RetrieveAllClientesensors()?.Any(e => e.IdCliente == id)).GetValueOrDefault();
        }
    }
}
