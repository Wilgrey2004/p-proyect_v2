using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class NotificacionesDeventas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NFC",
                table: "Ventas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotificacionDeVentaId",
                table: "ComprasEntity",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RncLookupResult",
                columns: table => new
                {
                    Rnc = table.Column<string>(nullable: false),
                    Success = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    ErrorMessage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RncLookupResult", x => x.Rnc);
                });

            migrationBuilder.CreateTable(
                name: "NotificacionesDeVentas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDelCliente = table.Column<string>(nullable: true),
                    RNCInfoRnc = table.Column<string>(nullable: true),
                    VentaId = table.Column<int>(nullable: true),
                    ImprimirRecibo = table.Column<bool>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificacionesDeVentas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificacionesDeVentas_RncLookupResult_RNCInfoRnc",
                        column: x => x.RNCInfoRnc,
                        principalTable: "RncLookupResult",
                        principalColumn: "Rnc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotificacionesDeVentas_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2025, 12, 8, 11, 24, 46, 773, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.CreateIndex(
                name: "IX_ComprasEntity_NotificacionDeVentaId",
                table: "ComprasEntity",
                column: "NotificacionDeVentaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificacionesDeVentas_RNCInfoRnc",
                table: "NotificacionesDeVentas",
                column: "RNCInfoRnc");

            migrationBuilder.CreateIndex(
                name: "IX_NotificacionesDeVentas_VentaId",
                table: "NotificacionesDeVentas",
                column: "VentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComprasEntity_NotificacionesDeVentas_NotificacionDeVentaId",
                table: "ComprasEntity",
                column: "NotificacionDeVentaId",
                principalTable: "NotificacionesDeVentas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComprasEntity_NotificacionesDeVentas_NotificacionDeVentaId",
                table: "ComprasEntity");

            migrationBuilder.DropTable(
                name: "NotificacionesDeVentas");

            migrationBuilder.DropTable(
                name: "RncLookupResult");

            migrationBuilder.DropIndex(
                name: "IX_ComprasEntity_NotificacionDeVentaId",
                table: "ComprasEntity");

            migrationBuilder.DropColumn(
                name: "NFC",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "NotificacionDeVentaId",
                table: "ComprasEntity");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2025, 12, 7, 13, 17, 36, 17, DateTimeKind.Local).AddTicks(3562));
        }
    }
}
