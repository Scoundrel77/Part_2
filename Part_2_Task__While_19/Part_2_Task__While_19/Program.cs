using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__While_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 6;
            int R = 0;

            while (N > 0)
            {
                int M = N % 10;
                R = R * 10 + M;
                N /= 10;
            }

            Console.Write("Число полученное при прочтении числа N справа налево: ");
            Console.Write(R);
            Console.Write("\n");
        }
    }
}
