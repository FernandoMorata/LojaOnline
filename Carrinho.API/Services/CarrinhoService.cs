using Carrinho.API.Models;

namespace Carrinho.API.Services
{
    public class CarrinhoService
    {
        private readonly Dictionary<int, CarrinhoCliente> _carrinhos = new();

        public CarrinhoCliente ObterCarrinho(int clientId)
        {
            if (!_carrinhos.ContainsKey(clientId))
            {
                _carrinhos[clientId] = new CarrinhoCliente 
                { 
                    ClientId = clientId,
                    Itens = new List<ItemCarrinho>()
                };
            }
            return _carrinhos[clientId];
        }

        public void AdicionarItem(int clientId, ItemCarrinho item)
        {
            var carrinho = ObterCarrinho(clientId);
            carrinho.Itens.Add(item);
        }
    }
}
