using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            String[,] staircase = new String[n, n];


            for (int i = 0; i < staircase.GetLength(0); i++)
            {
                for (int j = 0; j < staircase.GetLength(1); j++)
                {
                    if (j >= (staircase.GetLength(0) - 1 - i))
                        staircase[i, j] = "#";
                    else
                        staircase[i, j] = " ";
                }
            }

            for (int i = 0; i < staircase.GetLength(0); i++)
            {
                for (int j = 0; j < staircase.GetLength(1); j++)
                {
                    Console.Write(staircase[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
