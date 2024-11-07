using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservasCanchaSintetica.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administradores",
                columns: table => new
                {
                    Documento = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: false),
                    Correo = table.Column<string>(type: "TEXT", nullable: false),
                    Contraseña = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administradores", x => x.Documento);
                });

            migrationBuilder.CreateTable(
                name: "Canchas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Precio = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canchas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Documento = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Correo = table.Column<string>(type: "TEXT", nullable: false),
                    Contraseña = table.Column<string>(type: "TEXT", nullable: false),
                    Saldo = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Documento);
                });

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

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    CantidadJugadores = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CantidadBalones = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadAguas = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Torneos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValorInscripcion = table.Column<float>(type: "REAL", nullable: false),
                    Premio = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torneos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CantidadHoras = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadBalones = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadAguas = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioTotal = table.Column<float>(type: "REAL", nullable: false),
                    DocumentoCliente = table.Column<string>(type: "TEXT", nullable: false),
                    ClienteDocumento = table.Column<string>(type: "TEXT", nullable: true),
                    IdCancha = table.Column<string>(type: "TEXT", nullable: false),
                    CanchaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservas_Canchas_CanchaId",
                        column: x => x.CanchaId,
                        principalTable: "Canchas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservas_Clientes_ClienteDocumento",
                        column: x => x.ClienteDocumento,
                        principalTable: "Clientes",
                        principalColumn: "Documento");
                });

            migrationBuilder.CreateTable(
                name: "ReservaTorneos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CantidadHoras = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadBalones = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadAguas = table.Column<int>(type: "INTEGER", nullable: false),
                    DocumentoAdministrador = table.Column<string>(type: "TEXT", nullable: false),
                    AdministradorDocumento = table.Column<string>(type: "TEXT", nullable: true),
                    IdTorneo = table.Column<string>(type: "TEXT", nullable: false),
                    TorneoId = table.Column<int>(type: "INTEGER", nullable: false),
                    IdCancha = table.Column<string>(type: "TEXT", nullable: false),
                    CanchaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservaTorneos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservaTorneos_Administradores_AdministradorDocumento",
                        column: x => x.AdministradorDocumento,
                        principalTable: "Administradores",
                        principalColumn: "Documento");
                    table.ForeignKey(
                        name: "FK_ReservaTorneos_Canchas_CanchaId",
                        column: x => x.CanchaId,
                        principalTable: "Canchas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservaTorneos_Torneos_TorneoId",
                        column: x => x.TorneoId,
                        principalTable: "Torneos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TorneoXEquipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdEquipo = table.Column<int>(type: "INTEGER", nullable: false),
                    EquipoId = table.Column<int>(type: "INTEGER", nullable: false),
                    IdTorneo = table.Column<int>(type: "INTEGER", nullable: false),
                    TorneoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TorneoXEquipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TorneoXEquipos_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TorneoXEquipos_Torneos_TorneoId",
                        column: x => x.TorneoId,
                        principalTable: "Torneos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CanchaXReservaTorneos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdCancha = table.Column<string>(type: "TEXT", nullable: false),
                    CanchaId = table.Column<int>(type: "INTEGER", nullable: false),
                    IdReservaTorneo = table.Column<string>(type: "TEXT", nullable: false),
                    ReservaTorneoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanchaXReservaTorneos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CanchaXReservaTorneos_Canchas_CanchaId",
                        column: x => x.CanchaId,
                        principalTable: "Canchas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CanchaXReservaTorneos_ReservaTorneos_ReservaTorneoId",
                        column: x => x.ReservaTorneoId,
                        principalTable: "ReservaTorneos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CanchaXReservaTorneos_CanchaId",
                table: "CanchaXReservaTorneos",
                column: "CanchaId");

            migrationBuilder.CreateIndex(
                name: "IX_CanchaXReservaTorneos_ReservaTorneoId",
                table: "CanchaXReservaTorneos",
                column: "ReservaTorneoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_CanchaId",
                table: "Reservas",
                column: "CanchaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_ClienteDocumento",
                table: "Reservas",
                column: "ClienteDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaTorneos_AdministradorDocumento",
                table: "ReservaTorneos",
                column: "AdministradorDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaTorneos_CanchaId",
                table: "ReservaTorneos",
                column: "CanchaId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaTorneos_TorneoId",
                table: "ReservaTorneos",
                column: "TorneoId");

            migrationBuilder.CreateIndex(
                name: "IX_TorneoXEquipos_EquipoId",
                table: "TorneoXEquipos",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_TorneoXEquipos_TorneoId",
                table: "TorneoXEquipos",
                column: "TorneoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CanchaXReservaTorneos");

            migrationBuilder.DropTable(
                name: "DiasBloqueados");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "TorneoXEquipos");

            migrationBuilder.DropTable(
                name: "ReservaTorneos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Administradores");

            migrationBuilder.DropTable(
                name: "Canchas");

            migrationBuilder.DropTable(
                name: "Torneos");
        }
    }
}
