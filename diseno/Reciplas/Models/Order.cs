namespace Reciplas.Models;

public class Compras: EntidadBase{
    public string UnitPrice {get; set;}
    public string Discount {get; set;}
    public string Product {get; set;} 
    public string Compra {get; set;} 
    public int Monto {get; set;} 

}