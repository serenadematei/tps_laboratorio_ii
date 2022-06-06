using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class Test_Agenda
    {
        [TestMethod]
        public void OrdenarTurnosPorFecha_CuandoRecibeDosFechasIguales_DeberiaRetornarCero()
        {
            Cliente auxCliente = new Cliente("Juan", "Perez", "1234567891", 12345698);
            Masaje auxMasaje = new Masaje(ETipoMasaje.PiedrasCalientes, 30);
            DateTime fecha1 = new DateTime(02/02/2023);
            DateTime fecha2 = new DateTime(02/02/2023);

            Turno t1 = new Turno(fecha1,auxCliente,auxMasaje);
            Turno t2 = new Turno(fecha2, auxCliente, auxMasaje);

            int expected = 0;
            int actual = Agenda.OrdenarPorFechaAscendente(t1, t2);

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void AgendarNuevoTurno_CuandoRecibeUnTurnoNoNulo_DeberiaRetornarTrue()
        {
            Cliente auxCliente = new Cliente("Juan", "Perez", "1234567891", 12345698);
            Masaje auxMasaje = new Masaje(ETipoMasaje.PiedrasCalientes, 30);
            DateTime fecha1 = new DateTime(02 / 02 / 2023);
            Turno t1 = new Turno(fecha1, auxCliente, auxMasaje);
          

            bool expected = true;
            bool actual = Agenda.AgendarNuevoTurno(t1);



            Assert.AreEqual(expected, actual);
        }

    }
}
