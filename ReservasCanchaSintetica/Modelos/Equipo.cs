using System.ComponentModel.DataAnnotations;

namespace Cancha_Sintetica.Modelos
{
    internal class Equipo
    {
        [Key]
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadJugadores { get; set; }
        public ICollection<TorneoXEquipo> TorneoXEquipos { get; set; }

        public bool ValidarEquipo(out string mensajeError)
        {
            mensajeError = "";

            if (string.IsNullOrWhiteSpace(Id))
            {
                mensajeError = "El ID del equipo no puede estar vacío.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Nombre) || Nombre.Length < 3)
            {
                mensajeError = "El nombre del equipo debe tener al menos 3 caracteres.";
                return false;
            }
            if (CantidadJugadores < 5 || CantidadJugadores > 15)
            {
                mensajeError = "El equipo debe tener entre 5 y 15 jugadores.";
                return false;
            }

            return true;
        }
    }
}
