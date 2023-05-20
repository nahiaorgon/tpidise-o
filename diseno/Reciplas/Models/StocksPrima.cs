namespace Reciplas.Models;

public class StocksPrima :EntidadBase
{
    public DateTime Fecha { get; set; }
    public string Proveedor { get; set; }
    public int IdArticulo { get; set; }

    public int Cantidad { get; set; }
    public string Descripcion { get; set; }

    public string Nombre { get; set; }
    public decimal CantidadKgPorItem { get; set; }
    public decimal CantidadKgTotal { get; set; }
    public int IdUsuarioRecepcion { get; set; }
}