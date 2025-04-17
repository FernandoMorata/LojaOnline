using Notificacoes.API.Models;

namespace Notificacoes.API.Services;

public class NotificacaoService
{
    public void Enviar(Notificacao notificacao)
    {
        // Simulação do envio
        Console.WriteLine($"[NOTIFICAÇÃO] Tipo: {notificacao.Tipo} | Cliente: {notificacao.ClienteId}");
        Console.WriteLine($"Mensagem: {notificacao.Mensagem}");
    }
}
