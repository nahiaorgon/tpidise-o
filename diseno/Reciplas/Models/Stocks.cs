namespace Reciplas.Models;

public class Stock :EntidadBase
{
    public decimal Cantidad { get; set; }
    public string ID { get; set; }
    public DateTime FechaIngreso { get; set; }
    public string UsuarioIngreso { get; set; }
    public string Descripcion { get; set; }
}