using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancha_Sintetica.Modelos
{
    internal class Reserva
    {
        [Key]
        public string Id { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadHoras { get; set; }
        public int CantidadBalones { get; set; }
        public int CantidadAguas { get; set; }
        public float PrecioTotal { get; set; }
        [ForeignKey(nameof(DocumentoCliente))]
        public string DocumentoCliente { get; set; }
        public Cliente Cliente { get; set; }

        [ForeignKey(nameof(IdCancha))]
        public string IdCancha { get; set; }
        public Cancha Cancha { get; set; }

    }
}
