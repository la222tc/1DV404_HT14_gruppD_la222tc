using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3a
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversedString = "";
            Console.WriteLine("Mata in en text och kolla om det är ett palindrom: ");
            string inputString = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (inputString != "")
            {
                for (int i = inputString.Length - 1; i >= 0; i--)
                {
                    reversedString += inputString[i];
                }

                if (inputString == reversedString)
                {
                    Console.WriteLine("{0} är ett palindrom", inputString);
                }

                else
                {
                    Console.WriteLine("{0} är INTE ett palindrom", inputString);
                }
            }

            else
            {
                Console.WriteLine("Du matade aldrig in en text");
            }

        }
    }
}
