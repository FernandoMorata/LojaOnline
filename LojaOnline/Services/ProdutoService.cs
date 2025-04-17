using Catalogo.API.Models;


namespace Catalogo.API.Services
{
    public class ProdutoService
    {
        private readonly List<Produto> _produtos = new() {
            new Produto { Id = 1, Nome = "Gin com energético e gelo de sabores", Preco = 14.00m },
            new Produto { Id = 2, Nome = "Blood Mary", Preco = 24.00m },
        };

        public IEnumerable<Produto> ObterTodos() => _produtos;

    }
}
