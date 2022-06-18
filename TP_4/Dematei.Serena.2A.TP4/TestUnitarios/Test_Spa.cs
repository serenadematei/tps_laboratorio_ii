using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class Test_Spa
    {
        //[TestMethod]
        //public void CargarInformacion_CuandoLeerRecibeElArchivoCorrecto_DeberiaLlenarLaListaConVeinteClientes()
        //{
        //    string nombreArchivo = "MOCK_DATA.json";
        //    int expected = 20; 


        //    SerializadoraJson json = new SerializadoraJson();
        //    Spa.clientes = json.Leer(nombreArchivo);

        //    int actual = Spa.clientes.Count;
        //    Assert.AreEqual(expected,actual);

        //}


        [TestMethod]
        public void RemoverCliente_CuandoRecibeUnClienteExistente_DeberiaRetornarTrue()
        {
           
            Cliente clienteExistente;
            clienteExistente = Spa.clientes[1];


            bool actual = Spa.RemoverCliente(clienteExistente);
            bool expected = true;


            Assert.AreEqual(expected, actual);
          
           
        }
       
    }



}
