using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class SeedAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Activo", "Apellido", "Cedula", "Contrasena", "Correo", "FechaCreacion", "FechaEdicion", "Nombre", "Rol", "UltimaVezActivo" },
                values: new object[] { 100, true, "origen", "No porta", "admin123", "Apro24470@gmail.com", new DateTime(2025, 11, 18, 19, 36, 50, 286, DateTimeKind.Local).AddTicks(5109), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
