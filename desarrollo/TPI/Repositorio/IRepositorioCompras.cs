//describo los metodos 
using Reciplas.Clases;

namespace Reciplas.Repositorio
{
    public interface IRepositorioCompras{
        public Task<List<Compras>> GetCompras();
        public Task<Compras> GetComprasId(int comprasId);
        public Task<Compras> CrearCompra(Compras crearCompra);
        public Task<Compras> ActualizarCompra(int comprasId, Compras actualizarCompra);
        public Task EliminarCompra(int comprasId);

    }
} 

