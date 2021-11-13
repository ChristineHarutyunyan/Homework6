using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            string path = @"data.csv";

           

            Repository rep = new Repository(path);
            rep.Load();
            rep.PrintDbToConsole();


            Console.ReadKey();
        }
    }
}
