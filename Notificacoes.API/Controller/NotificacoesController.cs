using Microsoft.AspNetCore.Mvc;
using Notificacoes.API.Models;
using Notificacoes.API.Services;

namespace Notificacoes.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotificacoesController : ControllerBase
{
    private readonly NotificacaoService _service;

    public NotificacoesController(NotificacaoService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Enviar([FromBody] Notificacao notificacao)
    {
        _service.Enviar(notificacao);
        return Ok(new { mensagem = "Notificação enviada (simulada)" });
    }
}
