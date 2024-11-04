using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancha_Sintetica.Modelos
{
    internal class Cancha
    {
        [Key]
        public string Id { get; set; }
        public float Precio { get; set; }
        [ForeignKey(nameof(IdInventario))]
        public string IdInventario { get; set; }
        public Inventario Inventario { get; set; }
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
            if (string.IsNullOrWhiteSpace(IdInventario))
            {
                mensaje_error = "La cancha debe tener un ID de inventario asociado.";
                return false;
            }

            return true;

        }
    }
}
