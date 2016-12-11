using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    internal class QuickSort : Sort
    {
        public override void Execute(int[] arr)
        {
            DoQuickSort(arr, 0, arr.Length - 1);
        }

        private void DoQuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int i = start;  // index of left-to-right scan
                int k = end;    // index of right-to-left scan

                // set the pivot as the first element in the partition
                int pivot = arr[start];

                while (k > i)
                {
                    // from the left, look for the first element greater than the pivot
                    while (arr[i] <= pivot && i <= end && k > i) { i++; }

                    // from the right, look for the first element not greater than the pivot
                    while (arr[k] > pivot && k >= start && k >= i) { k--; }

                    // if the left seekindex is still smaller than the right index,
                    // swap the corresponding elements
                    if (k > i)
                    {
                        Swap(arr, i, k);
                    }
                }

                // after the indices have crossed, swap the last element in
                // the left partition with the pivot 
                Swap(arr, start, k);

                DoQuickSort(arr, start, k - 1); // quicksort the left partition
                DoQuickSort(arr, k + 1, end);   // quicksort the right partition
            }
        }

    }
}