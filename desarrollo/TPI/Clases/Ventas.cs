using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Reciplas.Clases
{
    public class Ventas{
        [Required]
        public int id {get; set;}
        [Required]
        public DateTime fecha {get; set;}
        [Required]
        public string cliente {get; set;} = null!;

    public readonly IEnumerable<LineaVenta> LineaVentas = new List<LineaVenta>(); 
    }

}