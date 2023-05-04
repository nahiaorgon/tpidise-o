
namespace Reciplas.Models;

    public class Pedidos : EntidadBase{
    public int NumPedido {get; set;}
    public string Descripcion {get; set;}
    public DateTime Fecha {get; set;} 
    public int IDEmpleado {get; set;}
    public int CodVenta{get; set;} 
                    
                    

    }