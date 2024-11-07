using ReservasCanchaSintetica.Modelos;

namespace ReservasCanchaSintetica
{
    public partial class PrincipalCliente : Form
    {
        public Cliente Cliente { get; set; }
        public CanchaSinteticaContext Context { get; set; }
        public PrincipalCliente(Cliente cliente, CanchaSinteticaContext context)
        {
            InitializeComponent();
            this.Cliente = cliente;
            this.Context = context;
        }

        private void PrincipalCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RealizarReserva reserva = new RealizarReserva(Cliente, Context);
            reserva.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MisReservas mis_reservas = new MisReservas(Cliente, Context);
            mis_reservas.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
