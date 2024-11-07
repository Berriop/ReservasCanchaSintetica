using ReservasCanchaSintetica.Modelos;

namespace ReservasCanchaSintetica
{
    public partial class AgregarEquipo : Form
    {
        public CanchaSinteticaContext Context { get; set; }
        public AgregarEquipo(CanchaSinteticaContext context)
        {
            InitializeComponent();
            this.Context = context;
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearEquipo crear_equipo = new CrearEquipo(Context);
            crear_equipo.ShowDialog();
        }

        private void AgregarEquipo_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            using (var context = Context)
            {
                combobox_torneo.DataSource = context.Torneos.ToList();
                combobox_torneo.DisplayMember = "Nombre";
                combobox_torneo.ValueMember = "Id";

                combobox_equipo.DataSource = context.Equipos.ToList();
                combobox_equipo.DisplayMember = "Nombre";
                combobox_equipo.ValueMember = "Id";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int torneo_id = (int)combobox_torneo.SelectedValue;
                int equipo_id = (int)combobox_equipo.SelectedValue;

                TorneoXEquipo nueva_relacion = new TorneoXEquipo { IdTorneo = torneo_id, IdEquipo = equipo_id };

                using (var context = Context)
                {
                    context.TorneoXEquipos.Add(nueva_relacion);
                    context.SaveChanges();
                }

                MessageBox.Show("El equipo ha sido agregado al torneo con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
