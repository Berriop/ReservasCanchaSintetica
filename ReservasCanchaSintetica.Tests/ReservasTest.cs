
namespace ReservasCanchaSintetica.Modelos
{
    [TestClass]
    public class ReservaCanchaSinteticaTests
    {
        [TestClass]
        public class AdministradorTests
        {
            [TestMethod]
            public void ValidarAdministrador_ValidData_ReturnsTrue()
            {
                var admin = new Administrador { Documento = "1234567890" };
                Assert.IsTrue(admin.ValidarAdministrador(out _));
            }

            [TestMethod]
            public void ValidarAdministrador_InvalidDocumento_ReturnsFalse()
            {
                var admin = new Administrador { Documento = "1234" };
                Assert.IsFalse(admin.ValidarAdministrador(out string mensaje));
                Assert.AreEqual("El documento del administrador debe tener al menos 10 caracteres.", mensaje);
            }

            [TestMethod]
            public void ValidarAdministrador_EmptyDocumento_ReturnsFalse()
            {
                var admin = new Administrador { Documento = "" };
                Assert.IsFalse(admin.ValidarAdministrador(out string mensaje));
                Assert.AreEqual("El documento del administrador debe tener al menos 10 caracteres.", mensaje);
            }

            [TestMethod]
            public void ValidarAdministrador_NullDocumento_ReturnsFalse()
            {
                var admin = new Administrador { Documento = null };
                Assert.IsFalse(admin.ValidarAdministrador(out string mensaje));
                Assert.AreEqual("El documento del administrador debe tener al menos 10 caracteres.", mensaje);
            }

            [TestMethod]
            public void ValidarAdministrador_ValidNombre_ReturnsTrue()
            {
                var admin = new Administrador { Nombre = "Carlos" };
                Assert.IsTrue(admin.ValidarAdministrador(out _));
            }
        }

        [TestClass]
        public class CanchaTests
        {
            [TestMethod]
            public void ValidarCancha_ValidData_ReturnsTrue()
            {
                var cancha = new Cancha { Precio = 50.0f };
                Assert.IsTrue(cancha.ValidarCancha(out _));
            }

            [TestMethod]
            public void ValidarCancha_NegativePrecioPorHora_ReturnsFalse()
            {
                var cancha = new Cancha { Precio = -10.0f };
                Assert.IsFalse(cancha.ValidarCancha(out string mensaje));
                Assert.AreEqual("El precio por hora no puede ser negativo.", mensaje);
            }
        }

        [TestClass]
        public class ClienteTests
        {
            [TestMethod]
            public void ValidarCliente_ValidData_ReturnsTrue()
            {
                var cliente = new Cliente { Documento = "0987654321" };
                Assert.IsTrue(cliente.ValidarCliente(out _));
            }

            [TestMethod]
            public void ValidarCliente_InvalidDocumento_ReturnsFalse()
            {
                var cliente = new Cliente { Documento = "123" };
                Assert.IsFalse(cliente.ValidarCliente(out string mensaje));
                Assert.AreEqual("El documento del cliente debe tener al menos 10 caracteres.", mensaje);
            }

            [TestMethod]
            public void ValidarCliente_EmptyDocumento_ReturnsFalse()
            {
                var cliente = new Cliente { Documento = "" };
                Assert.IsFalse(cliente.ValidarCliente(out string mensaje));
                Assert.AreEqual("El documento del cliente debe tener al menos 10 caracteres.", mensaje);
            }

            [TestMethod]
            public void ValidarCliente_NullDocumento_ReturnsFalse()
            {
                var cliente = new Cliente { Documento = null };
                Assert.IsFalse(cliente.ValidarCliente(out string mensaje));
                Assert.AreEqual("El documento del cliente debe tener al menos 10 caracteres.", mensaje);
            }

            [TestMethod]
            public void ValidarCliente_ValidNombre_ReturnsTrue()
            {
                var cliente = new Cliente { Nombre = "Juan" };
                Assert.IsTrue(cliente.ValidarCliente(out _));
            }
        }

        [TestClass]
        public class ReservaTests
        {
            [TestMethod]
            public void ValidarReserva_ValidData_ReturnsTrue()
            {
                var reserva = new Reserva
                {
                    Fecha = DateTime.Now.AddDays(1),
                    CantidadHoras = 2,
                    CantidadBalones = 1,
                    CantidadAguas = 1,
                    PrecioTotal = 100.0f
                };

                Assert.IsTrue(reserva.ValidarReserva(out _));
            }

            [TestMethod]
            public void ValidarReserva_PastDate_ReturnsFalse()
            {
                var reserva = new Reserva { Fecha = DateTime.Now.AddDays(-1) };
                Assert.IsFalse(reserva.ValidarReserva(out string mensaje));
                Assert.AreEqual("La fecha de reserva debe ser futura.", mensaje);
            }

            [TestMethod]
            public void ValidarReserva_InvalidCantidadHoras_ReturnsFalse()
            {
                var reserva = new Reserva { CantidadHoras = 5 };
                Assert.IsFalse(reserva.ValidarReserva(out string mensaje));
                Assert.AreEqual("La cantidad de horas debe estar entre 1 y 4.", mensaje);
            }

            [TestMethod]
            public void ValidarReserva_NegativeCantidadBalones_ReturnsFalse()
            {
                var reserva = new Reserva { CantidadBalones = -1 };
                Assert.IsFalse(reserva.ValidarReserva(out string mensaje));
                Assert.AreEqual("Las cantidades de balones y aguas no pueden ser negativas.", mensaje);
            }

            [TestMethod]
            public void ValidarReserva_NegativeCantidadAguas_ReturnsFalse()
            {
                var reserva = new Reserva { CantidadAguas = -1 };
                Assert.IsFalse(reserva.ValidarReserva(out string mensaje));
                Assert.AreEqual("Las cantidades de balones y aguas no pueden ser negativas.", mensaje);
            }

            [TestMethod]
            public void ValidarReserva_NegativePrecioTotal_ReturnsFalse()
            {
                var reserva = new Reserva { PrecioTotal = -10.0f };
                Assert.IsFalse(reserva.ValidarReserva(out string mensaje));
                Assert.AreEqual("El precio total no puede ser negativo.", mensaje);
            }
        }

        [TestClass]
        public class EquipoTests
        {
            [TestMethod]
            public void ValidarEquipo_ValidData_ReturnsTrue()
            {
                var equipo = new Equipo
                {
                    Nombre = "Tigres",
                    CantidadJugadores = 11
                };

                Assert.IsTrue(equipo.ValidarEquipo(out _));
            }

            [TestMethod]
            public void ValidarEquipo_ShortNombre_ReturnsFalse()
            {
                var equipo = new Equipo { Nombre = "AB" };
                Assert.IsFalse(equipo.ValidarEquipo(out string mensaje));
                Assert.AreEqual("El nombre del equipo debe tener al menos 3 caracteres.", mensaje);
            }

            [TestMethod]
            public void ValidarEquipo_EmptyNombre_ReturnsFalse()
            {
                var equipo = new Equipo { Nombre = "" };
                Assert.IsFalse(equipo.ValidarEquipo(out string mensaje));
                Assert.AreEqual("El nombre del equipo debe tener al menos 3 caracteres.", mensaje);
            }

            [TestMethod]
            public void ValidarEquipo_TooFewJugadores_ReturnsFalse()
            {
                var equipo = new Equipo { CantidadJugadores = 3 };
                Assert.IsFalse(equipo.ValidarEquipo(out string mensaje));
                Assert.AreEqual("El equipo debe tener entre 5 y 15 jugadores.", mensaje);
            }

            [TestMethod]
            public void ValidarEquipo_TooManyJugadores_ReturnsFalse()
            {
                var equipo = new Equipo { CantidadJugadores = 16 };
                Assert.IsFalse(equipo.ValidarEquipo(out string mensaje));
                Assert.AreEqual("El equipo debe tener entre 5 y 15 jugadores.", mensaje);
            }
        }

    }
}