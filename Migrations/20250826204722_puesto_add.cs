using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class puesto_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Empleado_Admins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Cargo",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Empleado_Admins",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Cargo",
                value: 0);
        }
    }
}
