using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservasCanchaSintetica.Modelos
{
    public class ReservaTorneo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadHoras { get; set; }
        public int CantidadBalones { get; set; }
        public int CantidadAguas { get; set; }
        [ForeignKey(nameof(DocumentoAdministrador))]
        public string DocumentoAdministrador { get; set; }
        public Administrador Administrador { get; set; }
        [ForeignKey(nameof(IdTorneo))]
        public string IdTorneo { get; set; }
        public Torneo Torneo { get; set; }
        [ForeignKey(nameof(IdCancha))]
        public int IdCancha { get; set; }
        public Cancha Cancha { get; set; }
        public ICollection<CanchaXReservaTorneo> CanchaXReservaTorneos { get; set; }

        public bool ValidarReserva(out string mensaje_error)
        {
            mensaje_error = "";

            if (Fecha < DateTime.Now)
            {
                mensaje_error = "La fecha de reserva debe ser futura.";
                return false;
            }
            if (CantidadHoras < 1 || CantidadHoras > 4)
            {
                mensaje_error = "La cantidad de horas debe estar entre 1 y 4.";
                return false;
            }
            if (CantidadBalones < 0 || CantidadAguas < 0)
            {
                mensaje_error = "Las cantidades de balones y aguas no pueden ser negativas.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(DocumentoAdministrador))
            {
                mensaje_error = "La cancha debe tener un Documento del Administrador asociado.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(IdTorneo))
            {
                mensaje_error = "La cancha debe tener un ID de torneo asociado.";
                return false;
            }

            return true;
        }
    }
}
