using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BubbleSortMethod
    {
        public void Sort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int index = 0; index < n - i - 1; index++)
                {
                    if (array[index] > array[index + 1])
                    {
                        int temp = array[index];
                        array[index] = array[index + 1];
                        array[index + 1] = temp;
                    }
                }
            }
        }

        public void Display(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
                Console.Write(array[i] + "  ");
        }
    }
}
