using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxSum
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            Program p = new Program();
            long[] sumList = new long[arr.Length];
            long minSum = p.findSum(arr, 0); //initialize minSum with the first sum value
            long maxSum = p.findSum(arr, 0); //initialize maxSum with the first sum value

            for (int i = 0; i < sumList.Length; i++)
            {
                sumList[i] = p.findSum(arr, i);

                if (sumList[i] > maxSum)
                    maxSum = sumList[i];
                if (sumList[i] < minSum)
                    minSum = sumList[i];
            }
            Console.WriteLine(minSum + " " + maxSum);
        }

        private long findSum(int[] array, int neglect)
        {
            long sum = 0;

            for (int i = 0; i < array.Length; i++)
                if (i != neglect)
                    sum += array[i];

            return sum;
        }
    }
}
