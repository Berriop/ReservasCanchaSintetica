namespace ReservasCanchaSintetica
{
    public partial class Pagos : Form
    {
        public CanchaSinteticaContext Context { get; set; }
        public Pagos(CanchaSinteticaContext context)
        {
            InitializeComponent();
            this.Context = context;
            datetime_mes.Format = DateTimePickerFormat.Custom;
            datetime_mes.CustomFormat = "MM/yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            int mes_seleccionado = datetime_mes.Value.Month;
            int año_seleccionado = datetime_mes.Value.Year;

            try
            {
                var reservas_mes = Context.Reservas.Where(r => r.Fecha.Month == mes_seleccionado && r.Fecha.Year == año_seleccionado).ToList();
                float ganancias_totales = reservas_mes.Sum(r => r.PrecioTotal);
                int cantidad_reservas = reservas_mes.Count;
                float promedio_precio = cantidad_reservas > 0 ? ganancias_totales / cantidad_reservas : 0;
                label_pago.Text = $"{ganancias_totales}";
                label_cantidad_reservas.Text = $"{cantidad_reservas}";
                label_promedio.Text = $"{promedio_precio}";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular estadísticas: {ex.Message}");
            }
        }
    }
}
