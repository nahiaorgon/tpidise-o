using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Reciplas.Clases
{
    public class ApplicationDbContext : DbContext{



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){
        }

        public virtual DbSet<Compras> Compras {get; set;} = null!;
        public virtual DbSet<Ventas> Ventas {get; set;} = null!;
        public virtual DbSet<LineaCompra> LineaCompras {get; set;} = null!;
        public virtual DbSet<LineaVenta> LineaVentas {get; set;} = null!;
        public virtual DbSet<Productos> Productos {get; set;} = null!;
        
    }
}