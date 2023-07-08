using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProjects
{
    internal class Solution
    {
        public static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        public static int Partition(int[] arr, int low, int high)
        {
            int i = low - 1; //lowest element to compare
            int pivot = arr[high];

            for(int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return i + 1;
        }
        public static void QuickSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
        public static void Sort(int[] arr)
        {
            Console.WriteLine("Un-Sorted array: " + string.Join(", ", arr));
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted array after QUICK SORT: \n" + string.Join(", ", arr));
        }
    }
}
