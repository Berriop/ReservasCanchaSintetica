﻿using Cancha_Sintetica.Modelos;

namespace Cancha_Sintetica.Controladores
{
    internal class EquipoControlador
    {
        private readonly CanchaSinteticaContext BD;

        public EquipoControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgregarEquipo(string id, string nombre, int cantidad_jugadores)
        {
            var equipo = new Equipo { Id = id, Nombre = nombre, CantidadJugadores = cantidad_jugadores };

            if(equipo.ValidarEquipo(out string mensaje_error))
            {
                throw new Exception(mensaje_error);
            }

            ValidarEquiposNoRepetidos();

            BD.Add(equipo);
            BD.SaveChanges();
        }

        private void ValidarEquiposNoRepetidos()
        {
            var equipos_inscritos = new HashSet<string>();

            foreach (var equipo in BD.Equipos)
            {
                if (!equipos_inscritos.Add(equipo.Nombre))
                {
                    throw new Exception($"El equipo '{equipo.Nombre}' ya está inscrito en el torneo.");
                }
            }
        }
    }
}
