using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Reciplas.Models;

public class Proveedor : EntidadBase{
    public int Sucursal {get; set;} 
    public int ID {get; set;}
    public int DNI {get; set;}
    public string Nombre {get; set;}
    public string Ciudad {get; set;}
    public string Direccion {get; set;}
    
    public bool PerfilAprobacion { get; set; }
    
}