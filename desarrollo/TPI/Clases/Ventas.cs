using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Reciplas.Clases
{
    public class Ventas{
        public int id {get; set;}
        public DateTime fecha {get; set;}
        public string cliente {get; set;} = null!;

    public readonly IEnumerable<LineaVenta> LineaVentas = new List<LineaVenta>(); 
    }

}