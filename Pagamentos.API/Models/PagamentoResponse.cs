namespace Pagamentos.API.Models;

public class PagamentoResponse
{
    public int PedidoId { get; set; }
    public bool Sucesso { get; set; }
    public string Mensagem { get; set; } = string.Empty;
}
