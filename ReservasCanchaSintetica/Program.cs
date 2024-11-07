using Microsoft.EntityFrameworkCore;
using ReservasCanchaSintetica.Modelos;
using System;

namespace ReservasCanchaSintetica
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CanchaSinteticaContext>();
            optionsBuilder.UseSqlite("Data Source = cancha_sintetica.db");

            var context = new CanchaSinteticaContext(optionsBuilder.Options);

            ApplicationConfiguration.Initialize();
            Application.Run(new Principal(context));
        }
    }
}