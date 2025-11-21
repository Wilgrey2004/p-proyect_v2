using Microsoft.EntityFrameworkCore.Migrations;

namespace p_proyect.Migrations
{
    public partial class updateCompraEntity1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComprasEntity_Productos_ListaDeproductosId",
                table: "ComprasEntity");

            migrationBuilder.DropIndex(
                name: "IX_ComprasEntity_ListaDeproductosId",
                table: "ComprasEntity");

            migrationBuilder.DropColumn(
                name: "ListaDeproductosId",
                table: "ComprasEntity");

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioUnitario",
                table: "ComprasEntity",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecioUnitario",
                table: "ComprasEntity");

            migrationBuilder.AddColumn<int>(
                name: "ListaDeproductosId",
                table: "ComprasEntity",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComprasEntity_ListaDeproductosId",
                table: "ComprasEntity",
                column: "ListaDeproductosId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComprasEntity_Productos_ListaDeproductosId",
                table: "ComprasEntity",
                column: "ListaDeproductosId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
