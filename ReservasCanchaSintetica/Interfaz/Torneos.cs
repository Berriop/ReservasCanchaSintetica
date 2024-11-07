
namespace ReservasCanchaSintetica
{
    public partial class Torneos : Form
    {
        public CanchaSinteticaContext Context { get; set; }
        public Torneos(CanchaSinteticaContext context)
        {
            InitializeComponent();
            this.Context = context;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CrearTorneo crear_torneo = new CrearTorneo(Context);
            crear_torneo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarEquipo agregar_equipo = new AgregarEquipo(Context);
            agregar_equipo.ShowDialog();
        }
    }
}
