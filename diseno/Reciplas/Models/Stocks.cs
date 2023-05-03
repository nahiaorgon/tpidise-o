namespace Reciplas.Models;

public class Stocks :EntidadBase
{
    public decimal Cantidad { get; set; }
    public string ID { get; set; }
    public DateTime FechaIngreso { get; set; }
    public string UsuarioIngreso { get; set; }
    public string Descripcion { get; set; }
}