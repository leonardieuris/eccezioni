using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GestioneDegliErrori
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var mioFile = ReadFile();

        //    for (int i = 0; i < mioFile.Length; i++)
        //    {
        //        Console.WriteLine(mioFile[i]);
        //    }

        //    Console.ReadLine();
        //}

        //private static string[] ReadFile()
        //{
        //    try
        //    {
        //        var arrayLine = File.ReadAllLines("C:\\dati\\Fordscort.txt");
        //        return arrayLine;
        //    }
        //    catch (FileNotFoundException e)
        //    {
        //        Console.WriteLine("File non trovato");
        //        return new string[0];
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        return new string[0];
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Fine del metodo");
        //    }
        //}



        //static void Main(string[] args)
        //{

        //        int a = 10;
        //        int b = 0;
        //        Operazioni op= new Operazioni();
        //        var result = op.Divisione(a, b);
        //        Console.WriteLine($"il risultato è {result}");


        //    Console.ReadLine();

        //}


        static void Main(string[] args)
        {

            SuperReadFile myReader = new SuperReadFile();
            var myFile = Read(myReader);
            for (int i = 0; i < myFile.Length; i++)
            {
                Console.WriteLine(myFile[i]);
            }

            Console.ReadLine();
        }


        private static string[] Read(IReaderFile myClass)
        {
            var myFile = "C:\\dati\\FordEscort.txt";

          return   myClass.Read(myFile);
        }


    }
}
