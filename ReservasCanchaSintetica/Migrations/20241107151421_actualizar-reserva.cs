using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservasCanchaSintetica.Migrations
{
    public partial class actualizarreserva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Canchas_CanchaId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_TorneoXEquipos_Equipos_EquipoId",
                table: "TorneoXEquipos");

            migrationBuilder.DropForeignKey(
                name: "FK_TorneoXEquipos_Torneos_TorneoId",
                table: "TorneoXEquipos");

            migrationBuilder.AlterColumn<int>(
                name: "TorneoId",
                table: "TorneoXEquipos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "TorneoXEquipos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "IdCancha",
                table: "ReservaTorneos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "IdCancha",
                table: "Reservas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "CanchaId",
                table: "Reservas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Canchas_CanchaId",
                table: "Reservas",
                column: "CanchaId",
                principalTable: "Canchas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TorneoXEquipos_Equipos_EquipoId",
                table: "TorneoXEquipos",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TorneoXEquipos_Torneos_TorneoId",
                table: "TorneoXEquipos",
                column: "TorneoId",
                principalTable: "Torneos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Canchas_CanchaId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_TorneoXEquipos_Equipos_EquipoId",
                table: "TorneoXEquipos");

            migrationBuilder.DropForeignKey(
                name: "FK_TorneoXEquipos_Torneos_TorneoId",
                table: "TorneoXEquipos");

            migrationBuilder.AlterColumn<int>(
                name: "TorneoId",
                table: "TorneoXEquipos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "TorneoXEquipos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdCancha",
                table: "ReservaTorneos",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "IdCancha",
                table: "Reservas",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "CanchaId",
                table: "Reservas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Canchas_CanchaId",
                table: "Reservas",
                column: "CanchaId",
                principalTable: "Canchas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TorneoXEquipos_Equipos_EquipoId",
                table: "TorneoXEquipos",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TorneoXEquipos_Torneos_TorneoId",
                table: "TorneoXEquipos",
                column: "TorneoId",
                principalTable: "Torneos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
