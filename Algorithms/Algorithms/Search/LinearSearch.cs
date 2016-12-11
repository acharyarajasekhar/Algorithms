using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    internal class LinearSearch : Search
    {
        /*
         
        LinearSearch
        
        Start from the leftmost element of arr[] and one by one compare x with each element of arr[]
        If x matches with an element, return the index.
        If x doesn’t match with any of elements, return -1.
         
        */

        public override int Execute(int[] arr, int item)
        {
            for(int i = 0;i<arr.Length;i++)
            {
                if (arr[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
