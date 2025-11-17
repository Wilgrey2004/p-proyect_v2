using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class altertablkeClienteNormalDeleteFkLj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientesNormales_Compras_Compra_Id",
                table: "ClientesNormales");

            migrationBuilder.DropIndex(
                name: "IX_ClientesNormales_Compra_Id",
                table: "ClientesNormales");

            migrationBuilder.DropColumn(
                name: "Compra_Id",
                table: "ClientesNormales");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Compra_Id",
                table: "ClientesNormales",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientesNormales_Compra_Id",
                table: "ClientesNormales",
                column: "Compra_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientesNormales_Compras_Compra_Id",
                table: "ClientesNormales",
                column: "Compra_Id",
                principalTable: "Compras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
