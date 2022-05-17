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
    public class ClienteRefactoringTests
    {
        [TestMethod()]
        public void ClienteRefactoringTeste()
        {
            Cliente cliente = new Cliente();

            DateTime data = new DateTime(2022, 05, 16);
            cliente.AdicionarConta(data, 65.00);
            cliente.DataUltimaFatura = data;

            Assert.AreEqual(expected: data, cliente.DataUltimaFatura);

        }
    }
}