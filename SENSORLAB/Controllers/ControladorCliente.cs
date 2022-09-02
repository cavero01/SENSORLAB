using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using SENSORLAB.Models;
using SENSORLAB.Services.Clientes;

namespace SENSORLAB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControladorCliente : ControllerBase
    {   
        private readonly IClienteService clienteService;

        public ControladorCliente(IClienteService clienteService)
        {   
            this.clienteService = clienteService;
        }

        // GET: api/ControladorCliente
        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            if (clienteService.RetrieveAllClientes() == null)
            {
                return NotFound();
            }
            return await clienteService.RetrieveAllClientes().ToListAsync();
        }

        // GET: api/ControladorCliente/5
        [HttpGet("{id}")]
        [EnableQuery]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            if (clienteService.RetrieveAllClientes() == null)
            {
                return NotFound();
            }
            var cliente = await clienteService.RetrieveClienteByIdAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        // PUT: api/ControladorCliente/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [EnableQuery]
        public async Task<IActionResult> PutCliente(int id, Cliente cliente)
        {
            if (id != cliente.IdCliente)
            {
                return BadRequest();
            }

            Cliente cliente1 = new();
            cliente1.IdCliente = cliente.IdCliente;
            cliente1.Nombre = cliente.Nombre;
            cliente1.Fecha = cliente.Fecha;
            cliente1.Nacionalidad = cliente.Nacionalidad;
            cliente1.Premium = cliente.Premium;
            

            try
            {
                await clienteService.AddClienteAsync(cliente1);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExists(id))
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

        // POST: api/ControladorCliente
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [EnableQuery]
        public async Task<ActionResult<Cliente>> PostCliente(ClienteView cliente)
        {
            if (clienteService.RetrieveAllClientes() == null)
            {
                return Problem("Entity set 'SENSORLABContext.Clientes'  is null.");
            }

            Cliente cliente1 = new();
            cliente1.IdCliente = cliente.IdCliente;
            cliente1.Nombre = cliente.Nombre;
            cliente1.Fecha = cliente.Fecha;
            cliente1.Nacionalidad = cliente.Nacionalidad;
            cliente1.Premium = cliente.Premium;
            
            try
            {
                await clienteService.ModifyClienteAsync(cliente1);
            }
            catch (DbUpdateException)
            {
                if (ClienteExists(cliente.IdCliente))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return new ActionResult<Cliente>(cliente1);
        }

        // DELETE: api/ControladorCliente/5
        [HttpDelete("{id}")]
        [EnableQuery]
        public async ValueTask<IActionResult> DeleteCliente(int id)
        {
            if (clienteService.RetrieveAllClientes() == null)
            {
                return NotFound();
            }
            var cliente = await clienteService.RetrieveClienteByIdAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            Cliente clientResult= clienteService.RemoveClienteByIdAsync(id).Result;
            return Ok(clientResult);
            
        }

        private bool ClienteExists(int id)
        {
            return (clienteService.RetrieveAllClientes()?.Any(e => e.IdCliente == id)).GetValueOrDefault();
        }
    }
}
