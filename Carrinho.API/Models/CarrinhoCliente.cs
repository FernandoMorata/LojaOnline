namespace Carrinho.API.Models
{
    public class CarrinhoCliente
    {
        public int ClientId{ get; set; }
        public List<ItemCarrinho> Itens { get; set; } = [];
    }
}
