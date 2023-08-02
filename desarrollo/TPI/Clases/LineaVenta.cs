using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Reciplas.Clases
{  
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
 
    [Keyless]
    public class LineaVenta{
        public int id_venta {get; set;}
        public int linea {get; set;}
        public int id_producto {get; set;}
        public int cantidad {get; set;}
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "decimal(12, 2)")]
        public decimal precio_unitario {get; set;}
        public Ventas Ventas {get; set;}  = null!; 
    }

}