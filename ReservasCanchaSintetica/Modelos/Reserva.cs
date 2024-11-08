﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservasCanchaSintetica.Modelos
{
    public class Reserva
    {
        [Key]

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadHoras { get; set; }
        public int CantidadBalones { get; set; }
        public int CantidadAguas { get; set; }
        public float PrecioTotal { get; set; }
        [ForeignKey(nameof(DocumentoCliente))]
        public string DocumentoCliente { get; set; }

        [ForeignKey(nameof(IdCancha))]
        public int IdCancha { get; set; }


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
            if (PrecioTotal < 0)
            {
                mensaje_error = "El precio total no puede ser negativo.";
                return false;
            }

            return true;
        }
    }
}
