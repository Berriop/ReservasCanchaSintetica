using Cancha_Sintetica.Modelos;

namespace Cancha_Sintetica.Controladores
{
    internal class AdministradorControlador
    {
        private readonly CanchaSinteticaContext BD;

        public AdministradorControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgreagarAdministrador(string documento, string nombre, string apellidos, string correo, string contraseña)
        {
            var administrador = new Administrador { Documento = documento, Nombre = nombre, Apellidos = apellidos, Correo = correo, Contraseña = contraseña };

            if(administrador.ValidarAdministrador(out string mensaje_error))
            {
                throw new Exception(mensaje_error);
            }

            BD.Add(administrador);
            BD.SaveChanges();
        }
    }
}
