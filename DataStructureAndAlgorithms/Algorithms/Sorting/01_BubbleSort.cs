using System;
using System.Text;

namespace DSAConcepts
{
    public class BubbleSort
    {
        public BubbleSort() { }

        public static void Sort(string str, int[] inputArr)
        {
            int counter = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = 0; j < inputArr.Length - 1; j++)
                {
                    ++counter;
                    inputArr.Swap(j, j + 1);
                }
            }
            Console.Write($"Total iteration took {counter} for {str} case. Sorted array is - ");

            inputArr.Display();
            Console.WriteLine("");
        }

        public static void SortOptimized(string str, int[] inputArr)
        {
            int counter = 0;
            bool flag = true;
            for (int i = 0; (i < inputArr.Length) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < inputArr.Length - 1; j++)   //way 2 without flag: for (int j = 0; j < inputArr.Length - 1 - i; j++) as after each iteration last will be maximum
                {
                    ++counter;
                    if (inputArr.Swap(j, j + 1))
                        flag = true;
                }
            }
            Console.Write($"Total iteration took {counter} for {str} case. Sorted array is - ");

            inputArr.Display();
            Console.WriteLine("");
        }
    }
}