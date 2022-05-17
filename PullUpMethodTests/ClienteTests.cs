using Microsoft.VisualStudio.TestTools.UnitTesting;
using PullUpMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpMethod.Tests
{
    [TestClass()]
    public class ClienteTests
    {
        [TestMethod()]
        public void ClienteTest()
        {
            Cliente cliente = new Cliente();
            DateTime date = DateTime.Now;
            cliente.DataUltimaFatura = date;

            cliente.AdicionarConta(date, 650);
            Assert.AreEqual(expected: date, cliente.DataUltimaFatura);
        }

        [TestMethod()]
        public void ClienteRegularTest()
        {
            ClienteRegular clienteRegular = new ClienteRegular();

            DateTime dataInicio = new DateTime(2022, 04, 16);
            DateTime data2 = new DateTime(2022, 05, 16);

            clienteRegular.DataUltimaFatura = dataInicio;
            clienteRegular.CriarConta(data2);

            Assert.AreEqual(expected: 3000, clienteRegular.ChargeFor(dataInicio, data2));
            Assert.AreEqual(expected: dataInicio, clienteRegular.DataUltimaFatura);

        }

        [TestMethod()]
        public void ClientePreferidoTest()
        {
            ClientePreferido clientePreferido = new ClientePreferido();

            DateTime dataInicio = new DateTime(2022, 03, 17);
            DateTime data2 = new DateTime(2022, 05, 17);

            clientePreferido.CriarConta(data2);
            clientePreferido.DataUltimaFatura = dataInicio;
            Assert.AreEqual(expected: 4880, clientePreferido.ChargeFor(dataInicio, data2));
            Assert.AreEqual(expected: dataInicio, clientePreferido.DataUltimaFatura);

        }
    }
}