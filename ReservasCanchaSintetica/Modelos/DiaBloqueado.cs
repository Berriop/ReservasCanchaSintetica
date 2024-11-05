using System.ComponentModel.DataAnnotations;

namespace ReservasCanchaSintetica.Modelos
{
    internal class DiaBloqueado
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
    }
}
