using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneDegliErrori
{
     public class EccezioneDivisionePerZero : Exception
    {
        public EccezioneDivisionePerZero(string messaggio):base(messaggio)
        {
            
        }
    }
}
