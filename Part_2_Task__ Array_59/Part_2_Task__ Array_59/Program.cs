using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task___Array_59
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[10];
            Random rand = new Random();
            int k = 5;

            for (int i = 0; i < arrayA.Length; i++) arrayA[i] = rand.Next(-10, 10);
            int temp = 1;

            for (int i = k; i < arrayA.Length; i++) temp *= arrayA[i];
            int[] arrayB = new int[10];
            arrayB = arrayA;
            arrayB[k] = temp;

            Console.WriteLine(string.Join(" ", arrayA));
            Console.WriteLine(string.Join(" ", arrayB));

            Console.ReadKey();
        }
    }
}
