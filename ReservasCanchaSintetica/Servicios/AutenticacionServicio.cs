using ReservasCanchaSintetica.Controladores;
using Microsoft.EntityFrameworkCore;

namespace ReservasCanchaSintetica.Servicios
{
    internal class AutenticacionServicio
    {
        public static async Task<ResultadoInicioSesion> IniciarSesionAsync(string documento, string contraseña, CanchaSinteticaContext Context)
        {
            var resultado = new ResultadoInicioSesion();

            try
            {
                var cliente = await Context.Clientes.Where(c => c.Documento == documento && c.Contraseña == contraseña).FirstOrDefaultAsync();
                if (cliente != null)
                {
                   
                    resultado.Exitoso = true;
                   
                    resultado.TipoUsuario = "Cliente";
                   
                    resultado.Usuario = cliente;
                   
                    return resultado;
                }
                var admin = await Context.Administradores.Where(a => a.Documento == documento && a.Contraseña == contraseña).FirstOrDefaultAsync();
                if (admin != null)
                {
                   
                    resultado.Exitoso = true;
                   
                    resultado.TipoUsuario = "Administrador";
                   
                    resultado.Usuario = admin;
                   
                    return resultado;
                }
                resultado.Exitoso = false;
                resultado.MensajeError = "Usuario o contraseña incorrectos.";

            }
            catch (Exception ex)
            {
                resultado.Exitoso = false;
                resultado.MensajeError = "Error en el servidor: " + ex.Message;
            }

            return resultado;
        }

        public static async Task<ResultadoRegistro> RegistrarClienteAsync(string documento, string nombre, string apellidos, string telefono, string correo, string contraseña, float saldo, CanchaSinteticaContext Context)
        {
            var resultado = new ResultadoRegistro();

            try
            {
                var cliente_existente = await Context.Clientes.AnyAsync(c => c.Documento == documento);
                if (cliente_existente)
                {
                   
                    resultado.Exitoso = false;
                   
                    resultado.MensajeError = "El nombre de usuario ya está en uso.";
                   
                    return resultado;
                }
                var controlador_cliente = new ClienteControlador(Context);
                controlador_cliente.AgregarCliente(documento, nombre, apellidos, telefono, correo, contraseña, saldo);
                resultado.Exitoso = true;

            }
            catch (Exception ex)
            {
                resultado.Exitoso = false;
                resultado.MensajeError = "Error en el servidor: " + ex.Message;
            }

            return resultado;
        }
    }
}
