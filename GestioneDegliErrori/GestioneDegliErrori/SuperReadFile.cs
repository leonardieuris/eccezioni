using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneDegliErrori
{
    public class SuperReadFile : IReaderFile
    {
        public string[] Read(string path)
        {
            List<string> mList = new List<string>();
            if (File.Exists(path))
            {
                using (var mioreader = new StreamReader(path))
                {
           
                    while (!mioreader.EndOfStream)
                    {
                        mList.Add(mioreader.ReadLine());
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("File non trovato");
            }
            return mList.ToArray();
        }
    }
}
