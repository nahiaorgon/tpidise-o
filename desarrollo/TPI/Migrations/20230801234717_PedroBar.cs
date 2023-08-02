using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reciplas.Migrations
{
    /// <inheritdoc />
    public partial class PedroBar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    proveedor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stock = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_actualizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LineaCompras",
                columns: table => new
                {
                    id_compra = table.Column<int>(type: "int", nullable: false),
                    linea = table.Column<int>(type: "int", nullable: false),
                    id_producto = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    precio_unitario = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Comprasid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_LineaCompras_Compras_Comprasid",
                        column: x => x.Comprasid,
                        principalTable: "Compras",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "LineaVentas",
                columns: table => new
                {
                    id_venta = table.Column<int>(type: "int", nullable: false),
                    linea = table.Column<int>(type: "int", nullable: false),
                    id_producto = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    precio_unitario = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Ventasid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_LineaVentas_Ventas_Ventasid",
                        column: x => x.Ventasid,
                        principalTable: "Ventas",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LineaCompras_Comprasid",
                table: "LineaCompras",
                column: "Comprasid");

            migrationBuilder.CreateIndex(
                name: "IX_LineaVentas_Ventasid",
                table: "LineaVentas",
                column: "Ventasid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LineaCompras");

            migrationBuilder.DropTable(
                name: "LineaVentas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
