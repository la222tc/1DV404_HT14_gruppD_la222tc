using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in en textrad: ");

            string test = Console.ReadLine();

            int counta = test.Count(x => x == 'a');
            int countA = test.Count(x => x == 'A');

            Console.Write("Antal a: {0}\n", counta);
            Console.Write("Antal A: {0}", countA);
            Console.WriteLine();
        }
    }
}
