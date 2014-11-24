using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3b
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Fraction fraction1 = new Fraction(4, 2);
                Fraction fraction2 = new Fraction(-20, 10);
                Fraction fraction3 = new Fraction(20, 10);

                Console.WriteLine("Testar resultatet från fraction1");
                Console.WriteLine(fraction1.ToString());
                Console.WriteLine("------------------------------");
                Console.WriteLine();

                Console.WriteLine("Testar om talet är negativt från fraction2");
                Console.WriteLine(fraction2.isNegative());
                Console.WriteLine("------------------------------");
                Console.WriteLine();

                Console.WriteLine("Jämför två Fraction-instanser och ser om de representerar samma bråktal");
                Console.WriteLine(fraction1.isEqualTo(fraction1, fraction2));
                Console.WriteLine("------------------------------");
                Console.WriteLine();

                Console.WriteLine("Adderar 2 bråktal till ett bråktal");
                Console.WriteLine(fraction1.add(fraction1, fraction3));
                Console.WriteLine("------------------------------");
                Console.WriteLine();

                Console.WriteLine("Multiplicerar 2 bråktal till ett bråktal");
                Console.WriteLine(fraction1.multiply(fraction1, fraction3));
                Console.WriteLine("------------------------------");
                Console.WriteLine();



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
