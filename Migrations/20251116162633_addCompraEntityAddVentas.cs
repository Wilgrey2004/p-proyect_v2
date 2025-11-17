using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class addCompraEntityAddVentas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descuento = table.Column<decimal>(nullable: false),
                    TotalEntero = table.Column<decimal>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    FechaCreacio = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComprasEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadDelProducto = table.Column<int>(nullable: false),
                    IdVenta = table.Column<int>(nullable: false),
                    VentaId = table.Column<int>(nullable: true),
                    IdProducto = table.Column<int>(nullable: false),
                    ListaDeproductosId = table.Column<int>(nullable: true),
                    FechaCreacio = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprasEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComprasEntity_Productos_ListaDeproductosId",
                        column: x => x.ListaDeproductosId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComprasEntity_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComprasEntity_ListaDeproductosId",
                table: "ComprasEntity",
                column: "ListaDeproductosId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprasEntity_VentaId",
                table: "ComprasEntity",
                column: "VentaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComprasEntity");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
