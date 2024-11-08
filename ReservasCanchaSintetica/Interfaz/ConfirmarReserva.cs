using ReservasCanchaSintetica.Controladores;
using ReservasCanchaSintetica.Modelos;
using ReservasCanchaSintetica.Servicios;

namespace ReservasCanchaSintetica
{
    public partial class ConfirmarReserva : Form
    {
        public Cliente Cliente { get; set; }
        public int CanchaSeleccionada { get; set; }
        public DateTime FechaReserva { get; set; }
        public string HoraInicio { get; set; }
        public int CantidadHoras { get; set; }
        public CanchaSinteticaContext Context { get; set; }
        public ConfirmarReserva(Cliente cliente, int cancha_seleccionada, DateTime fecha_reserva, string hora_inicio, int cantidad_horas, CanchaSinteticaContext context)
        {
            InitializeComponent();
            this.Cliente = cliente;
            this.CanchaSeleccionada = cancha_seleccionada;
            this.FechaReserva = fecha_reserva;
            this.HoraInicio = hora_inicio;
            this.CantidadHoras = cantidad_horas;
            this.Context = context;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad_aguas = int.Parse(numericdowm_aguas.Value.ToString());
            int cantidad_balones = int.Parse(numericdowm_aguas.Value.ToString());
            float precio_total = (CantidadHoras * 50000) + (cantidad_aguas * 3000) + (cantidad_balones * 5000);

            var resultado = new ResultadoReserva();

            try
            {
                var controlador_cliente = new ClienteControlador(Context);
                controlador_cliente.RealizarReserva(FechaReserva, CantidadHoras, cantidad_balones, cantidad_aguas, precio_total, Cliente.Documento, CanchaSeleccionada);
                resultado.Exitoso = true;
            }
            catch (Exception ex)
            {
                resultado.Exitoso = false;
                resultado.MensajeError = "Error en el servidor: " + ex.Message;
            }

            if (resultado.Exitoso)
            {
                MessageBox.Show("Reserva realizada con éxito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al realizar la reserva: " + resultado.MensajeError);
            }
        }
    }
}
