
namespace Reciplas.Models;
    public class Cliente : EntidadBase{ 
    public string Nombre {get; set;}
    public string Direccion {get; set;}
    public string DNI {get; set;}   
    public string Telefono {get; set;}    
    public DateTime FechadeNacimiento { get; set; } = DateTime.Now;

    public bool PerfilAprobacion { get; set; }

    }

