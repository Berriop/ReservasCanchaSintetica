using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservasCanchaSintetica.Migrations
{
    public partial class agregar_dias_bloqueados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Canchas_Inventarios_InventarioId",
                table: "Canchas");

            migrationBuilder.DropIndex(
                name: "IX_Canchas_InventarioId",
                table: "Canchas");

            migrationBuilder.DropColumn(
                name: "CantidadPetos",
                table: "Inventarios");

            migrationBuilder.DropColumn(
                name: "IdInventario",
                table: "Canchas");

            migrationBuilder.DropColumn(
                name: "InventarioId",
                table: "Canchas");

            migrationBuilder.DropColumn(
                name: "Tamaño",
                table: "Canchas");

            migrationBuilder.RenameColumn(
                name: "Nomrbre",
                table: "Equipos",
                newName: "Nombre");

            migrationBuilder.CreateTable(
                name: "DiasBloqueados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiasBloqueados", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiasBloqueados");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Equipos",
                newName: "Nomrbre");

            migrationBuilder.AddColumn<int>(
                name: "CantidadPetos",
                table: "Inventarios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IdInventario",
                table: "Canchas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InventarioId",
                table: "Canchas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tamaño",
                table: "Canchas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Canchas_InventarioId",
                table: "Canchas",
                column: "InventarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Canchas_Inventarios_InventarioId",
                table: "Canchas",
                column: "InventarioId",
                principalTable: "Inventarios",
                principalColumn: "Id");
        }
    }
}
