using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operazioni
{
    public class Operazione : IOperazione
    {
        public double Diff(int val1, int val2)
        {
            return val1 - val2;
        }

        public double Divisione(int val1, int val2)
        {
            return val1 / val2;
        }

        public double Prodotto(int val1, int val2)
        {
            return val1 * val2;
        }

        public double Sum(int val1, int val2)
        {
            return val1 + val2;
        }
    }
}
