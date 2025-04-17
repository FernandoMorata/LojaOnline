using Carrinho.API.Models;
using Carrinho.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carrinho.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarrinhoController : ControllerBase
    {
        private readonly CarrinhoService _Service;

        public CarrinhoController(CarrinhoService carrinhoService)
        {
            _Service = carrinhoService;
        }
        [HttpGet("{clientId}")]
        public ActionResult<CarrinhoCliente> Get(int clientId)
        {
            var carrinho = _Service.ObterCarrinho(clientId);
            return Ok(carrinho);
        }
        [HttpPost("{clientId}")]
        public IActionResult Post(int clientId, [FromBody] ItemCarrinho item)
        {
            if (item == null)
            {
                return BadRequest("Item cannot be null");
            }
            _Service.AdicionarItem(clientId, item);
            return CreatedAtAction(nameof(Get), new { clientId }, item);
        }

    }
}
