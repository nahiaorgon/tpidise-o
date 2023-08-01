using Microsoft.EntityFrameworkCore;
using Reciplas.Data; 
using Reciplas.Clases;

namespace Reciplas.Repositorio
{
    public class RepositorioProductos : IRepositorioProductos
    {
        private readonly ApplicationDbContext _context;

        public RepositorioProductos(ApplicationDbContext context){
            _context = context; //para acceder a los modelos
        }

        public async Task<Productos> ActualizarProducto(int productosId, Productos actualizarProducto)
        {
            var productoDesdeDb = await _context.Productos.FindAsync(productosId); //hallar la compra por su id
            //productoDesdeDb.id = actualizarProducto.id;
            productoDesdeDb.nombre = actualizarProducto.nombre;
            productoDesdeDb.stock = actualizarProducto.stock; 
            productoDesdeDb.precio = actualizarProducto.precio; 
            productoDesdeDb.categoria = actualizarProducto.categoria; 
            productoDesdeDb.fecha_actualizacion = actualizarProducto.fecha_actualizacion; 

            await _context.SaveChangesAsync();
            return productoDesdeDb;
        }

        public async Task<Productos> CrearProducto(Productos crearProducto)
        {
            if (crearProducto != null){ //si existe la compra para crearlo
                await _context.Productos.AddAsync(crearProducto);
                await _context.SaveChangesAsync();
                return crearProducto;
            }else{
                return new Productos();
            }
        }

        public async Task EliminarProducto(int productosId)
        {
            var productoDesdeDb = await _context.Productos.FindAsync(productosId);
            _context.Remove(productoDesdeDb); //borrar la compra desde la base de datos
            await _context.SaveChangesAsync(); //guardar los cambios
        }

        public Task<List<Productos>> GetProductos()
        {
            return _context.Productos.ToListAsync();
        }

        public async Task<Productos> GetProductosId(int productosId)
        {
            var productoDesdeDb = await _context.Productos.FindAsync(productosId);        
            if(productoDesdeDb == null){ 
                return new Productos();
            }
            return productoDesdeDb; //si existe, retorno la compra
        }
    }
}