using ReservasCanchaSintetica.Controladores;

namespace ReservasCanchaSintetica
{
    public partial class CrearTorneo : Form
    {
        public CanchaSinteticaContext Context { get; set; }
        public CrearTorneo(CanchaSinteticaContext context)
        {
            InitializeComponent();
            this.Context = context;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha_inicio = datetime_inicio.Value;
                DateTime fecha_final = datetime_final.Value;
                int cantidad_equipos = int.Parse(textbox_cantidad_equipos.Text);
                float valor_inscripcion = float.Parse(textbox_valor_inscripcion.Text);
                float premio = float.Parse(textbox_premio.Text);
                string nombre = textbox_nombre.Text;

                if (int.TryParse(textbox_cantidad_equipos.Text, out cantidad_equipos) && float.TryParse(textbox_valor_inscripcion.Text, out valor_inscripcion) && float.TryParse(textbox_premio.Text, out premio))
                {
                    if (fecha_final < fecha_inicio)
                    {
                        MessageBox.Show("La fecha final no puede ser anterior a la fecha de inicio.");
                        return;
                    }

                    var controlador_torneo = new TorneoControlador(Context);
                    controlador_torneo.AgregarTorneo(nombre, fecha_inicio, fecha_final, valor_inscripcion, premio);
                    MessageBox.Show("Torneo creado con éxito.");
                    LimpiarCampos();

                }
                else
                {
                    MessageBox.Show("Por favor, ingrese valores válidos.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            datetime_inicio.Value = DateTime.Now;
            datetime_final.Value = DateTime.Now;
            textbox_cantidad_equipos.Clear();
            textbox_valor_inscripcion.Clear();
            textbox_premio.Clear();
            textbox_nombre.Clear();
        }
    }
}
