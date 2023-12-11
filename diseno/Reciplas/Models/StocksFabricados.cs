namespace Reciplas.Models;

public class StocksFabricados :EntidadBase
{
    public DateTime Fecha { get; set; }
    public string Producto { get; set; }
    public int Cantidad { get; set; }
    public string Descripcion { get; set; }
    public string ResponsableProduccion { get; set; }
}