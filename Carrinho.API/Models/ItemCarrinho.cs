namespace Carrinho.API.Models
{
    public class ItemCarrinho
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
