using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in ett heltal:");
            string test = Console.ReadLine();
            int odd = 0;
            int even = 0;
            int zero = 0;

            foreach (char c in test)
            {
                if (c == '0')
                {
                    zero++;
                }

                if (c % 2 == 0 && c != '0')
                {
                    even++;
                }

                else if (c % 2 != 0 && c != '0')
                {
                    odd++;
                }
            }

            Console.WriteLine("Nollor: {0}", zero);
            Console.WriteLine("Udda: {0}", odd);
            Console.WriteLine("Jämna: {0}", even);
          
        }
    }
}
