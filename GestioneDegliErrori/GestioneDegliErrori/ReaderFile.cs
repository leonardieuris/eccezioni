using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GestioneDegliErrori
{
    public class ReaderFile : IReaderFile
    {
        public string[] Read(string path)
        {
          return  File.ReadAllLines(path);
        }
    }
}
