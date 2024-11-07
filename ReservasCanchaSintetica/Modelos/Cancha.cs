using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservasCanchaSintetica.Modelos
{
    public class Cancha
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public float Precio { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
        public ICollection<CanchaXReservaTorneo> CanchaXReservaTorneos { get; set; }

        public bool ValidarCancha(out string mensaje_error)
        {
            mensaje_error = "";

            if (Precio <= 0)
            {
                mensaje_error = "El precio de la cancha debe ser mayor a 0.";
                return false;
            }

            return true;

        }
    }
}
