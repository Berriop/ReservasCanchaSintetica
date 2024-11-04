using Cancha_Sintetica.Modelos;

namespace Cancha_Sintetica.Controladores
{
    internal class ReservaControlador
    {
        private readonly CanchaSinteticaContext BD;

        public ReservaControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgregarReserva(string id, DateTime fecha, int cantidad_horas, int cantidad_balones, int cantidad_aguas, float precio_total, string documento_cliente, string id_cancha)
        {
            var reserva = new Reserva { Id = id, Fecha = fecha, CantidadHoras = cantidad_horas, CantidadBalones = cantidad_balones, CantidadAguas = cantidad_aguas, PrecioTotal = precio_total, DocumentoCliente = documento_cliente, IdCancha = id_cancha };
            
            if (!reserva.ValidarReserva(out string mensaje_error))
            {
                throw new Exception(mensaje_error);
            }
            ValidarDisponibilidadCancha(reserva.IdCancha, reserva.Fecha, reserva.CantidadHoras);

            var cliente = BD.Clientes.Find(reserva.DocumentoCliente);
            ValidarSaldoSuficiente(cliente, reserva.PrecioTotal);

            BD.Add(reserva);
            BD.SaveChanges();
        }

        public bool ValidarDisponibilidadCancha(string id_cancha, DateTime fecha, int cantidad_horas)
        {
            var reservas = BD.Reservas.Where(r => r.IdCancha == id_cancha).ToList();
            foreach (var reserva in reservas)
            {
                if (reserva.Fecha < fecha.AddHours(cantidad_horas) && fecha < reserva.Fecha.AddHours(reserva.CantidadHoras))
                {
                    throw new Exception("La cancha ya está reservada para el horario solicitado.");
                }
            }
            return true;
        }

        public bool ValidarSaldoSuficiente(Cliente cliente, float costo_reserva)
        {
            if (cliente.Saldo < costo_reserva)
            {
                throw new Exception("El saldo del cliente es insuficiente para realizar la reserva.");
            }
            return true;
        }
    }
}
