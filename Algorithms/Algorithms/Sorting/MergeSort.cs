﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    internal class MergeSort : Sort
    {
        public override void Execute(int[] arr)
        {
            DoMergeSort(arr, 0, arr.Length - 1);
        }

        private void DoMergeSort(int[] arr, int start, int end)
        {
            if(start < end)
            {
                // Same as (l+r)/2, but avoids overflow for
                // large l and h
                int middle = start + (end - start) / 2;

                // Sort first and second halves
                DoMergeSort(arr, start, middle);
                DoMergeSort(arr, middle + 1, end);

                DoMerge(arr, start, middle, end);
            }
        }

        private void DoMerge(int[] arr, int start, int middle, int end)
        {
            int n1 = (middle - start) + 1;  // no.of elements in first sub array
            int n2 = (end - middle);        // no.of elements in second sub array

            /* create temp arrays and copy data to temp arrays L[] and R[] */
            var L = new int[n1];
            for (int i = 0; i < n1; i++)
            {
                L[i] = arr[start + i];
            }

            var R = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                R[i] = arr[(middle + 1) + i];
            }

            /* Merge the temp arrays back into arr[l..r]*/
            int iL = 0;         // Initial index of first subarray
            int iR = 0;         // Initial index of second subarray
            int iArr = start;   // Initial index of merged subarray
            while (iL < n1 && iR < n2)
            {
                if (L[iL] <= R[iR])
                {
                    arr[iArr++] = L[iL++];
                }
                else
                {
                    arr[iArr++] = R[iR++];
                }
            }

            /* Copy the remaining elements of L[], if there are any */
            while (iL < n1)
            {
                arr[iArr++] = L[iL++];
            }

            /* Copy the remaining elements of R[], if there are any */
            while (iR < n2)
            {
                arr[iArr++] = R[iR++];
            }
        }
    }
}
