﻿// <auto-generated />
using System;
using Cancha_Sintetica;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ReservasCanchaSintetica.Migrations
{
    [DbContext(typeof(CanchaSinteticaContext))]
    [Migration("20241103233115_initial-migration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.35");

            modelBuilder.Entity("Cancha_Sintetica.Modelos.Administrador", b =>
                {
                    b.Property<string>("Documento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Documento");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.Cancha", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdInventario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("InventarioId")
                        .HasColumnType("TEXT");

                    b.Property<float>("Precio")
                        .HasColumnType("REAL");

                    b.Property<string>("Tamaño")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("InventarioId");

                    b.ToTable("Canchas");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.CanchaXReservaTorneo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CanchaId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IdCancha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IdReservaTorneo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReservaTorneoId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CanchaId");

                    b.HasIndex("ReservaTorneoId");

                    b.ToTable("CanchaXReservaTorneos");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.Cliente", b =>
                {
                    b.Property<string>("Documento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Saldo")
                        .HasColumnType("REAL");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Documento");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.Equipo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("CantidadJugadores")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nomrbre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.Inventario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("CantidadAguas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadBalones")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadPetos")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Inventarios");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.Reserva", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CanchaId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CantidadAguas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadBalones")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadHoras")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClienteDocumento")
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentoCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdCancha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("PrecioTotal")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CanchaId");

                    b.HasIndex("ClienteDocumento");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.ReservaTorneo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdministradorDocumento")
                        .HasColumnType("TEXT");

                    b.Property<string>("CanchaId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CantidadAguas")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadBalones")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadHoras")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DocumentoAdministrador")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdCancha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IdTorneo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TorneoId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AdministradorDocumento");

                    b.HasIndex("CanchaId");

                    b.HasIndex("TorneoId");

                    b.ToTable("ReservaTorneos");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.Torneo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Premio")
                        .HasColumnType("REAL");

                    b.Property<float>("ValorInscripcion")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Torneos");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.TorneoXEquipo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("EquipoId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IdEquipo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IdTorneo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TorneoId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.HasIndex("TorneoId");

                    b.ToTable("TorneoXEquipos");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.Cancha", b =>
                {
                    b.HasOne("Cancha_Sintetica.Modelos.Inventario", "Inventario")
                        .WithMany("Canchas")
                        .HasForeignKey("InventarioId");

                    b.Navigation("Inventario");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.CanchaXReservaTorneo", b =>
                {
                    b.HasOne("Cancha_Sintetica.Modelos.Cancha", "Cancha")
                        .WithMany("CanchaXReservaTorneos")
                        .HasForeignKey("CanchaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cancha_Sintetica.Modelos.ReservaTorneo", "ReservaTorneo")
                        .WithMany("CanchaXReservaTorneos")
                        .HasForeignKey("ReservaTorneoId");

                    b.Navigation("Cancha");

                    b.Navigation("ReservaTorneo");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.Reserva", b =>
                {
                    b.HasOne("Cancha_Sintetica.Modelos.Cancha", "Cancha")
                        .WithMany("Reservas")
                        .HasForeignKey("CanchaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cancha_Sintetica.Modelos.Cliente", "Cliente")
                        .WithMany("Reservas")
                        .HasForeignKey("ClienteDocumento");

                    b.Navigation("Cancha");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.ReservaTorneo", b =>
                {
                    b.HasOne("Cancha_Sintetica.Modelos.Administrador", "Administrador")
                        .WithMany()
                        .HasForeignKey("AdministradorDocumento");

                    b.HasOne("Cancha_Sintetica.Modelos.Cancha", "Cancha")
                        .WithMany()
                        .HasForeignKey("CanchaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cancha_Sintetica.Modelos.Torneo", "Torneo")
                        .WithMany("ReservaTorneos")
                        .HasForeignKey("TorneoId");

                    b.Navigation("Administrador");

                    b.Navigation("Cancha");

                    b.Navigation("Torneo");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.TorneoXEquipo", b =>
                {
                    b.HasOne("Cancha_Sintetica.Modelos.Equipo", "Equipo")
                        .WithMany("TorneoXEquipos")
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cancha_Sintetica.Modelos.Torneo", "Torneo")
                        .WithMany("TorneoXEquipos")
                        .HasForeignKey("TorneoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");

                    b.Navigation("Torneo");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.Cancha", b =>
                {
                    b.Navigation("CanchaXReservaTorneos");

                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.Cliente", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.Equipo", b =>
                {
                    b.Navigation("TorneoXEquipos");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.Inventario", b =>
                {
                    b.Navigation("Canchas");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.ReservaTorneo", b =>
                {
                    b.Navigation("CanchaXReservaTorneos");
                });

            modelBuilder.Entity("Cancha_Sintetica.Modelos.Torneo", b =>
                {
                    b.Navigation("ReservaTorneos");

                    b.Navigation("TorneoXEquipos");
                });
#pragma warning restore 612, 618
        }
    }
}
