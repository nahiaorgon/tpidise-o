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
         
        public async Task<Turno> AddTurno(Turno turno)
        {
            _context.Turnos.Add(turno);
            _context.Clientes.Add(turno.cliente);
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
