using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PullUpMethod.refactoring
{
    public class ClientePreferido : ClienteRefactoring
    {
        public override double ChargeFor(DateTime inicio, DateTime fim)
        {
            return (fim - inicio).Days * 80.0;
        }
    }
}
