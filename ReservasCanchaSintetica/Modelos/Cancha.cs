using System.ComponentModel.DataAnnotations;

namespace Cancha_Sintetica.Modelos
{
    internal class Cancha
    {
        [Key]
        public string Id { get; set; }
        public float Precio { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
        public ICollection<CanchaXReservaTorneo> CanchaXReservaTorneos { get; set; }

        public bool ValidarCancha(out string mensaje_error)
        {
            mensaje_error = "";

            if (string.IsNullOrWhiteSpace(Id))
            {
                mensaje_error = "El ID de la cancha no puede estar vacío.";
                return false;
            }

            if (Precio <= 0)
            {
                mensaje_error = "El precio de la cancha debe ser mayor a 0.";
                return false;
            }

            return true;

        }
    }
}
