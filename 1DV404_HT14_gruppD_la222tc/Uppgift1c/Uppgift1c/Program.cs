using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1c
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Mata in 10 heltal: ");

           // int[] numbers = new int[10];
           // int highest;
           // int nextToHighest;

           //// System.Text.StringBuilder sb = new System.Text.StringBuilder();
           // for (int i = 0; i < numbers.Length; i++)
           // {
           //     numbers[i] = int.Parse(Console.ReadLine());
           //     //foreach (var c in test)
           //     //{
           //     //    sorted += test;
           //     //}

           // //    sb.AppendLine(test.ToString());

           //    // string test = Console.ReadLine();

           //     //foreach (var c in test)
           //     //{
                    
           //    // }
           // }

           // Array.Sort(numbers);

           // nextToHighest = numbers[numbers.Length - 2];

           // Console.Write("Det näst största talet är: {0}", nextToHighest);
           // Console.WriteLine();

           // //for (int i = 0; i < sorted.Length; i++)
           // //{
           // //    Console.WriteLine(sorted[i]);
           // //}

            
          //  Console.WriteLine(sb.ToString());

            const int ammountOfinterger = 10;
            int largestNumber = 0;
            int secondLargestNumber = 0;
            int number = 0;

            Console.WriteLine("Mata in {0} heltal: ", ammountOfinterger);
            Console.WriteLine();
            for (int i = 0; i < ammountOfinterger; i++)
            {
                Console.Write("Nummer {0}: ", i + 1);
                number = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    largestNumber = number;
                }

                else if (i == 1)
                {
                    if (number > largestNumber)
                    {
                        secondLargestNumber = largestNumber;
                        largestNumber = number;
                    }
                    else
                    {
                        secondLargestNumber = number;
                    }
                }
                else
                {
                    
                    if (number > secondLargestNumber && number < largestNumber)
                    {
                        secondLargestNumber = number;
                    }
                    
                    else if (number > largestNumber)
                    {
                        secondLargestNumber = largestNumber;
                        largestNumber = number;

                    }
                }

            }
            Console.WriteLine(secondLargestNumber);

        }
    }
}
