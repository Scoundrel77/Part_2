using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__Series_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, a, k = 0;
            Console.Write("N=");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.Write("Введите число ");
                a = Convert.ToInt32(Console.ReadLine());

                if (a % 2 != 0)
                {
                    Console.WriteLine(a + " - нечетное ");
                    k++;
                }
            }

            Console.WriteLine("Количество нечетных чисел " + k);
        }
    }
}
