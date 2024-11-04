using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancha_Sintetica.Modelos
{
    internal class Torneo
    {
        [Key]
        public string Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public float ValorInscripcion { get; set; }
        public float Premio { get; set; }
        public ICollection<TorneoXEquipo> TorneoXEquipos { get; set; }
        public ICollection<ReservaTorneo> ReservaTorneos { get; set; }


        public bool ValidarTorneo(out string mensaje_error)
        {
            mensaje_error = "";

            if (string.IsNullOrWhiteSpace(Id))
            {
                mensaje_error = "El ID del torneo no puede estar vacío.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Nombre) || Nombre.Length < 3)
            {
                mensaje_error = "El nombre del torneo debe tener al menos 3 caracteres.";
                return false;
            }
            if (FechaInicio < DateTime.Now)
            {
                mensaje_error = "La fecha de inicio del torneo debe ser futura.";
                return false;
            }
            if (FechaFinal <= FechaInicio)
            {
                mensaje_error = "La fecha de finalización debe ser posterior a la fecha de inicio.";
                return false;
            }
            if (ValorInscripcion < 0)
            {
                mensaje_error = "El valor de inscripción no puede ser negativo.";
                return false;
            }
            if (Premio < ValorInscripcion)
            {
                mensaje_error = "El premio debe ser mayor o igual al valor de inscripción.";
                return false;
            }

            return true;
        }
    }
}
