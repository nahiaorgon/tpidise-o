using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Reciplas.Clases
{
    public class LineaVenta{
        public int id_venta {get; set;}
        public int linea {get; set;}
        public int id_producto {get; set;}
        public int cantidad {get; set;}
        public decimal precio_unitario {get; set;}
    }

}