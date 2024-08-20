using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 
using Reciplas.Models;

namespace Reciplas.Clases
{
    public class ApplicationDbContext : DbContext{



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){
        }

        public virtual DbSet<Cliente> Clientes {get; set;} = null!;
        public virtual DbSet<Turno> Turnos {get; set;} = null!; 
        public virtual DbSet<Vehiculo> Vehiculos {get; set;} = null!; 
         
    }
}