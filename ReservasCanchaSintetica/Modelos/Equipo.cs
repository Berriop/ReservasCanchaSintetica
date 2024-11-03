using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancha_Sintetica.Modelos
{
    internal class Equipo
    {
        [Key]
        public string Id { get; set; }
        public string Nomrbre { get; set; }
        public int CantidadJugadores { get; set; }
        public ICollection<TorneoXEquipo> TorneoXEquipos { get; set; }
    }
}
