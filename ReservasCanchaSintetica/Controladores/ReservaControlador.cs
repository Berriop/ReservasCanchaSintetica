using ReservasCanchaSintetica.Modelos;

namespace ReservasCanchaSintetica.Controladores
{
    public class ReservaControlador
    {
        public CanchaSinteticaContext BD;

        public ReservaControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgregarReserva(DateTime fecha, int cantidad_horas, int cantidad_balones, int cantidad_aguas, float precio_total, string documento_cliente, int id_cancha)
        {
            var reserva = new Reserva {Fecha = fecha, CantidadHoras = cantidad_horas, CantidadBalones = cantidad_balones, CantidadAguas = cantidad_aguas, PrecioTotal = precio_total, DocumentoCliente = documento_cliente, IdCancha = id_cancha };
            if (!reserva.ValidarReserva(out string mensaje_error))
            {
                MessageBox.Show(mensaje_error);
                return;
            }

            var dia_bloqueado = BD.DiasBloqueados.FirstOrDefault(d => d.Fecha.Date == reserva.Fecha.Date);
            if(dia_bloqueado != null)
            {
                MessageBox.Show("No se pude realizar reservar para el dia seleccionado.");
                return;
            }

            ValidarDisponibilidadCancha(reserva.IdCancha, reserva.Fecha, reserva.CantidadHoras);

            var cliente = BD.Clientes.Find(reserva.DocumentoCliente);
            ValidarSaldoSuficiente(cliente, reserva.PrecioTotal);

            BD.Reservas.Add(reserva);
            BD.SaveChanges();

            cliente.Saldo -= precio_total;
            BD.SaveChanges();

            var inventario = BD.Inventarios.FirstOrDefault();
            inventario.CantidadBalones -= cantidad_balones;
            inventario.CantidadAguas -= cantidad_aguas;
            BD.SaveChanges();
        }

        public bool ValidarDisponibilidadCancha(int id_cancha, DateTime fecha, int cantidad_horas)
        {
            var reservas = BD.Reservas.Where(r => r.IdCancha == id_cancha).ToList();
            foreach (var reserva in reservas)
            {
                if (reserva.Fecha < fecha.AddHours(cantidad_horas) && fecha < reserva.Fecha.AddHours(reserva.CantidadHoras))
                {
                    MessageBox.Show("La cancha ya está reservada para el horario solicitado.");
                    return false;
                }
            }
            return true;
        }

        public bool ValidarSaldoSuficiente(Cliente cliente, float costo_reserva)
        {
            if (cliente.Saldo < costo_reserva)
            {
                MessageBox.Show("El saldo del cliente es insuficiente para realizar la reserva.");
                return false;
            }
            return true;
        }
    }
}
