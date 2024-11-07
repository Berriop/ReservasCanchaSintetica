namespace ReservasCanchaSintetica.Servicios
{
    internal class ResultadoInicioSesion
    {
        public bool Exitoso { get; set; }
        public string TipoUsuario { get; set; }
        public object Usuario { get; set; }
        public string MensajeError { get; set; }
    }
}
