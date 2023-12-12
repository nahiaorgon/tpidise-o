using System.ComponentModel.DataAnnotations.Schema;

namespace Reciplas.Models;

public class StocksPrima :EntidadBase
{
    public DateTime Fecha { get; set; }
    public string Proveedor { get; set; }
    public int IdArticulo { get; set; } 
    public int Cantidad { get; set; }
    public string Descripcion { get; set; } 
    public string Nombre { get; set; }
[Column(TypeName = "decimal(18,4)")]
    public decimal CantidadKgPorItem { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public decimal CantidadKgTotal { get; set; }
    public int IdUsuarioRecepcion { get; set; }
}