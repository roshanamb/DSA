using System;
using System.Text;

namespace DSAConcepts
{
    public class SelectionSort
    {
        public SelectionSort() { }

        public static void Sort(string str, int[] inputArr)
        {
            int counter = 0, min;
            int len = inputArr.Length;
            for (int i = 0; i < len; i++)
            {
                min = i;
                for (int j = i + 1; j < len - 1; j++)
                {
                    ++counter;
                    if (inputArr[min] > inputArr[j])
                    {
                        min = j;
                    }
                }

                //Swap the 'min' position with 'i' position
                inputArr.Swap(i, min);
            }
            Console.Write($"Total iteration took {counter} for {str} case. Sorted array is - ");

            inputArr.Display();
            Console.WriteLine("");
        }

        public static void SortOptimized(string str, int[] inputArr)
        {
            int counter = 0, min;
            int len = inputArr.Length;
            for (int i = 0; i < len; i++)
            {
                min = i;
                for (int j = i + 1; j < len - 1; j++)
                {
                    ++counter;
                    if (inputArr[min] > inputArr[j])
                    {
                        min = j;
                    }
                }

                //Swap the 'min' position with 'i' position
                inputArr.Swap(i, min);
            }
            Console.Write($"Total iteration took {counter} for {str} case. Sorted array is - ");

            inputArr.Display();
            Console.WriteLine("");
        }
    }
}