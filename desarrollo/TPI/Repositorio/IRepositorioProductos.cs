using Reciplas.Clases;

namespace Reciplas.Repositorio
{
    public interface IRepositorioProductos{
        public Task<List<Productos>> GetProductos();
        public Task<Productos> GetProductosId(int productosId);
        public Task<Productos> CrearProducto(Productos crearProducto);
        public Task<Productos> ActualizarProducto(int productosId, Productos actualizarProducto);
        public Task EliminarProducto(int productosId);
    }
}