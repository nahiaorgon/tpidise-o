
namespace Reciplas.Models;

public class Product : EntidadBase{  

  public int UnitsInStock{get; set;}
  public int Supplier{get; set;}
  public string ProductName{get; set;} 
  public int UnitPrice{get; set;}
  public int Total {get; set;}

    }