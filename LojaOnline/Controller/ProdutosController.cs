using Catalogo.API.Models;
using Catalogo.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Catalogo.API.Controller;
[ApiController]
[Route("/api/[Controller]")]
public class ProdutosController : ControllerBase
{
    private readonly ProdutoService _Service;

    public ProdutosController(ProdutoService produtoService)
    {
        _Service = produtoService;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Produto>> Get()
    {
        var produtos = _Service.ObterTodos();
        if (produtos == null || !produtos.Any())
            return NotFound("Nenhum produto encontrado.");
        return Ok(produtos);
    }
}
