namespace Reciplas.Models;

public class Turno{

    public int  Id {get; set;} 
    public int  NumeroTurno {get; set;} 
    public DateTime FechaTurno {get; set;} 
    public DateTime FechaUltimaModificacion {get; set;} 
    public string Estado {get; set;} 

    public Cliente cliente = new Cliente();
}