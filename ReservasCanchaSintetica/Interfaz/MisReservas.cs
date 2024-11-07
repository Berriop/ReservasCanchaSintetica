using ReservasCanchaSintetica.Controladores;
using ReservasCanchaSintetica.Modelos;

namespace ReservasCanchaSintetica
{
    public partial class MisReservas : Form
    {
        public Cliente Cliente { get; set; }
        public CanchaSinteticaContext Context { get; set; }
        public MisReservas(Cliente cliente, CanchaSinteticaContext context)
        {
            InitializeComponent();
            this.Cliente = cliente;
            this.Context = context;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MisReservas_Load(object sender, EventArgs e)
        {
            CargarReservas();
        }

        private void CargarReservas()
        {
            var controlador_cliente = new ClienteControlador(Context);
            List<Reserva> reservas = controlador_cliente.VisualizarReservas(Cliente.Documento);
            dataGridView1.DataSource = reservas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id_reserva = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

                var confirmacion = MessageBox.Show("¿Estás seguro de que deseas cancelar esta reserva?", "Confirmar Cancelación", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    bool exito = false;
                    try
                    {
                        var controlador_cliente = new ClienteControlador(Context);
                        controlador_cliente.CancelarReserva(id_reserva, Cliente.Documento);
                        exito = true;
                        
                    }
                    catch (Exception ex)
                    {
                        exito = false;
                    }

                    if (exito)
                    {
                        MessageBox.Show("Reserva cancelada con éxito.");
                        CargarReservas();
                    }
                    else
                    {
                        MessageBox.Show("Error al cancelar la reserva.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una reserva para cancelar.");
            }
        }
    }
}
