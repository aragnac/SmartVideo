using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Test de connexion a la BD SQLServer \n");
            DB test = new DB("ARAGNAC", "FilmDB");
        }
    }
}
