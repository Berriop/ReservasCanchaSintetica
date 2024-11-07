using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservasCanchaSintetica.Modelos
{
    public class Equipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadJugadores { get; set; }
        public ICollection<TorneoXEquipo> TorneoXEquipos { get; set; }

        public bool ValidarEquipo(out string mensajeError)
        {
            mensajeError = "";

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
