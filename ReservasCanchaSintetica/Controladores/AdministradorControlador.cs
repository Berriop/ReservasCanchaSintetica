using Cancha_Sintetica.Modelos;
using ReservasCanchaSintetica;

namespace Cancha_Sintetica.Controladores
{
    internal class AdministradorControlador
    {
        private readonly CanchaSinteticaContext BD;

        public AdministradorControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgreagarAdministrador(string documento, string nombre, string apellidos, string correo, string contraseña)
        {
            var administrador = new Administrador { Documento = documento, Nombre = nombre, Apellidos = apellidos, Correo = correo, Contraseña = contraseña };

            if (administrador.ValidarAdministrador(out string mensaje_error))
            {
                throw new Exception(mensaje_error);
            }

            BD.Add(administrador);
            BD.SaveChanges();
        }

        public void AgregarEquipo(string id, string nombre, int cantidad_jugadores)
        {
            var controlador_equipo = new EquipoControlador(BD);
            controlador_equipo.AgregarEquipo(id, nombre, cantidad_jugadores);
        }

        public void CrearTorneo(string id, string nombre, DateTime fecha_iniico, DateTime fecha_final, float valor_inscripcion, float premio)
        {
            var controlador_torneo = new TorneoControlador(BD);
            controlador_torneo.AgregarTorneo(id, nombre, fecha_iniico, fecha_final, valor_inscripcion, premio);
        }

        public void RealizarReservaTorneo(string id, DateTime fecha, int cantidad_horas, int cantidad_balones, int cantidad_aguas, string documento_administrador, string id_torneo, string id_cancha)
        {
            var controlador_reserva = new ReservaTorneoControlador(BD);
            controlador_reserva.AgregarReservaTorneo(id, fecha, cantidad_horas, cantidad_balones, cantidad_aguas, documento_administrador, id_torneo, id_cancha);
        }

        public void AgregarElementosInventario(int cantidad_balones, int cantidad_aguas)
        {
            var inventario = BD.Inventarios.FirstOrDefault();

            if (inventario == null)
            {
                throw new Exception("El inventario no existe en la base de datos.");
            }

            if (cantidad_balones < 0 || cantidad_aguas < 0)
            {
                throw new ArgumentException("Las cantidades no pueden ser negativas.");
            }

            inventario.CantidadBalones += cantidad_balones;
            inventario.CantidadAguas += cantidad_aguas;
            BD.SaveChanges();
        }

        public void BloquearDia(DateTime fecha)
        {
            var dia_a_bloquear = new DiaBloqueado { Fecha = fecha };

            var dia = BD.DiasBloqueados.FirstOrDefault(d => d.Fecha.Date == fecha.Date);
            if (dia != null)
            {
                throw new Exception("El día ya está bloqueado para reservas.");
            }

            BD.Add(dia_a_bloquear);
            BD.SaveChanges();
        }

        public void DesbloquearDia(DateTime fecha)
        {
            var dia_bloqueado = BD.DiasBloqueados.FirstOrDefault(d => d.Fecha.Date == fecha.Date);
            if (dia_bloqueado == null)
            {
                throw new Exception("No se encontro un dia bloqueado para la fecha especificada");
            }

            BD.DiasBloqueados.Remove(dia_bloqueado);
            BD.SaveChanges();
        }

        public IEnumerable<dynamic> VerHistorialPagosMensual()
        {
            var historial = BD.Reservas.GroupBy(r => new { r.Fecha.Year, r.Fecha.Month }).Select(g => new { año = g.Key.Year, mes = g.Key.Month, pagos = g.Sum(r => r.PrecioTotal) }).OrderBy(h => h.año).ThenBy(h => h.mes).ToList();
            return historial;
        }

        public IEnumerable<dynamic> CantidadReservasMensual()
        {
            var reservas_por_mes = BD.Reservas.GroupBy(r => new { r.Fecha.Year, r.Fecha.Month }).Select(g => new { año = g.Key.Year, mes = g.Key.Month, cantidad_reservas = g.Count() }).OrderBy(h => h.año).ThenBy(h => h.mes).ToList();

            return reservas_por_mes;
        }

        public IEnumerable<dynamic> PromedioPrecioPorMes()
        {
            var promedio_por_mes = BD.Reservas.GroupBy(r => new { r.Fecha.Year, r.Fecha.Month }).Select(g => new { año = g.Key.Year, mes = g.Key.Month, total_reservas = g.Count(), precio_total = g.Sum(r => r.PrecioTotal), promedio_precio = g.Count() > 0 ? g.Sum(r => r.PrecioTotal) / g.Count() : 0 }).OrderBy(h => h.año).ThenBy(h => h.mes).ToList();

            return promedio_por_mes;
        }
    }
} 
 