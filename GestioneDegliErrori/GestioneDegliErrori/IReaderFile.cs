using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneDegliErrori
{
    public interface IReaderFile
    {
        string[] Read(string path);
    }
}
