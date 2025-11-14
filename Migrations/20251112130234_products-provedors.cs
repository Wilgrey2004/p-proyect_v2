using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class productsprovedors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provedores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 150, nullable: false),
                    Contacto = table.Column<string>(maxLength: 150, nullable: true),
                    UltimaCompra = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 150, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: true),
                    CodigoBarra = table.Column<string>(maxLength: 50, nullable: true),
                    Marca = table.Column<string>(maxLength: 100, nullable: true),
                    Modelo = table.Column<string>(maxLength: 100, nullable: true),
                    TipoDeDeSalida = table.Column<int>(maxLength: 100, nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    StockMinimo = table.Column<int>(nullable: false),
                    StockMaximo = table.Column<int>(nullable: false),
                    UnidadMedida = table.Column<int>(maxLength: 50, nullable: false),
                    PrecioCompra = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioVenta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaExpiracion = table.Column<DateTime>(nullable: true),
                    Ubicacion = table.Column<string>(maxLength: 100, nullable: true),
                    Activo = table.Column<bool>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaActualizacion = table.Column<DateTime>(nullable: true),
                    ProveedorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Provedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Provedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ProveedorId",
                table: "Productos",
                column: "ProveedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Provedores");
        }
    }
}
