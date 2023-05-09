
namespace Reciplas.Models;

    public class Order : EntidadBase{
        
public string  ShipName {get; set;}
public string ShipAddress {get; set;}
public string  ShipCountry {get; set;}
public string   ShipCity {get; set;}
public int IDEmpleado {get; set;}
public int  OrderID {get; set;}
       
public string  Freight {get; set;}
      
     
    }