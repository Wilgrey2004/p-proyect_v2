using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class alterproveedoresaddfechaDeCreacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDeCreacion",
                table: "Provedores",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaDeCreacion",
                table: "Provedores");
        }
    }
}
