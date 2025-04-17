namespace Pagamentos.API.Models
{
    public class PagamentoRequest
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public decimal ValorTotal { get; set; }
        public string MetodoPagamento { get; set; } = "Cartao"; // ou "Pix", "Boleto"
    }
}
