using System.ComponentModel.DataAnnotations;

namespace Cancha_Sintetica.Modelos
{
    internal class Inventario
    {
        [Key]
        public string Id { get; set; }
        public int CantidadBalones { get; set; }
        public int CantidadAguas { get; set; }

        public bool ValidarInventario(out string mensaje_error)
        {
            mensaje_error = "";

            if (string.IsNullOrWhiteSpace(Id))
            {
                mensaje_error = "El ID del inventario no puede estar vacío.";
                return false;
            }
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
