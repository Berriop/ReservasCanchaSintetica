using Cancha_Sintetica.Modelos;

namespace Cancha_Sintetica.Controladores
{
    internal class ClienteControlador
    {
        private readonly CanchaSinteticaContext BD;

        public ClienteControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgregarCliente(string documento, string nombre, string apellidos, string telefono, string correo, string contraseña, float saldo)
        {
            var cliente = new Cliente { Documento = documento, Nombre = nombre, Apellidos = apellidos, Telefono = telefono, Correo = correo, Contraseña = contraseña, Saldo = saldo };

            if (!cliente.ValidarCliente(out string mensaje_error))
            {
                throw new Exception(mensaje_error);
            }
            ValidarClienteExistente(cliente.Documento, cliente.Correo);

            BD.Add(cliente);
            BD.SaveChanges();
        }

        public bool ValidarClienteExistente(string documento, string correo)
        {
            if (BD.Clientes.Any(c => c.Documento == documento))
            {
                throw new Exception("Ya existe un cliente con este documento.");
            }
            if (BD.Clientes.Any(c => c.Correo == correo))
            {
                throw new Exception("Ya existe un cliente registrado con este correo electrónico.");
            }
            return true;
        }


        public void RealizarReserva(string id, DateTime fecha, int cantidad_horas, int cantidad_balones, int cantidad_aguas, float precio_total, string documento_cliente, string id_cancha)
        {
            var controlador_reserva = new ReservaControlador(BD);
            controlador_reserva.AgregarReserva(id, fecha, cantidad_horas, cantidad_balones, cantidad_aguas, precio_total, documento_cliente, id_cancha);
        }

        public List<Reserva> VisualizarReservas(string documento_cliente)
        {
            var cliente = BD.Clientes.FirstOrDefault(c => c.Documento == documento_cliente);

            if(cliente == null)
            {
                throw new Exception("El cliente no existe.");
            }

            var reservas = BD.Reservas.Where(r => r.DocumentoCliente == documento_cliente).ToList();

            if (reservas.Count == 0)
            {
                throw new Exception("No hay reservas para este cliente.");
            }

            return reservas;
        }

        public void CancelarReserva(string id_reserva, string documento_cliente)
        {
            var cliente = BD.Clientes.FirstOrDefault(c => c.Documento == documento_cliente);

            if (cliente == null)
            {
                throw new Exception("El cliente no existe.");
            }

            var reserva = BD.Reservas.FirstOrDefault(r => r.Id == id_reserva);

            if(reserva == null)
            {
                throw new Exception("La reserva no existe");
            }

            if(reserva.DocumentoCliente != documento_cliente)
            {
                throw new Exception("La reserva no pertenece a este cliente");
            }

            BD.Reservas.Remove(reserva);
            BD.SaveChanges();

            cliente.Saldo += reserva.PrecioTotal;
            BD.SaveChanges();
        }
    }
}
