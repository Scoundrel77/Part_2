using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__Array_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 124, 43, 124 };

            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write($"{a[i]} ");
            }

            Console.WriteLine($"Длинна массива: {a.Length}");
        }
    }
}
