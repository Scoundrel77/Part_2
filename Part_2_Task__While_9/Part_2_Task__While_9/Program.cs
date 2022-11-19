using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__While_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int k = 1;
            int temp = 3;

            while (temp <= n)
            {
                temp *= 3;
                ++k;
            }

            Console.WriteLine(k);
        }
    }
}
