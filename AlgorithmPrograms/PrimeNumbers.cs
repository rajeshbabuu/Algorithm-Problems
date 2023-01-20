using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimeNumbers
    {
        public void PrimeNumber()
        {
            int count = 0;
            int ctr;
            Console.Write("\nEnter initial value: ");
            int initialNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end value: ");
            int endNum = Convert.ToInt32(Console.ReadLine());

            for (int i = initialNum; i <= endNum; i++)
            {
                ctr = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && i != 1)
                {
                    Console.WriteLine($"{i} is a Prime Numbers");
                    count++;
                }
            }
            Console.WriteLine($"\nTotal Prime Numbers are {count}");
        }
    }
}