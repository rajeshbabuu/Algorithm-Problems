using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class MergeSortMethod
    {
        // Function that Merges two subarrays of []array. First subarray is array[left..mid]. Second subarray is array[mid+1..right]
        public void Merge(int[] array, int left, int mid, int right)
        {
            // Find sizes of two subarrays to be merged
            int sizeOfArray1 = mid - left + 1;
            int sizeOfArray2 = right - mid;

            // Create temp arrays
            int[] tempLeft = new int[sizeOfArray1];
            int[] tempRight = new int[sizeOfArray2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < sizeOfArray1; ++i)
                tempLeft[i] = array[left + i];
            for (j = 0; j < sizeOfArray2; ++j)
                tempRight[j] = array[mid + 1 + j];

            // Merge the temp arrays
            // Initial indexes of first and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged subarray array
            int k = left;
            while (i < sizeOfArray1 && j < sizeOfArray2)
            {
                if (tempLeft[i] <= tempRight[j])
                {
                    array[k] = tempLeft[i];
                    i++;
                }
                else
                {
                    array[k] = tempRight[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements of tempLeft[] if any
            while (i < sizeOfArray1)
            {
                array[k] = tempLeft[i];
                i++;
                k++;
            }

            // Copy remaining elements of tempRight[] if any
            while (j < sizeOfArray2)
            {
                array[k] = tempRight[j];
                j++;
                k++;
            }
        }

        // Function that Sorts arr[l..r] using Merge()
        public void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int mid = left + (right - left) / 2;

                // Sort first and second halves
                Sort(array, left, mid);
                Sort(array, mid + 1, right);

                // Merge the sorted halves
                Merge(array, left, mid, right);
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