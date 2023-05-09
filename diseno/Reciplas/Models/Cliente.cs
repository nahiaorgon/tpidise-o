
namespace Reciplas.Models;
    public class Cliente : EntidadBase{ 
    public string Nombre {get; set;}
    public string Direccion {get; set;}
    public int DNI {get; set;}   
    public int Telefono {get; set;}   
    public int Id { get; set; }

    public bool PerfilAprobacion { get; set; }

    }

