
using System;
using System.Text;

namespace DSAConcepts
{
    public class BootstrapSorting : IDataStructure
    {
        private const string strAvg = "Average";
        private const string strBest = "Best";
        private const string strWorst = "Worst";

        public void Run()
        {
            int[] input_best, input_worst, input_avg;

            input_best = new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 100 };
            input_worst = new int[] { 100, 99, 88, 77, 66, 55, 44, 33, 22, 11 };
            input_avg = new int[] { 55, 77, 88, 99, 44, 11, 100, 66, 22, 33 };

            #region Bubble Sort

            System.Console.WriteLine("------------------------ Bubble Sort -----------------------------");
            BubbleSort.Sort(strAvg, input_avg);
            BubbleSort.Sort(strWorst, input_worst);
            BubbleSort.Sort(strBest, input_best);

            System.Console.WriteLine("------------------------ Bubble Sort (Optimized)-----------------------------");
            BubbleSort.SortOptimized(strAvg, input_avg);
            BubbleSort.SortOptimized(strWorst, input_worst);
            BubbleSort.SortOptimized(strBest, input_best);

            #endregion

            #region Selection Sort

            System.Console.WriteLine("------------------------ Selection Sort -----------------------------");
            SelectionSort.Sort(strAvg, input_avg);
            SelectionSort.Sort(strWorst, input_worst);
            SelectionSort.Sort(strBest, input_best);

            System.Console.WriteLine("------------------------ Selection Sort (Optimized)-----------------------------");
            //SelectionSort.SortOptimized(strAvg, input_avg);
            SelectionSort.SortOptimized(strWorst, input_worst);
            //SelectionSort.SortOptimized(strBest, input_best);

            #endregion

        }
    }
}