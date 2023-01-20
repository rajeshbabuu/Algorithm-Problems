using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{

    public class InsertionSortMethod
    {
        public void Sort(IComparable[] array)
        {
            int index;

            for (int i = 1; i < array.Length; i++)
            {
                IComparable word = array[i];
                index = i - 1;
                while ((index >= 0) && (array[index].CompareTo(word) > 0))
                {
                    array[index + 1] = array[index];
                    index--;
                }
                array[index + 1] = word;
            }
        }

        public void Display(IComparable[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
                Console.Write(array[i] + "  ");
        }
    }
}
