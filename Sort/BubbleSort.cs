using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] array, bool copyToNewArray  = false)
        {
            int[] workingArray = new int[array.Length + 1];

            if (copyToNewArray)
                Array.Copy(array, workingArray, array.Length);
            else
                workingArray = array;

            int n = workingArray.Length;
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;
                for (int i = 1; i < n; i++)
                {
                    if (workingArray[i] < workingArray[i - 1])
                    {
                        isSorted = false;
                        Common.Swap(workingArray, i, i - 1);
                    }
                }
            }
            

            return workingArray;
        } 
    }
}
