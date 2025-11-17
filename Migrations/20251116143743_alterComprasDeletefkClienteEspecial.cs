using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class alterComprasDeletefkClienteEspecial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_ClientesEspeciales_ClienteEspecialId",
                table: "Compras");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteEspecialId",
                table: "Compras",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_ClientesEspeciales_ClienteEspecialId",
                table: "Compras");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteEspecialId",
                table: "Compras",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            
        }
    }
}
