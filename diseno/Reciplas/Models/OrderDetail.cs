namespace Reciplas.Models;

public class OrderDetail : EntidadBase{ 
    public int OrderID {get; set;}
    
    public DateTime OrderDate {get; set;}
public string UnitPrice {get; set;}
    public string Discount {get; set;}
    public string Product {get; set;} 
    public string ProductName {get; set;}
}