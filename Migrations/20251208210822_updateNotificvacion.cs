using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class updateNotificvacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificacionesDeVentas_RncLookupResult_RNCInfoRnc",
                table: "NotificacionesDeVentas");

            migrationBuilder.DropTable(
                name: "RncLookupResult");

            migrationBuilder.DropIndex(
                name: "IX_NotificacionesDeVentas_RNCInfoRnc",
                table: "NotificacionesDeVentas");

            migrationBuilder.DropColumn(
                name: "RNCInfoRnc",
                table: "NotificacionesDeVentas");

            migrationBuilder.AddColumn<string>(
                name: "Rnc",
                table: "NotificacionesDeVentas",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2025, 12, 8, 17, 8, 21, 735, DateTimeKind.Local).AddTicks(7925));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rnc",
                table: "NotificacionesDeVentas");

            migrationBuilder.AddColumn<string>(
                name: "RNCInfoRnc",
                table: "NotificacionesDeVentas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RncLookupResult",
                columns: table => new
                {
                    Rnc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Success = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RncLookupResult", x => x.Rnc);
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2025, 12, 8, 14, 27, 7, 656, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.CreateIndex(
                name: "IX_NotificacionesDeVentas_RNCInfoRnc",
                table: "NotificacionesDeVentas",
                column: "RNCInfoRnc");

            migrationBuilder.AddForeignKey(
                name: "FK_NotificacionesDeVentas_RncLookupResult_RNCInfoRnc",
                table: "NotificacionesDeVentas",
                column: "RNCInfoRnc",
                principalTable: "RncLookupResult",
                principalColumn: "Rnc",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
