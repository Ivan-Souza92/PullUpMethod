using Microsoft.VisualStudio.TestTools.UnitTesting;
using PullUpMethod.refactoring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpMethod.refactoring.Tests
{
    [TestClass()]
    public class ClientePreferidoTests
    {
        [TestMethod()]
        public void ChargeForTest()
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