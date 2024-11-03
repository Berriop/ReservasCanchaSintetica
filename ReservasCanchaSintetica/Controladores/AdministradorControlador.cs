using Cancha_Sintetica.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancha_Sintetica.Controladores
{
    internal class AdministradorControlador
    {
        public static void agregar_administrador(string documento, string nombre, string apellidos, string correo, string contraseña)
        {
            using var db = new CanchaSinteticaContext();
            db.Add(new Administrador { Documento = documento, Nombre = nombre, Apellidos = apellidos, Correo = correo, Contraseña = contraseña });
            db.SaveChanges();
        }
    }
}
