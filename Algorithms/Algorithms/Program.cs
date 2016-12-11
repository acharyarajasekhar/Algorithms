using Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[0];

            arr = new int[] { 6, 10, 13, 5, 8, 3, 2, 11 };
            var ss = new SelectionSort();
            ss.Execute(arr);
            Print(arr, "Selection Sort: ");

            arr = new int[] { 6, 10, 13, 5, 8, 3, 2, 11 };
            var qs = new QuickSort();
            qs.Execute(arr);
            Print(arr, "Quick Sort: ");

            arr = new int[] { 6, 10, 13, 5, 8, 3, 2, 11 };
            var ms = new MergeSort();
            ms.Execute(arr);
            Print(arr, "Merge Sort: ");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void Print(int[] arr, string message = null)
        {
            Console.Write(message);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
