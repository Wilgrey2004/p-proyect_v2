using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class updateNotificaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificacionesDeVentas_Ventas_VentaId",
                table: "NotificacionesDeVentas");

            migrationBuilder.AlterColumn<int>(
                name: "VentaId",
                table: "NotificacionesDeVentas",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2025, 12, 8, 14, 27, 7, 656, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.AddForeignKey(
                name: "FK_NotificacionesDeVentas_Ventas_VentaId",
                table: "NotificacionesDeVentas",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificacionesDeVentas_Ventas_VentaId",
                table: "NotificacionesDeVentas");

            migrationBuilder.AlterColumn<int>(
                name: "VentaId",
                table: "NotificacionesDeVentas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 100,
                column: "FechaCreacion",
                value: new DateTime(2025, 12, 8, 11, 24, 46, 773, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.AddForeignKey(
                name: "FK_NotificacionesDeVentas_Ventas_VentaId",
                table: "NotificacionesDeVentas",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
