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

        public virtual DbSet<Appointment> Appointments {get; set;} = null!;
        public virtual DbSet<Cliente> Clientes {get; set;} = null!;
        public virtual DbSet<Customer> Customers {get; set;} = null!; 
        public virtual DbSet<Order> Orders {get; set;} = null!;
        public virtual DbSet<OrderDetail>  OrderDetails {get; set;} = null!;
        public virtual DbSet<Pedidos> Pedidoss  {get; set;} = null!;
        public virtual DbSet<Product>  Products {get; set;} = null!;
        public virtual DbSet<Proveedor>  Proveedors {get; set;} = null!;
        public virtual DbSet<Reporte> Reportes  {get; set;} = null!; 
        public virtual DbSet<StocksFabricados>  StocksFabricadoss {get; set;} = null!;
        public virtual DbSet<StocksPrima>  StocksPrimas {get; set;} = null!;
        public virtual DbSet<Usuario>  Usuarios {get; set;} = null!;
         
    }
}