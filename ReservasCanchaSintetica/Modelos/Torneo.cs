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

    }
}
