using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class updateempleadouser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cargo",
                table: "Empleado_Admins",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Empleado_Admins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Cargo",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Empleado_Admins");
        }
    }
}
