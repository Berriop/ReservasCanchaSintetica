using Cancha_Sintetica.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancha_Sintetica.Controladores
{
    internal class EquipoControlador
    {
        public static void agregar_equipo(string id, string nombre, int cantidad_jugadores)
        {
            using var db = new CanchaSinteticaContext();
            db.Add(new Equipo { Id = id, Nomrbre = nombre, CantidadJugadores = cantidad_jugadores });
            db.SaveChanges();
        }
    }
}
