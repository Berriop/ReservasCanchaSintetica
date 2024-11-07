using ReservasCanchaSintetica.Modelos;

namespace ReservasCanchaSintetica
{
    public partial class PrincipalAdministrador : Form
    {
        public Administrador Administrador;
        public CanchaSinteticaContext Context { get; set; }
        public PrincipalAdministrador(Administrador administrador, CanchaSinteticaContext context)
        {
            InitializeComponent();
            this.Administrador = administrador;
            this.Context = context;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Torneos torneos = new Torneos(Context);
            torneos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionarHorarios gestionar_horarios = new GestionarHorarios(Administrador, Context);
            gestionar_horarios.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pagos pagos = new Pagos(Context);
            pagos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormInventario form_inventario = new FormInventario(Context);
            form_inventario.Show();
        }
    }
}
