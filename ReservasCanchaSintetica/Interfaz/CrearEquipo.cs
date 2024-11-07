using ReservasCanchaSintetica.Controladores;
namespace ReservasCanchaSintetica
{
    public partial class CrearEquipo : Form
    {
        public CanchaSinteticaContext Context { get; set; }
        public CrearEquipo(CanchaSinteticaContext context)
        {
            InitializeComponent();
            this.Context = context;
        }

        private void CrearEquipo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textbox_nombre.Text;
                int cantidad_jugadores = int.Parse(textbox_cantidad_jugadores.Text);

                if (int.TryParse(textbox_cantidad_jugadores.Text, out cantidad_jugadores))
                {
                    var controlador_equipo = new EquipoControlador(Context);
                    controlador_equipo.AgregarEquipo(nombre, cantidad_jugadores);

                    MessageBox.Show("Equipo creado con éxito.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido de jugadores.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            textbox_nombre.Clear();
            textbox_cantidad_jugadores.Clear();
        }
    }
}
