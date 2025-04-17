using Pagamentos.API.Models;

namespace Pagamentos.API.Services;

public class PagamentoService
{
    public PagamentoResponse ProcessarPagamento(PagamentoRequest request)
    {
        // Simulação simples
        var aprovado = request.ValorTotal <= 10000; // aprova até 10k

        return new PagamentoResponse
        {
            PedidoId = request.PedidoId,
            Sucesso = aprovado,
            Mensagem = aprovado ? "Pagamento aprovado" : "Pagamento recusado"
        };
    }
}
