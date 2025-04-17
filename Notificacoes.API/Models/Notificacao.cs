namespace Notificacoes.API.Models;

public class Notificacao
{
    public int ClienteId { get; set; }
    public string Tipo { get; set; } = "Email"; // Email, SMS, Push
    public string Mensagem { get; set; } = string.Empty;
}
