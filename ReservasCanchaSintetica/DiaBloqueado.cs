using System.ComponentModel.DataAnnotations;

namespace ReservasCanchaSintetica
{
    internal class DiaBloqueado
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
    }
}
