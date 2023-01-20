using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PermutationOfString
    {
        // Iterative Method
        public static void Iterative(String word, String answer)
        {
            if (word.Length == 0)
            {
                Console.WriteLine(answer + " ");
                return;
            }

            for (int i = 0; i < word.Length; i++)
            {
                char ch = word[i];
                String left_substr = word.Substring(0, i);
                String right_substr = word.Substring(i + 1);
                String rest = left_substr + right_substr;
                Iterative(rest, answer + ch);
            }
        }


        // Recursion Method
        public static void Recursion(String word, int initialIndex, int endIndex)
        {
            if (initialIndex == endIndex)
            {
                Console.WriteLine(word);
            }
            else
            {
                for (int i = initialIndex; i <= endIndex; i++)
                {
                    word = Swap(word, initialIndex, i);
                    Recursion(word, initialIndex + 1, endIndex);
                    word = Swap(word, initialIndex, i);
                }
            }
        }
        public static string Swap(String word, int pos1, int pos2)
        {
            char temp;
            char[] charArray = word.ToCharArray();
            temp = charArray[pos1];
            charArray[pos1] = charArray[pos2];
            charArray[pos2] = temp;
            string swapped = new string(charArray);
            return swapped;
        }
    }
}
