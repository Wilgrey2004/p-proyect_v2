using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class add_ClienteEspecial_Compra_Adeudo_news_entityes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompraId",
                table: "Productos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClientesEspeciales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Cedula = table.Column<string>(nullable: true),
                    Contacto = table.Column<string>(nullable: true),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaDeEdicion = table.Column<DateTime>(nullable: true),
                    FechaUltimaActualizacion = table.Column<DateTime>(nullable: true),
                    EsClienteActivo = table.Column<bool>(nullable: false),
                    UltimaCompra = table.Column<DateTime>(nullable: true),
                    CantidadDeCompras = table.Column<int>(nullable: false),
                    TotalCompradoHistorico = table.Column<decimal>(nullable: false),
                    LimiteDelCredito = table.Column<decimal>(nullable: false),
                    CreditoGastado = table.Column<decimal>(nullable: false),
                    FechaUltimoPagoCredito = table.Column<DateTime>(nullable: true),
                    MontoUltimoPago = table.Column<decimal>(nullable: true),
                    DescuentoPersonal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesEspeciales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteEspecialId = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compras_ClientesEspeciales_ClienteEspecialId",
                        column: x => x.ClienteEspecialId,
                        principalTable: "ClientesEspeciales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adeudos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MontoTotalDelAdeudo = table.Column<decimal>(nullable: false),
                    MontoTotalAbonadoDelAdeudo = table.Column<decimal>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: true),
                    FechaUltimaActualizacion = table.Column<DateTime>(nullable: true),
                    IdCompra = table.Column<int>(nullable: false),
                    Compra_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adeudos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adeudos_Compras_Compra_Id",
                        column: x => x.Compra_Id,
                        principalTable: "Compras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CompraId",
                table: "Productos",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Adeudos_Compra_Id",
                table: "Adeudos",
                column: "Compra_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ClienteEspecialId",
                table: "Compras",
                column: "ClienteEspecialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Compras_CompraId",
                table: "Productos",
                column: "CompraId",
                principalTable: "Compras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Compras_CompraId",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "Adeudos");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "ClientesEspeciales");

            migrationBuilder.DropIndex(
                name: "IX_Productos_CompraId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "CompraId",
                table: "Productos");
        }
    }
}
