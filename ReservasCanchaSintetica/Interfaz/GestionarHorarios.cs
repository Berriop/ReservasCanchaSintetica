using ReservasCanchaSintetica.Controladores;
using ReservasCanchaSintetica.Modelos;

namespace ReservasCanchaSintetica
{
    public partial class GestionarHorarios : Form
    {
        public Administrador Administrador;
        public CanchaSinteticaContext Context { get; set; }
        public GestionarHorarios(Administrador administrador, CanchaSinteticaContext context)
        {
            InitializeComponent();
            this.Administrador = administrador;
            this.Context = context;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = datetime_fecha.Value;

                var controlador_administrador = new AdministradorControlador(Context);
                controlador_administrador.DesbloquearDia(fecha);

                MessageBox.Show("Fecha activada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = datetime_fecha.Value;

                var controlador_administrador = new AdministradorControlador(Context);
                controlador_administrador.BloquearDia(fecha);

                MessageBox.Show("Fecha bloqueada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error: {ex.Message}");
            }
        }
    }
}
