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
        public string Tamaño { get; set; }
        public float Precio { get; set; }
        [ForeignKey(nameof(IdInventario))]
        public string IdInventario { get; set; }
        public Inventario Inventario { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
        public ICollection<CanchaXReservaTorneo> CanchaXReservaTorneos { get; set; }
    }
}
