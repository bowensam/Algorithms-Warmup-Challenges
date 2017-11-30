using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    {
        static int birthdayCakeCandles(int n, int[] ar)
        {
            // Complete this function
            int totalCandles = 0;
            int tallestCandleHeight = ar[0]; //Establish a baseline for comparison (using the height of the first candle)

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == tallestCandleHeight) //Found another occurrence of the current tallest height, increment counter
                    totalCandles += 1;

                else if (ar[i] > tallestCandleHeight)
                { //Found another tallest height, reset counter to 1
                    tallestCandleHeight = ar[i];
                    totalCandles = 1;
                }
            }
            return totalCandles;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //n = total number of candles
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse); //ar = array of candle heights
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
        }
    }
}
