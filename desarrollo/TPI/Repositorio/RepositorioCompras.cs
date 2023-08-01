//uso la implementacion de los metodos como tal 
using Microsoft.EntityFrameworkCore;
using Reciplas.Data; 
using Reciplas.Clases;  

namespace Reciplas.Repositorio
{
    public class RepositorioCompras : IRepositorioCompras
    {

        private readonly ApplicationDbContext _context;

        public RepositorioCompras(ApplicationDbContext context){
            _context = context; //para acceder a los modelos
        }


        //para actualizar el libro
        public async Task<Compras> ActualizarCompra(int comprasId, Compras actualizarCompra)
        {
            var compraDesdeDb = await _context.Compras.FindAsync(comprasId); //hallar la compra por su id
            //compraDesdeDb.id = actualizarCompra.id;
            compraDesdeDb.fecha = actualizarCompra.fecha;
            compraDesdeDb.proveedor = actualizarCompra.proveedor; 

            await _context.SaveChangesAsync();
            return compraDesdeDb;
        }

        public async Task<Compras> CrearCompra(Compras crearCompra)
        { 
            if (crearCompra != null){ //si existe la compra para crearlo
                await _context.Compras.AddAsync(crearCompra);
                await _context.SaveChangesAsync();
                return crearCompra;
            }else{
                return new Compras();
            }
        }

        public async Task EliminarCompra(int comprasId)
        {
            var compraDesdeDb = await _context.Compras.FindAsync(comprasId);
            _context.Remove(compraDesdeDb); //borrar la compra desde la base de datos
            await _context.SaveChangesAsync(); //guardar los cambios
        }

        public Task<List<Compras>> GetCompras()
        {
            return _context.Compras.ToListAsync();
        }

        public async Task<Compras> GetComprasId(int comprasId)
        {
            var compraDesdeDb = await _context.Compras.FindAsync(comprasId);        
            if(compraDesdeDb == null){ 
                return new Compras();
            }
            return compraDesdeDb; //si existe, retorno la compra
        
        }
    }
}