using Cancha_Sintetica.Modelos;

namespace Cancha_Sintetica.Controladores
{
    internal class ReservaTorneoControlador
    {
        private readonly CanchaSinteticaContext BD;

        public ReservaTorneoControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgregarReservaTorneo(string id, DateTime fecha, int cantidad_horas, int cantidad_balones, int cantidad_aguas, string documento_administrador, string id_torneo, string id_cancha)
        {
            var reserva_torneo = new ReservaTorneo { Id = id, Fecha = fecha, CantidadHoras = cantidad_horas, CantidadBalones = cantidad_balones, CantidadAguas = cantidad_aguas, DocumentoAdministrador = documento_administrador, IdTorneo = id_torneo, IdCancha = id_cancha };
            
            if(!reserva_torneo.ValidarReserva(out string mensaje_error))
            {
                throw new Exception(mensaje_error);
            }

            var dia_bloqueado = BD.DiasBloqueados.FirstOrDefault(d => d.Fecha.Date == reserva_torneo.Fecha.Date);
            if (dia_bloqueado != null)
            {
                throw new Exception("No se pude realizar reservar para el dia seleccionado.");
            }

            VerificarDisponibilidadParaTorneos(reserva_torneo.IdCancha, reserva_torneo.Fecha, reserva_torneo.CantidadHoras);

            BD.Add(reserva_torneo);
            BD.SaveChanges();

            var inventario = BD.Inventarios.FirstOrDefault();
            inventario.CantidadBalones -= cantidad_balones;
            inventario.CantidadAguas -= cantidad_aguas;
            BD.SaveChanges();
        }

        public bool VerificarDisponibilidadParaTorneos(string id_cancha, DateTime fecha, int cantidad_horas)
        {
            var reservas = BD.Reservas.Where(r => r.IdCancha == id_cancha && r.Fecha < fecha.AddHours(cantidad_horas)).ToList();
            if (reservas.Any())
            {
                throw new Exception("La cancha ya está ocupada para el horario solicitado.");
            }
            return true;
        }
    }
}
