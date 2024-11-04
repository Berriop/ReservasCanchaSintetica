using Cancha_Sintetica.Modelos;

namespace Cancha_Sintetica.Controladores
{
    internal class TorneoControlador
    {
        private readonly CanchaSinteticaContext BD;

        public TorneoControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgregarTorneo(string id, string nombre, DateTime fecha_inicio, DateTime fecha_final, float valor_inscripcion, float premio)
        {
            var torneo = new Torneo { Id = id, Nombre = nombre, FechaInicio = fecha_inicio, FechaFinal = fecha_final, ValorInscripcion = valor_inscripcion, Premio = premio };

            if (!torneo.ValidarTorneo(out string mensaje_error))
            {
                throw new Exception(mensaje_error);
            }

            BD.Add(torneo);
            BD.SaveChanges();
        }
    }
}
