using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__If_9
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 9;
            float b = 4;

            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;

                Console.WriteLine($"a: {a}");
                Console.WriteLine($"b: {b}");
            }

            else
            {
                Console.WriteLine($"a: {a}");
                Console.WriteLine($"b: {b}");
            }
        }
    }
}
