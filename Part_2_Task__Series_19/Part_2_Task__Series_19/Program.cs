using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__Series_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, a, aLeft, k = 0;
            Console.Write("N=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число ");
            aLeft = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= n; i++)
            {
                Console.Write("Введите число ");
                a = Convert.ToInt32(Console.ReadLine());

                if (aLeft > a)
                {
                    Console.WriteLine(a + " - меньше левого ");
                    k++;
                }
                aLeft = a;
            }

            Console.WriteLine("Количество K=" + k);
        }
    }
}
