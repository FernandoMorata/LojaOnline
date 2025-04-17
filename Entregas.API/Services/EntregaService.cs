using Entregas.API.Models;

namespace Entregas.API.Services;

public class EntregaService
{
    private readonly Dictionary<int, Entrega> _entregas = new();

    public Entrega CriarEntrega(Entrega entrega)
    {
        entrega.Status = StatusEntrega.Pendente;
        entrega.CriadoEm = DateTime.UtcNow;
        _entregas[entrega.PedidoId] = entrega;
        return entrega;
    }

    public Entrega? ObterPorPedido(int pedidoId)
    {
        _entregas.TryGetValue(pedidoId, out var entrega);
        return entrega;
    }

    public bool AtualizarStatus(int pedidoId, StatusEntrega novoStatus)
    {
        if (_entregas.TryGetValue(pedidoId, out var entrega))
        {
            entrega.Status = novoStatus;
            return true;
        }

        return false;
    }
}
