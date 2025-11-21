using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class updateAdeudo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactoDelCliente",
                table: "Adeudos",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2025, 11, 21, 11, 14, 36, 10, DateTimeKind.Local).AddTicks(9297));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactoDelCliente",
                table: "Adeudos");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2025, 11, 19, 8, 44, 44, 564, DateTimeKind.Local).AddTicks(1615));
        }
    }
}
