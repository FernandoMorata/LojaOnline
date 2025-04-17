using Clientes.API.Models;
using Clientes.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Clientes.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteService _Service;
        public ClientesController(ClienteService service)
        {
            _Service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            var clientes = _Service.ObterTodos();
            if (clientes == null || !clientes.Any())
                return NotFound("Nenhum cliente encontrado.");
            return Ok(clientes);
        }
    }
}
