﻿using Cancha_Sintetica.Modelos;

namespace Cancha_Sintetica.Controladores
{
    internal class InventarioControlador
    {
        private readonly CanchaSinteticaContext BD;

        public InventarioControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgregarInventario(string id, int cantidad_balones, int cantidad_aguas)
        {
            var inventario = new Inventario { Id = id, CantidadBalones = cantidad_balones, CantidadAguas = cantidad_aguas };

            if (!inventario.ValidarInventario(out string mensaje_error))
            {
                throw new Exception(mensaje_error);
            }

            BD.Add(inventario);
            BD.SaveChanges();
        }

        public bool ValidarInventarioDisponible(int balones_solicitados, int aguas_solicitadas, Inventario inventario)
        {
            if (inventario.CantidadBalones < balones_solicitados)
            {
                throw new Exception("No hay suficiente cantidad de balones en el inventario.");
            }
            if (inventario.CantidadAguas < aguas_solicitadas)
            {
                throw new Exception("No hay suficiente cantidad de aguas en el inventario.");
            }

            return true;
        }

    }
}
