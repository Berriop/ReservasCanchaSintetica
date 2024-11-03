﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cancha_Sintetica.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Cancha_Sintetica
{
    internal class CanchaSinteticaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Cancha> Canchas { get; set; }
        public DbSet<CanchaXReservaTorneo> CanchaXReservaTorneos { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<ReservaTorneo> ReservaTorneos { get; set; }
        public DbSet<Torneo> Torneos { get; set; }
        public DbSet<TorneoXEquipo> TorneoXEquipos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source = cancha_sintetica.db");
        }
    }
}
