using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 5. Массив содержит 2n чисел.Из суммы первых n его элементов 
    вычесть сумму последних n элементов. */

namespace Lab_4_1_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr = new int[2*n];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(20);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            int sum_first = 0;
            for (int i = 0; i < n; i++)
                sum_first += arr[i];
            Console.WriteLine(sum_first);

            int sum_end = 0;
            for (int i = n; i < 2*n; i++)
                sum_end += arr[i];
            Console.WriteLine(sum_end);

            Console.WriteLine(sum_first - sum_end);
            Console.ReadKey();                
        }
    }
}
