using Cancha_Sintetica.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancha_Sintetica.Controladores
{
    internal class ClienteControlador
    {
        public static void agregar_cliente(string documento, string nombre, string apellidos, string telefono, string correo, string contraseña, float saldo)
        {
            using var db = new CanchaSinteticaContext();
            db.Add(new Cliente { Documento = documento, Nombre = nombre, Apellidos = apellidos, Telefono = telefono, Correo = correo, Contraseña = contraseña, Saldo = saldo });
            db.SaveChanges();
        }
    }
}
