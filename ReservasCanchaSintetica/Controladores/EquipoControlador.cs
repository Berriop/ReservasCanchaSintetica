using ReservasCanchaSintetica.Modelos;

namespace ReservasCanchaSintetica.Controladores
{
    public class EquipoControlador
    {
        public CanchaSinteticaContext BD;

        public EquipoControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgregarEquipo(string nombre, int cantidad_jugadores)
        {
            var equipo = new Equipo {Nombre = nombre, CantidadJugadores = cantidad_jugadores };

            if(!equipo.ValidarEquipo(out string mensaje_error))
            {
                MessageBox.Show(mensaje_error);
                return;
            }

            ValidarEquiposNoRepetidos();

            BD.Equipos.Add(equipo);
            BD.SaveChanges();
        }

        private void ValidarEquiposNoRepetidos()
        {
            var equipos_inscritos = new HashSet<string>();

            foreach (var equipo in BD.Equipos)
            {
                if (!equipos_inscritos.Add(equipo.Nombre))
                {
                    MessageBox.Show($"El equipo '{equipo.Nombre}' ya está inscrito.");
                    return;
                }
            }
        }
    }
}
