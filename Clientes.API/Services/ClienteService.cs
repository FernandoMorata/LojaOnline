using Clientes.API.Models;


namespace Clientes.API.Services
{
    public class ClienteService
    {
        private readonly List<Cliente> _clientes = new()
        {
            new Cliente{ Id = 1, Nome = "Fernando Luiz Morata", Email = "disturbedflm@hotmail.com"},
            new Cliente{ Id = 1, Nome = "Priscilade Oliveira Borges Morata", Email = "priscila_sonic@hotmail.com"}
        };
        public IEnumerable<Cliente> ObterTodos() => _clientes;
        
    }
}
