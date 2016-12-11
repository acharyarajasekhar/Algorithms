using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    internal class BinarySearch : Search
    {
        /*

         Binary Search: Search a sorted array by repeatedly dividing the search interval in half. 
         Begin with an interval covering the whole array. 
         If the value of the search key is less than the item in the middle of the interval, 
         narrow the interval to the lower half. Otherwise narrow it to the upper half. 
         Repeatedly check until the value is found or the interval is empty.
         
        */
        public override int Execute(int[] arr, int searchItem)
        {
            return DoBinarySearch(arr, 0, arr.Length, searchItem);
        }

        private int DoBinarySearch(int[] arr, int start, int end, int searchItem)
        {
            if (end >= start)
            {
                int middle = start + (end - start) / 2;

                // If the element is present at the middle itself
                if (arr[middle] == searchItem)
                    return middle;

                // If element is smaller than mid, then it can only be present in left subarray
                if (arr[middle] > searchItem)
                    return DoBinarySearch(arr, start, middle - 1, searchItem);

                // Else the element can only be present in right subarray
                return DoBinarySearch(arr, middle + 1, end, searchItem);
            }

            // We reach here when element is not present in array
            return -1;
        }
    }
}
