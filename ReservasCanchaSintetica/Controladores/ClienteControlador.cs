using ReservasCanchaSintetica.Modelos;

namespace ReservasCanchaSintetica.Controladores
{
    internal class ClienteControlador
    {
        public CanchaSinteticaContext BD;

        public ClienteControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgregarCliente(string documento, string nombre, string apellidos, string telefono, string correo, string contraseña, float saldo)
        {
            var cliente = new Cliente { Documento = documento, Nombre = nombre, Apellidos = apellidos, Telefono = telefono, Correo = correo, Contraseña = contraseña, Saldo = saldo };

            if (!cliente.ValidarCliente(out string mensaje_error))
            {
                MessageBox.Show(mensaje_error);
                return;
            }

            BD.Clientes.Add(cliente);
            BD.SaveChanges();
        }


        public void RealizarReserva(DateTime fecha, int cantidad_horas, int cantidad_balones, int cantidad_aguas, float precio_total, string documento_cliente, int id_cancha)
        {
            var controlador_reserva = new ReservaControlador(BD);
            controlador_reserva.AgregarReserva(fecha, cantidad_horas, cantidad_balones, cantidad_aguas, precio_total, documento_cliente, id_cancha);
        }

        public List<Reserva> VisualizarReservas(string documento_cliente)
        {
            var cliente = BD.Clientes.FirstOrDefault(c => c.Documento == documento_cliente);

            if(cliente == null)
            {
                MessageBox.Show("El cliente no existe.");
            }

            var reservas = BD.Reservas.Where(r => r.DocumentoCliente == documento_cliente).ToList();

            if (reservas.Count == 0)
            {
                MessageBox.Show("No hay reservas para este cliente.");
            }

            return reservas;
        }

        public void CancelarReserva(int id_reserva, string documento_cliente)
        {
            var cliente = BD.Clientes.FirstOrDefault(c => c.Documento == documento_cliente);

            if (cliente == null)
            {
                MessageBox.Show("El cliente no existe.");
                return;
            }

            var reserva = BD.Reservas.FirstOrDefault(r => r.Id == id_reserva);

            if(reserva == null)
            {
                MessageBox.Show("La reserva no existe");
                return;
            }

            if(reserva.DocumentoCliente != documento_cliente)
            {
                MessageBox.Show("La reserva no pertenece a este cliente");
                return;
            }

            BD.Reservas.Remove(reserva);
            BD.SaveChanges();

            cliente.Saldo += reserva.PrecioTotal;
            BD.SaveChanges();
        }
    }
}
