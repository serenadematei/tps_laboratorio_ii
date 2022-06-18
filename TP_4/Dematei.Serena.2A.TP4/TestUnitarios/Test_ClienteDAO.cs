using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class Test_ClienteDAO
    {
        [TestMethod]
        public void GuardarCliente_CuandoClienteTieneUnAtributoNulo_DeberiaRetornarFalse()
        {
            ClienteDAO dao = new ClienteDAO();
            Cliente cliente = new Cliente("Juan", null, "1234567890", 12345678);

            bool expected = false;
            bool actual = dao.GuardarCliente(cliente);

            Assert.AreEqual(expected, actual);

        }
    }
}
