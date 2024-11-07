using ReservasCanchaSintetica.Modelos;
using ReservasCanchaSintetica.Servicios;

namespace ReservasCanchaSintetica
{
    public partial class Principal : Form
    {
        public CanchaSinteticaContext Context { get; set; }

        public Principal(CanchaSinteticaContext context)
        {
            InitializeComponent();
            this.Context = context;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string documento = text_usuario.Text;
            string contraseña = text_contraseña.Text;

            var resultado = await AutenticacionServicio.IniciarSesionAsync(documento, contraseña, Context);

            if (resultado.Exitoso)
            {
                if (resultado.TipoUsuario == "Administrador")
                {
                    PrincipalAdministrador administrador = new PrincipalAdministrador((Administrador)resultado.Usuario, Context);
                    administrador.Show();
                }
                else if (resultado.TipoUsuario == "Cliente")
                {
                    PrincipalCliente cliente = new PrincipalCliente((Cliente)resultado.Usuario, Context);
                    cliente.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show(resultado.MensajeError);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(Context);
            registro.ShowDialog();
        }
    }
}

