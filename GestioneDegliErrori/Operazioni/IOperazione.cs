using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operazioni
{
    public interface IOperazione
    {
        double Sum(int val1, int val2);
        double Diff(int val1, int val2);
        double Prodotto(int val1, int val2);
        double Divisione(int val1, int val2);

    }
}
