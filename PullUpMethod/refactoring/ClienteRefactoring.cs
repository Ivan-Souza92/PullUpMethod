using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpMethod.refactoring
{
    public abstract class ClienteRefactoring
    {
        public DateTime DataUltimaFatura { get; set; }
        public void AdicionarConta(DateTime date, double amount) { }

        public void CriarConta(DateTime data)
        {
            AdicionarConta(data, ChargeFor(DataUltimaFatura, data));
        }

        public abstract double ChargeFor(DateTime inicio, DateTime fim);
    }
}
