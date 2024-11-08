using ReservasCanchaSintetica.Controladores;

namespace ReservasCanchaSintetica
{
    public partial class FormInventario : Form
    {
        public CanchaSinteticaContext Context { get; set; }
        public FormInventario(CanchaSinteticaContext context)
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
            try
            {
                int cantidad_aguas = (int)numericdown_aguas.Value;
                int cantidad_balones = (int)numericdown_balones.Value;

                var controlador_administrador = new AdministradorControlador(Context);
                controlador_administrador.AgregarElementosInventario(cantidad_balones, cantidad_aguas);

                MessageBox.Show("Inventario actualizado correctamente.");

                CargarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el inventario: {ex.Message}");
            }
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void CargarInventario()
        {
            var inventario = Context.Inventarios.SingleOrDefault();
            if (inventario != null)
            {
      
                datagrid_inventario.Rows.Clear();
      
                datagrid_inventario.Rows.Add(inventario.CantidadBalones, inventario.CantidadAguas);
            }
            else
            {
      
                MessageBox.Show("No se encontró inventario en la base de datos.");
            }

        }
    }
}
