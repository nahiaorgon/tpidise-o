
namespace Reciplas.Models;
public class Cliente
{
    public int Id { get; set; }
    public string NombreyApellido {get; set;}
    public int DNI {get; set;}   
    public string Telefono {get; set;}    
    public DateTime FechadeNacimiento { get; set; }

    public Vehiculo vehiculo = new Vehiculo();
}

