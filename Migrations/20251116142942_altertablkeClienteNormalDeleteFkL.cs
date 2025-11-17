using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class altertablkeClienteNormalDeleteFkL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UltimaCompra",
                table: "ClientesNormales");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UltimaCompra",
                table: "ClientesNormales",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
