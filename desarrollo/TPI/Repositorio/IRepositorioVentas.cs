using Reciplas.Clases;

namespace Reciplas.Repositorio
{
    public interface IRepositorioVentas{
        public Task<List<Ventas>> GetVentas();
        public Task<Ventas> GetVentasId(int ventasId);
        public Task<Ventas> CrearVenta(Ventas crearVenta);
        public Task<Ventas> ActualizarVenta(int ventasId, Ventas actualizarVenta);
        public Task EliminarVenta(int ventasId);
    }
}