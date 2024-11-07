using Microsoft.EntityFrameworkCore;
using ReservasCanchaSintetica.Modelos;

namespace ReservasCanchaSintetica
{
    public class CanchaSinteticaContext : DbContext
    {
        public CanchaSinteticaContext(DbContextOptions options) : base(options)
        {
        }

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
        public DbSet<DiaBloqueado> DiasBloqueados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source = cancha_sintetica.db");
        }
    }
}
