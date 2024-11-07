using ReservasCanchaSintetica.Modelos;

namespace ReservasCanchaSintetica
{
    public partial class RealizarReserva : Form
    {
        public Cliente Cliente { get; set; }
        public CanchaSinteticaContext Context { get; set; }

        public RealizarReserva(Cliente cliente, CanchaSinteticaContext context)
        {
            InitializeComponent();
            this.Cliente = cliente;
            this.Context = context;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (combobox_cancha.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una cancha.");
                return;
            }
            string cancha_seleccionada = combobox_cancha.SelectedItem.ToString();

            DateTime fecha_reserva = datetimepicker_fecha.Value;
            if (fecha_reserva == null)
            {
                MessageBox.Show("Por favor, seleccione una fecha para la reserva.");
                return;
            }

            if (combobox_hora.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una hora de inicio.");
                return;
            }
            string hora_inicio = combobox_hora.SelectedItem.ToString();

            if (combo_cantidad_horas.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione la cantidad de horas.");
                return;
            }
            int cantidad_horas = 0;
            if (!int.TryParse(combo_cantidad_horas.SelectedItem.ToString(), out cantidad_horas))
            {
                MessageBox.Show("La cantidad de horas seleccionada no es válida.");
                return;
            }


            ConfirmarReserva confirmar_reserva = new ConfirmarReserva(Cliente, cancha_seleccionada, fecha_reserva, hora_inicio, cantidad_horas, Context);
            confirmar_reserva.ShowDialog();
            this.Close();
        }

        private void CargarCanchas()
        {
            var canchas = Context.Canchas.ToList();

            combobox_cancha.Items.Clear();

            foreach (var cancha in canchas)
            {
                combobox_cancha.Items.Add(cancha.Id);
            }
        }
        private void CargarHoras()
        {
            combobox_hora.Items.Clear();

            for (int i = 13; i <= 22; i++)
            {
                string hora = i <= 12 ? $"{i}:00 AM" : $"{i - 12}:00 PM";
                combobox_hora.Items.Add(hora); 
            }
        }
        private void CargarCantidadHoras()
        {
            combo_cantidad_horas.Items.Clear();

            for (int i = 1; i <= 4; i++)
            {
                combo_cantidad_horas.Items.Add(i);
            }
        }


        private void RealizarReserva_Load(object sender, EventArgs e)
        {
            CargarCanchas();
            CargarHoras();
            CargarCantidadHoras();
        }

    }
}
