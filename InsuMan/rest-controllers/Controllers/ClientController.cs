using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rest_controllers.Data;
using rest_controllers.Models;
using System.Data.Common;

namespace rest_controllers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController(ILogger<ClientController> logger, ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;
        private readonly ILogger<ClientController> _logger = logger;

        //public ClientController(ILogger<ClientController> logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet]
        public async Task<ActionResult<List<Client>>> GetClients()
        {
            return Ok(await _context.Clients.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClient(Guid id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client is null)
            {
                return NotFound(id);
            }
            return Ok(client);
        }

        [HttpPost]
        public async Task<ActionResult<Client>> CreateClient(Client client)
        {
            if (client is null)
            {
                return BadRequest();
            }
            client.CreatedAt = client.UpdatedAt = DateTime.UtcNow;
            // TODO: replace with current user id
            client.CreatedBy = client.UpdatedBy = Guid.NewGuid();
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return Created(nameof(CreateClient), client);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Client>> UpdateClient(Guid id, Client updatedClient)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client is null)
            {
                return NotFound(id);
            }
            client.Name = updatedClient.Name;
            client.LastName = updatedClient.LastName;
            client.Birthdate = updatedClient.Birthdate;
            client.Address = updatedClient.Address;
            client.UpdatedAt = DateTime.UtcNow;
            // TODO: replace with current user id
            client.UpdatedBy = Guid.NewGuid();
            await _context.SaveChangesAsync();
            return Ok(client);
        }

        [HttpDelete]
        public async Task<ActionResult<Guid>> DeleteClient(Guid id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client is not null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
            return Ok(id);
        }
    }
}
