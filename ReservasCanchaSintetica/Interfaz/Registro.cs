using ReservasCanchaSintetica.Servicios;

namespace ReservasCanchaSintetica
{
    public partial class Registro : Form
    {
        public CanchaSinteticaContext Context { get; set; }
        public Registro(CanchaSinteticaContext context)
        {
            InitializeComponent();
            this.Context = context;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            string documento = text_documento.Text;
            string nombre = text_nombre.Text;
            string apellidos = text_apellido.Text;
            string telefono = text_telefono.Text;
            string correo = text_correo.Text;
            string contraseña = text_contraseña.Text;
            string texto_saldo = text_saldo.Text;
            float saldo;

            if (string.IsNullOrWhiteSpace(documento) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(texto_saldo))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (float.TryParse(texto_saldo, out saldo))
            {
            }
            else
            {

                MessageBox.Show("Por favor, ingresa un número válido.");
                text_saldo.Focus();
                text_saldo.SelectAll();
            }

            var resultado = await AutenticacionServicio.RegistrarClienteAsync(documento, nombre, apellidos, telefono, correo, contraseña, saldo, Context);

            if (resultado.Exitoso)
            {
                MessageBox.Show("Registro exitoso.");
                this.Close();
            }
            else
            {
                MessageBox.Show(resultado.MensajeError);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}