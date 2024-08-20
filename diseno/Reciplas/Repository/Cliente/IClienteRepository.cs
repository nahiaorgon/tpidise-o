using Reciplas.Models;

namespace Reciplas.Repository
{
    public interface IClienteRepository
    {
        //Task<Cliente> AddCliente(Cliente cliente);

        //Task<IEnumerable<Cliente>> GetClientes();

        //Task<Cliente> GetCliente(int clienteId);

        //Task<Cliente> UpdateCliente(Cliente cliente);
        //Task<Cliente> GetClienteByDNI(string dni);
        
        
        //turno
        
        Task<Turno> AddTurno(Turno turno);

        Task<IEnumerable<Turno>> GetTurnos();

        Task<Turno> GetTurno(int turnoId);

        Task<Turno> UpdateTurno(Turno turno);
        Task<Turno> GetTurnoPorNro(int nro);

    }
}