using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__If_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 3;
            int d = 3;
            int n = 0;

            if (a == b && b == c)
            {
                n = 4;
            }

            else if (a == b && a == d)
            {
                n = 3;
            }

            else if (a == c && a == d)
            {
                n = 2;
            }

            else if (b == c && b == d)
            {
                n = 1;
            }

            Console.WriteLine($"порядковый номер числа, отличного от остальных: {n}");
        }
    }
}
