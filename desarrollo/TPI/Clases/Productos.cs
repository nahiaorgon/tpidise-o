using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Reciplas.Clases
{
    public class Productos{
        public int id {get; set;}
        public string nombre {get; set;} = null;
        public int stock {get; set;}
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "decimal(12, 2)")]
        public decimal precio {get; set;}
        public string categoria {get; set;} = null;
        public DateTime fecha_actualizacion {get; set;}  
    }

}