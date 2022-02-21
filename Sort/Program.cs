using System;

namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputArray = new int[] {4,3,1,2,5,6,8,4,9,14,2,13};

            var sortedArray = BubbleSort.Sort(inputArray, true);
            Console.WriteLine("Bubble Sort");
            Common.PrintArray(sortedArray);
        }
    }
}
