using Cancha_Sintetica.Modelos;

namespace Cancha_Sintetica.Controladores
{
    internal class CanchaControlador
    {
        private readonly CanchaSinteticaContext BD;

        public CanchaControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgregarCancha(string id, float precio)
        {
            var cancha = new Cancha { Id = id, Precio = precio};

            if(!cancha.ValidarCancha(out string mensaje_error))
            {
                throw new Exception(mensaje_error);
            }

            BD.Add(cancha);
            BD.SaveChanges();
        }
    }
}
