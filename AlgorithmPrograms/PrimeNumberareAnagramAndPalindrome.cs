using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimeNumberareAnagramAndPalindrome
    {
        public void PrimeNumber()
        {
            int count = 0;
            int ctr;
            List<int> primeNumbers = new List<int>();
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
                    Console.WriteLine($"{i} is a Prime Number");
                    Palindrome(i);
                    primeNumbers.Add(i);
                    count++;
                }
            }
            Console.WriteLine($"\nTotal Prime Numbers are {count}\n\n");

            Console.WriteLine("<==========Anagram==========>");
            bool[] visited = new bool[primeNumbers.Count];
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                if (visited[i] == true)
                {
                    continue;
                }
                for (int j = 1; j < primeNumbers.Count; j++)
                {
                    Anagram(primeNumbers[i], primeNumbers[j], visited, j);
                }
            }
        }

        private void Anagram(int num1, int num2, bool[] visited, int j)
        {
            char[] character1 = Convert.ToString(num1).ToCharArray();
            char[] character2 = Convert.ToString(num2).ToCharArray();
            Array.Sort(character1);
            Array.Sort(character2);
            string val1 = new string(character1);
            string val2 = new string(character2);

            if (val1 == val2 && num1 != num2)
            {
                visited[j] = true;

                Console.WriteLine($"{num1} and {num2} are Anagram");
            }
        }

        private void Palindrome(int num1)
        {
            int reverse = 0;
            int temp = num1;
            while (num1 != 0)
            {
                int reminder = num1 % 10;
                reverse = reverse * 10;
                reverse = reminder + reverse;
                num1 = num1 / 10;
            }
            if (temp == reverse)
            {
                Console.WriteLine($"==========> {temp} is a Palindrome");
            }
        }
    }
}