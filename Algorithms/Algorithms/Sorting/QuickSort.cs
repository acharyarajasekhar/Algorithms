using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Quick Sort
    /// 
    /// 1. Pick a random (pivot) element x and Devide the n-element sequence to be sorted into two sub-sequences L and G
    ///     a. L has elements less than or equal to x
    ///     b. G has elements greater than x
    /// 2. Sort the two sub sequences L and G recursively using quick sort
    /// 
    /// Note: Quick sort is in-place sorting algorithm unlike Merge sort
    /// 
    /// Algorithm:  QuickSort(S)
    /// Input:      Sequence S
    /// Output:     Sequence S sorted in increasing order
    /// 
    /// if length(S) > 1 then
    ///     1. p = random pivot element in S
    ///     2. (S1, S2) = partition(S, p) // Both S1 and S2 are in-place sub array's in S where S1 contains elements with value less the p and S2 contains greater values
    ///     3. QuickSort(S1)
    ///     4. QuickSort(S2)
    /// end if
    /// 
    /// Note: Here merging is not explicitly required as we are working on the same array (in-place sorting)
    /// 
    /// </summary>

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