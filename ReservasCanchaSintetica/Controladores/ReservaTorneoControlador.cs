using Cancha_Sintetica.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancha_Sintetica.Controladores
{
    internal class ReservaTorneoControlador
    {
        public static void agregar_reserva_torneo(string id, DateTime fecha, int cantidad_horas, int cantidad_balones, int cantidad_aguas, string documento_administrador, string id_torneo, string id_cancha)
        {
            using var db = new CanchaSinteticaContext();
            db.Add(new ReservaTorneo { Id = id, Fecha = fecha, CantidadHoras = cantidad_horas, CantidadBalones = cantidad_balones, CantidadAguas = cantidad_aguas, DocumentoAdministrador = documento_administrador, IdTorneo = id_torneo, IdCancha = id_cancha });
            db.SaveChanges();
        }
    }
}
