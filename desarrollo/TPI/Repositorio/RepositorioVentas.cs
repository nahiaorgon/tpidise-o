using Microsoft.EntityFrameworkCore;
using Reciplas.Data; 
using Reciplas.Clases;

namespace Reciplas.Repositorio
{
    public class RepositorioVentas : IRepositorioVentas
    {
        private readonly ApplicationDbContext _context;

        public RepositorioVentas(ApplicationDbContext context){
            _context = context; //para acceder a los modelos
        }

        public async Task<Ventas> ActualizarVenta(int ventasId, Ventas actualizarVenta)
        {
            var ventaDesdeDb = await _context.Ventas.FindAsync(ventasId); //hallar la compra por su id
            //ventaDesdeDb.id = actualizarVenta.id;
            ventaDesdeDb.fecha = actualizarVenta.fecha;
            ventaDesdeDb.cliente = actualizarVenta.cliente; 

            await _context.SaveChangesAsync();
            return ventaDesdeDb;
        }

        public async Task<Ventas> CrearVenta(Ventas crearVenta)
        {
            if (crearVenta != null){ //si existe la venta para crearlo
                crearVenta.fecha = DateTime.Now;
                await _context.Ventas.AddAsync(crearVenta);
                await _context.SaveChangesAsync();
                return crearVenta;
            }else{
                return new Ventas();
            }
        }

        public async Task EliminarVenta(int ventasId)
        {
             var ventaDesdeDb = await _context.Compras.FindAsync(ventasId);
            _context.Remove(ventaDesdeDb); //borrar la compra desde la base de datos
            await _context.SaveChangesAsync(); //guardar los cambios
        }

        public Task<List<Ventas>> GetVentas()
        {
            return _context.Ventas.ToListAsync();
        }

        public async Task<Ventas> GetVentasId(int ventasId)
        {
            var ventaDesdeDb = await _context.Ventas.FindAsync(ventasId);        
            if(ventaDesdeDb == null){ 
                return new Ventas();
            }
            return ventaDesdeDb; //si existe, retorno la compra
        }
    }
}