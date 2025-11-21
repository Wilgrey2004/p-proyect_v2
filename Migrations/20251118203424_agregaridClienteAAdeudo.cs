using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class agregaridClienteAAdeudo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adeudos_Compras_Compra_Id",
                table: "Adeudos");

            migrationBuilder.DropIndex(
                name: "IX_Adeudos_Compra_Id",
                table: "Adeudos");

            migrationBuilder.DropColumn(
                name: "Compra_Id",
                table: "Adeudos");

            migrationBuilder.DropColumn(
                name: "IdCompra",
                table: "Adeudos");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Adeudos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVenta",
                table: "Adeudos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "MontoRestanteDelAdeudo",
                table: "Adeudos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "VentaId",
                table: "Adeudos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adeudos_VentaId",
                table: "Adeudos",
                column: "VentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adeudos_Ventas_VentaId",
                table: "Adeudos",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adeudos_Ventas_VentaId",
                table: "Adeudos");

            migrationBuilder.DropIndex(
                name: "IX_Adeudos_VentaId",
                table: "Adeudos");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Adeudos");

            migrationBuilder.DropColumn(
                name: "IdVenta",
                table: "Adeudos");

            migrationBuilder.DropColumn(
                name: "MontoRestanteDelAdeudo",
                table: "Adeudos");

            migrationBuilder.DropColumn(
                name: "VentaId",
                table: "Adeudos");

            migrationBuilder.AddColumn<int>(
                name: "Compra_Id",
                table: "Adeudos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCompra",
                table: "Adeudos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Adeudos_Compra_Id",
                table: "Adeudos",
                column: "Compra_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Adeudos_Compras_Compra_Id",
                table: "Adeudos",
                column: "Compra_Id",
                principalTable: "Compras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
