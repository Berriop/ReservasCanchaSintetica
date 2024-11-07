using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservasCanchaSintetica.Modelos
{
    public class Inventario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CantidadBalones { get; set; }
        public int CantidadAguas { get; set; }

        public bool ValidarInventario(out string mensaje_error)
        {
            mensaje_error = "";

            if (CantidadBalones < 0)
            {
                mensaje_error = "La cantidad de balones no puede ser negativa.";
                return false;
            }
            if (CantidadAguas < 0)
            {
                mensaje_error = "La cantidad de aguas no puede ser negativa.";
                return false;
            }

            return true;
        }
    }
}
