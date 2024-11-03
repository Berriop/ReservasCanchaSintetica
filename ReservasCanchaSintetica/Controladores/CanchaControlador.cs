using Cancha_Sintetica.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cancha_Sintetica.Controladores
{
    internal class CanchaControlador
    {
        public static void agregar_cancha(string id, string tamaño, float precio, string id_inventario)
        {
            using var db = new CanchaSinteticaContext();
            db.Add(new Cancha { Id = id, Tamaño = tamaño, Precio = precio, IdInventario = id_inventario });
            db.SaveChanges();
        }
    }
}
