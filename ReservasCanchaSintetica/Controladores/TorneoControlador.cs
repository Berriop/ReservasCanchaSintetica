﻿using ReservasCanchaSintetica.Modelos;

namespace ReservasCanchaSintetica.Controladores
{
    public class TorneoControlador
    {
        public CanchaSinteticaContext BD;

        public TorneoControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgregarTorneo(string nombre, DateTime fecha_inicio, DateTime fecha_final, float valor_inscripcion, float premio)
        {
            var torneo = new Torneo { Nombre = nombre, FechaInicio = fecha_inicio, FechaFinal = fecha_final, ValorInscripcion = valor_inscripcion, Premio = premio };

            if (!torneo.ValidarTorneo(out string mensaje_error))
            {
                MessageBox.Show(mensaje_error);
                return;
            }

            BD.Torneos.Add(torneo);
            BD.SaveChanges();
        }
    }
}
