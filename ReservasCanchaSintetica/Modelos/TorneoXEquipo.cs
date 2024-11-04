using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cancha_Sintetica.Modelos
{
    internal class TorneoXEquipo
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey(nameof(IdEquipo))]
        public string IdEquipo { get; set; }
        public Equipo Equipo { get; set; }
        [ForeignKey(nameof(IdTorneo))]
        public string IdTorneo { get; set; }
        public Torneo Torneo { get; set; }

    }
}
