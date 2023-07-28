using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;
namespace Reciplas.Clases
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
 
    [Keyless]
    [NotMapped]
    
    public class LineaCompra{
        
        public int id_compra {get; set;}
        public int linea {get; set;}
        public int id_producto {get; set;}
        public int cantidad {get; set;}
        public decimal precio_unitario {get; set;}
    }

}