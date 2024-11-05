using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cancha_Sintetica.Modelos
{
    internal class CanchaXReservaTorneo
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey(nameof(IdCancha))]
        public string IdCancha { get; set; }
        public Cancha Cancha { get; set; }
        [ForeignKey(nameof(IdReservaTorneo))]
        public string IdReservaTorneo { get; set; }
        public ReservaTorneo ReservaTorneo { get; set; }

    }
}
