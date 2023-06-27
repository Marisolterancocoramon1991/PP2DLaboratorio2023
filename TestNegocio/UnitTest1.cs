using BibliotecaDeClases;

namespace TestNegocio
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMetodo_GanacicaTotal_DebeRtornarTodoLoGastadoPorUnCliente()
        {
            Venta venta = new Venta("carne", "roja", 1500, 3000, eMetodoPago.MercadoPago, 2, 3, "Marisol");
            Venta venta1 = new Venta("asado", "roja", 1320, 1320, eMetodoPago.MercadoPago, 1, 4, "vicente");
            Venta venta2 = new Venta("carne", "roja", 1500, 4500, eMetodoPago.MercadoPago, 3, 3, "Marisol");
            List<Venta> listaVenta;
            Cliente cliente = new Cliente(3, "Marisol", "Teran", "Buenos Aires", "corre@gmail", "2525", 60000, "2151151", eTipoDeUsuario.Cliente);
            listaVenta = new List<Venta>();
            listaVenta.Add(venta1);
            listaVenta.Add(venta);
            listaVenta.Add(venta2);
            double resultado = Negocio.GananciaTotal(listaVenta, cliente);

            Assert.AreEqual(resultado, 7500);

        }
        [TestMethod]
        public void EsLetra_AllLetters_ReturnsTrue()
        {
            // Arrange
            string texto = "abcdefghi";

            // Act
            bool result = Validaciones.EsLetra(texto);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EsLetra_ContainsNonLetter_ReturnsFalse()
        {
            // Arrange
            string texto = "abc123def";

            // Act
            bool result = Validaciones.EsLetra(texto);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EsLetra_EmptyString_ReturnsTrue()
        {
            // Arrange
            string texto = string.Empty;

            // Act
            bool result = Validaciones.EsLetra(texto);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EsNumero_ValidNumber_ReturnsTrue()
        {
            // Arrange
            string nummeroAValidar = "123";

            // Act
            bool result = Validaciones.EsNumero(nummeroAValidar);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EsNumero_InvalidNumber_ReturnsFalse()
        {
            // Arrange
            string nummeroAValidar = "abc";

            // Act
            bool result = Validaciones.EsNumero(nummeroAValidar);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EsNumero_EmptyString_ReturnsFalse()
        {
            // Arrange
            string nummeroAValidar = string.Empty;

            // Act
            bool result = Validaciones.EsNumero(nummeroAValidar);

            // Assert
            Assert.IsFalse(result);
        }


    }
}