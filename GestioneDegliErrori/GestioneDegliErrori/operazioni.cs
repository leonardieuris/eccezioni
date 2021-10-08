using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneDegliErrori
{
    public class Operazioni
    {
        public double Divisione(int a, int b)
        {
            if(b==0)
                throw new EccezioneDivisionePerZero("Divisione per zero impossibile");
            return a / b;
        }
    }
}
