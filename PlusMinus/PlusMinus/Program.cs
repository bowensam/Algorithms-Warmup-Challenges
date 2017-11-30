using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            decimal total = n; //Upcasting int to decimal (upcasting doesn't need to be explicit)
            decimal pos = 0;
            decimal neg = 0;
            decimal zero = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    pos += 1;
                else if (arr[i] < 0)
                    neg += 1;
                else //arr[i] == 0
                    zero += 1;
            }

            Console.WriteLine((pos / total).ToString("N6"));
            Console.WriteLine((neg / total).ToString("N6"));
            Console.WriteLine((zero / total).ToString("N6"));
        }
    }
}
