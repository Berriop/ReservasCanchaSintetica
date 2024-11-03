using Cancha_Sintetica.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancha_Sintetica.Controladores
{
    internal class InventarioControlador
    {
        public static void agregar_inventario(string id, int cantidad_balones, int cantidad_aguas, int cantidad_petos)
        {
            using var db = new CanchaSinteticaContext();
            db.Add(new Inventario { Id = id, CantidadBalones = cantidad_balones, CantidadAguas = cantidad_aguas, CantidadPetos = cantidad_petos });
            db.SaveChanges();
        }
    }
}
