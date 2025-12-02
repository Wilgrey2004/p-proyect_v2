using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class addRncInVentas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RNC",
                table: "Ventas",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2025, 12, 2, 18, 49, 20, 947, DateTimeKind.Local).AddTicks(6929));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RNC",
                table: "Ventas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2025, 11, 21, 20, 23, 8, 295, DateTimeKind.Local).AddTicks(4714));
        }
    }
}
