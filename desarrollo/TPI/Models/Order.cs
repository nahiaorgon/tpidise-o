using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;

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