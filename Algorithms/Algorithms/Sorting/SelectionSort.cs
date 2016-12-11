using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    
    /*  
        Selection Sort
        The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) from unsorted part and putting it at the beginning. The algorithm maintains two subarrays in a given array.
        1) The subarray which is already sorted.
        2) Remaining subarray which is unsorted.

        In every iteration of selection sort, the minimum element (considering ascending order) from the unsorted subarray is picked and moved to the sorted subarray.
        Following example explains the above steps:
        arr[] = 64 25 12 22 11

        // Find the minimum element in arr[0...4]
        // and place it at beginning
        11 25 12 22 64

        // Find the minimum element in arr[1...4]
        // and place it at beginning of arr[1...4]
        11 12 25 22 64

        // Find the minimum element in arr[2...4]
        // and place it at beginning of arr[2...4]
        11 12 22 25 64

        // Find the minimum element in arr[3...4]
        // and place it at beginning of arr[3...4]
        11 12 22 25 64 
            
     */

    internal class SelectionSort : Sort
    {
        public override void Execute(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = GetMinElementIndex(arr, i);

                // Swap the found minimum element with the first element
                Swap(arr, i, min_idx);
            }
        }

        private static int GetMinElementIndex(int[] arr, int i)
        {
            int min_idx = i, n = arr.Length;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[min_idx])
                {
                    min_idx = j;
                }
            }

            return min_idx;
        }
    }
}
