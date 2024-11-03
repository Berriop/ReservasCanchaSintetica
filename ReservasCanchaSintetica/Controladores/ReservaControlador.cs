using Cancha_Sintetica.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancha_Sintetica.Controladores
{
    internal class ReservaControlador
    {
        public static void agregar_reserva(string id, DateTime fecha, int cantidad_horas, int cantidad_balones, int cantidad_aguas, float precio_total, string documento_cliente, string id_cancha)
        {
            using var db = new CanchaSinteticaContext();
            db.Add(new Reserva { Id = id, Fecha = fecha, CantidadHoras = cantidad_horas, CantidadBalones = cantidad_balones, CantidadAguas = cantidad_aguas, PrecioTotal = precio_total, DocumentoCliente = documento_cliente, IdCancha = id_cancha });
            db.SaveChanges();
        }
    }
}
