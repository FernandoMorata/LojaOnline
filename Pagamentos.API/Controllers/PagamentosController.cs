using Microsoft.AspNetCore.Mvc;
using Pagamentos.API.Models;
using Pagamentos.API.Services;

namespace Pagamentos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PagamentosController : ControllerBase
{
    private readonly PagamentoService _service;

    public PagamentosController(PagamentoService service)
    {
        _service = service;
    }

    [HttpPost]
    public ActionResult<PagamentoResponse> Post([FromBody] PagamentoRequest request)
    {
        var resultado = _service.ProcessarPagamento(request);
        return Ok(resultado);
    }
}
