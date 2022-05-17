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
    public class ClienteRegularTests
    {
        [TestMethod()]
        public void ChargeForTest()
        {
            ClienteRegular clienteRegular = new ClienteRegular();

            DateTime dataInicio = new DateTime(2022, 04, 16);
            DateTime data2 = new DateTime(2022, 05, 16);

            clienteRegular.DataUltimaFatura = dataInicio;
            clienteRegular.CriarConta(data2);

            Assert.AreEqual(expected: 3000, clienteRegular.ChargeFor(dataInicio, data2));
            Assert.AreEqual(expected: dataInicio, clienteRegular.DataUltimaFatura);
        }
    }
}