using Cancha_Sintetica.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancha_Sintetica.Controladores
{
    internal class TorneoControlador
    {
        public static void agregar_inventario(string id, string nombre, DateTime fecha_inicio, DateTime fecha_final, float valor_inscripcion, float premio)
        {
            using var db = new CanchaSinteticaContext();
            db.Add(new Torneo { Id = id, Nombre = nombre, FechaInicio = fecha_inicio, FechaFinal = fecha_final, ValorInscripcion = valor_inscripcion, Premio = premio });
            db.SaveChanges();
        }
    }
}
