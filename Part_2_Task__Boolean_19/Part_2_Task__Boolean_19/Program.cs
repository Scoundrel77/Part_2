using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__Boolean_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 3;
            int B = 5;
            int C = 6;

            Console.WriteLine(((A == (-1) * B) | (A == (-1) * C) |
                (B == (-1) * C)));
        }
    }
}
