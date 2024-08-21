namespace Reciplas.Models;

public class Turno
{ 
    public int  Id {get; set;} 
    public int  NumeroTurno {get; set;} 
    public DateTime FechaTurno {get; set;} = DateTime.Now;
    public DateTime FechaUltimaModificacion {get; set; } 
    public bool Estado { get; set; } = false;

    public Cliente cliente = new Cliente();
}