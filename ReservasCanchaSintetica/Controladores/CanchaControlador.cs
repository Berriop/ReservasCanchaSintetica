using ReservasCanchaSintetica.Modelos;

namespace ReservasCanchaSintetica.Controladores
{
    internal class CanchaControlador
    {
        private readonly CanchaSinteticaContext BD;

        public CanchaControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgregarCancha(float precio)
        {
            var cancha = new Cancha { Precio = precio};

            if(!cancha.ValidarCancha(out string mensaje_error))
            {
                throw new Exception(mensaje_error);
            }

            BD.Canchas.Add(cancha);
            BD.SaveChanges();
        }
    }
}
