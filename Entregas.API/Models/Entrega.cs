namespace Entregas.API.Models;

public class Entrega
{
    public int PedidoId { get; set; }
    public int ClienteId { get; set; }
    public string Endereco { get; set; } = string.Empty;
    public StatusEntrega Status { get; set; } = StatusEntrega.Pendente;
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
}
