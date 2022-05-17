using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpMethod
{
    public class Cliente
    {
        public DateTime DataUltimaFatura { get; set; }
        public Cliente() { }
        public void AdicionarConta(DateTime date, double amount) { }
    }

    public class ClienteRegular : Cliente
    {
        public ClienteRegular() { }
        public void CriarConta(DateTime data)
        {
            AdicionarConta(data, ChargeFor(DataUltimaFatura, data));
        }

        public double ChargeFor(DateTime inicio, DateTime fim)
        {
            return (fim - inicio).Days * 100;
        }
    }

    public class ClientePreferido : Cliente
    {
        public void CriarConta(DateTime data)
        {
            AdicionarConta(data, ChargeFor(DataUltimaFatura, data));
        }
        public double ChargeFor(DateTime inicio, DateTime fim)
        {
            return (fim - inicio).Days * 80.0;
        }
    }
}
