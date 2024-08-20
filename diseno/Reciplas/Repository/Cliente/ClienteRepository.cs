using Microsoft.EntityFrameworkCore;
using Reciplas.Clases;
using Reciplas.Models;

namespace Reciplas.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        //public async Task<Cliente> AddCliente(Cliente cliente)
        //{
        //    _context.Clientes.Add(cliente);
        //    await _context.SaveChangesAsync();

        //    return cliente;
        //}

        //public async Task<Cliente> GetCliente(int clienteId)
        //    => await _context.Clientes.FirstOrDefaultAsync(c => c.Id == clienteId);

        //public async Task<IEnumerable<Cliente>> GetClientes()
        //    => await _context.Clientes.ToListAsync();

        //public async Task<Cliente> UpdateCliente(Cliente cliente)
        //{
        //    _context.Clientes.Update(cliente);
        //    await _context.SaveChangesAsync();
        //    return cliente;
        //}

        //public async Task<Cliente> GetClienteByDNI(string dni)
        //{
        //    return await _context.Clientes.FirstOrDefaultAsync(c => c.DNI == dni);
        //}


        public async Task<Turno> AddTurno(Turno turno)
        {
            _context.Turnos.Add(turno);
            await _context.SaveChangesAsync();

            return turno;
        }

        public async Task<Turno> GetTurno(int turnoId)
            => await _context.Turnos.FirstOrDefaultAsync(c => c.Id == turnoId);

        public async Task<IEnumerable<Turno>> GetTurnos()
            => await _context.Turnos.ToListAsync();

        public async Task<Turno> UpdateTurno(Turno turno)
        {
            _context.Turnos.Update(turno);
            await _context.SaveChangesAsync();
            return turno;
        }

        public async Task<Turno> GetTurnoPorNro(int nro)
        {
            return await _context.Turnos.FirstOrDefaultAsync(c => c.NumeroTurno == nro);
        }

    }
}
