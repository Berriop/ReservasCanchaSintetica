using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancha_Sintetica.Modelos
{
    internal class Inventario
    {
        [Key]
        public string Id { get; set; }
        public int CantidadBalones { get; set; }
        public int CantidadAguas { get; set; }
        public int CantidadPetos { get; set; }
        public ICollection<Cancha> Canchas { get; set; }
    }
}
