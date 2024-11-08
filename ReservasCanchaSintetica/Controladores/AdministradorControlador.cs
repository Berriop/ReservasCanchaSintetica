using ReservasCanchaSintetica.Modelos;

namespace ReservasCanchaSintetica.Controladores
{
    public class AdministradorControlador
    {
        public CanchaSinteticaContext BD;

        public AdministradorControlador(CanchaSinteticaContext bd)
        {
            BD = bd;
        }

        public void AgreagarAdministrador(string documento, string nombre, string apellidos, string correo, string contraseña)
        {
            var administrador = new Administrador { Documento = documento, Nombre = nombre, Apellidos = apellidos, Correo = correo, Contraseña = contraseña };

            if (administrador.ValidarAdministrador(out string mensaje_error))
            {
                throw new Exception(mensaje_error);
            }

            BD.Administradores.Add(administrador);
            BD.SaveChanges();
        }

        public void AgregarEquipo(string id, string nombre, int cantidad_jugadores)
        {
            var controlador_equipo = new EquipoControlador(BD);
            controlador_equipo.AgregarEquipo(nombre, cantidad_jugadores);
        }

        public void CrearTorneo(string id, string nombre, DateTime fecha_iniico, DateTime fecha_final, float valor_inscripcion, float premio)
        {
            var controlador_torneo = new TorneoControlador(BD);
            controlador_torneo.AgregarTorneo(nombre, fecha_iniico, fecha_final, valor_inscripcion, premio);
        }

        public void RealizarReservaTorneo(string id, DateTime fecha, int cantidad_horas, int cantidad_balones, int cantidad_aguas, string documento_administrador, string id_torneo, int id_cancha)
        {
            var controlador_reserva = new ReservaTorneoControlador(BD);
            controlador_reserva.AgregarReservaTorneo(fecha, cantidad_horas, cantidad_balones, cantidad_aguas, documento_administrador, id_torneo, id_cancha);
        }

        public void AgregarElementosInventario(int cantidad_balones, int cantidad_aguas)
        {
            var inventario = BD.Inventarios.SingleOrDefault();

            if (inventario == null)
            {
                MessageBox.Show("El inventario no existe en la base de datos.");
                return;
            }

            if (cantidad_balones < 0 || cantidad_aguas < 0)
            {
                MessageBox.Show("Las cantidades no pueden ser negativas.");
                return;
            }

            inventario.CantidadBalones += cantidad_balones;
            inventario.CantidadAguas += cantidad_aguas;
            BD.SaveChanges();
        }

        public void BloquearDia(DateTime fecha)
        {
            var dia_a_bloquear = new DiaBloqueado { Fecha = fecha };

            var dia = BD.DiasBloqueados.FirstOrDefault(d => d.Fecha.Date == fecha.Date);
            if (dia != null)
            {
                MessageBox.Show("El día ya está bloqueado para reservas.");
                return;
            }

            BD.Add(dia_a_bloquear);
            BD.SaveChanges();
        }

        public void DesbloquearDia(DateTime fecha)
        {
            var dia_bloqueado = BD.DiasBloqueados.FirstOrDefault(d => d.Fecha.Date == fecha.Date);
            if (dia_bloqueado == null)
            {
                MessageBox.Show("No se encontro un dia bloqueado para la fecha especificada");
                return;
            }

            BD.DiasBloqueados.Remove(dia_bloqueado);
            BD.SaveChanges();
        }

    }
} 
 