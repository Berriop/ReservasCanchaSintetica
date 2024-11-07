using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ReservasCanchaSintetica.Modelos
{
    public class Administrador
    {
        [Key]
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        public bool ValidarAdministrador(out string mensaje_error)
        {
            mensaje_error = "";

            if (string.IsNullOrWhiteSpace(Documento) || Documento.Length < 6 || Documento.Length > 12)
            {
                mensaje_error = "El documento debe tener entre 6 y 12 caracteres.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Nombre) || Nombre.Length < 2)
            {
                mensaje_error = "El nombre debe tener al menos 2 caracteres.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(Apellidos) || Apellidos.Length < 2)
            {
                mensaje_error = "Los apellidos deben tener al menos 2 caracteres.";
                return false;
            }

            if (!Regex.IsMatch(Correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                mensaje_error = "El correo no tiene un formato válido.";
                return false;
            }

            if (Contraseña.Length < 6)
            {
                mensaje_error = "La contraseña debe tener al menos 6 caracteres.";
                return false;
            }

            return true;
        }

    }
}
