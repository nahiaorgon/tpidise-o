namespace Reciplas.Models;

public class Proveedor : EntidadBase{
    public int Sucursal {get; set;} 
    public int Identificacion {get; set;}
    public string Nombre {get; set;}
    public string Direccion {get; set;}
    
}