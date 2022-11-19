using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__For_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            float a = 2, b = 7;

            float h = (b - a) / n;
            Console.WriteLine($"{h}");

            int i;

            for (i = 0; i <= n; ++i)
            {
                Console.WriteLine($"{a + i * h} ");
            }
        }
    }
}
