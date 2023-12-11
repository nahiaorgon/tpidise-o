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

        public async Task<Cliente> AddCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            return cliente;
        }

        public async Task<Cliente> GetCliente(int clienteId)
            => await _context.Clientes.FirstOrDefaultAsync(c => c.Id == clienteId);

        public async Task<IEnumerable<Cliente>> GetClientes()
            => await _context.Clientes.ToListAsync();

        public async Task<Cliente> UpdateCliente(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }
    }
}
