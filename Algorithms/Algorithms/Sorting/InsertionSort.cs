using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    internal class InsertionSort: Sort
    {
        public override void Execute(int[] arr)
        {
            int n = arr.Length;

            for (int j = 0; j < n; j++)
            {
                for (int i = j; i > 0 && arr[i] < arr[i - 1]; i--)
                {
                    Swap(arr, i, i-1);
                }
            }
        }
    }
}
