using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__For_39
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 6;
            int i, i2;

            for (i = a; i <= b; ++i)
            {
                for (i2 = 1; i2 <= i; ++i2)
                    Console.WriteLine($"{i}");
            }
        }
    }
}
