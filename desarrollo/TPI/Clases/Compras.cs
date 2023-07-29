using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Reciplas.Clases
{
    public class Compras{
        public int id {get; set;}
        public DateTime fecha {get; set;}
        public string proveedor {get; set;} = null;
    public readonly IEnumerable<LineaCompra> LineaCompras = new List<LineaCompra>();

    }

}