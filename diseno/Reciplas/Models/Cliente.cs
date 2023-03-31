namespace Reciplas.Models;

public class Cliente : EntidadBase{ 
    public string Nombre {get; set;}
    public string Direccion {get; set;}
    public int Dni {get; set;} 
}