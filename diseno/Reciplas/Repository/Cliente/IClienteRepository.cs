using Reciplas.Models;

namespace Reciplas.Repository
{
    public interface IClienteRepository
    {
        Task<Cliente> AddCliente(Cliente cliente);

        Task<IEnumerable<Cliente>> GetClientes();

        Task<Cliente> GetCliente(int clienteId);

        Task<Cliente> UpdateCliente(Cliente cliente);
        Task<Cliente> GetClienteByDNI(string dni);

    }
}