using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservasCanchaSintetica.Modelos
{
    public class TorneoXEquipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey(nameof(IdEquipo))]
        public int IdEquipo { get; set; }
        [ForeignKey(nameof(IdTorneo))]
        public int IdTorneo { get; set; }

    }
}
