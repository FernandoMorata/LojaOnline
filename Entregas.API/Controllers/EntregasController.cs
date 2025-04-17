using Entregas.API.Models;
using Entregas.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Entregas.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EntregasController : ControllerBase
{
    private readonly EntregaService _service;

    public EntregasController(EntregaService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Criar([FromBody] Entrega entrega)
    {
        var novaEntrega = _service.CriarEntrega(entrega);
        return Ok(novaEntrega);
    }

    [HttpGet("{pedidoId}")]
    public IActionResult Obter(int pedidoId)
    {
        var entrega = _service.ObterPorPedido(pedidoId);
        if (entrega == null) return NotFound();
        return Ok(entrega);
    }

    [HttpPut("{pedidoId}/status")]
    public IActionResult AtualizarStatus(int pedidoId, [FromQuery] StatusEntrega status)
    {
        var atualizado = _service.AtualizarStatus(pedidoId, status);
        if (!atualizado) return NotFound();
        return NoContent();
    }
}
