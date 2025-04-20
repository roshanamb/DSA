using System;
using System.Data;
using System.Reflection.Metadata;
using System.Text;

namespace DSAConcepts
{
    public static class Utility
    {
        /// <summary>
        /// Swap i index with j index in an Array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static bool Swap(this int[] arr, int i, int j)
        {
            int temp;
            bool swapCondition = arr[i] > arr[j];
            if (swapCondition)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            return swapCondition;
        }

        public static void Display(this int[] arr)
        {
            foreach (var v in arr)
            {
                Console.Write(" {0}", v);
            }
        }

    }
}