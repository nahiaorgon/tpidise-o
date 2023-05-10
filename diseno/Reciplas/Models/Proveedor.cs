namespace Reciplas.Models;

public class Proveedor : EntidadBase{
    public int Sucursal {get; set;} 
    public int ID {get; set;}
    public int DNI {get; set;}
    public string Nombre {get; set;}
    public string Ciudad {get; set;}
    public string Direccion {get; set;}
    
}