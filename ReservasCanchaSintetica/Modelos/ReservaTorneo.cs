using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancha_Sintetica.Modelos
{
    internal class ReservaTorneo
    {
        [Key]
        public string Id { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadHoras { get; set; }
        public int CantidadBalones { get; set; }
        public int CantidadAguas { get; set; }
        [ForeignKey(nameof(DocumentoAdministrador))]
        public string DocumentoAdministrador { get; set; }
        public Administrador Administrador { get; set; }
        [ForeignKey(nameof(IdTorneo))]
        public string IdTorneo { get; set; }
        public Torneo Torneo { get; set; }
        [ForeignKey(nameof(IdCancha))]
        public string IdCancha { get; set; }
        public Cancha Cancha { get; set; }
        public ICollection<CanchaXReservaTorneo> CanchaXReservaTorneos { get; set; }

    }
}
