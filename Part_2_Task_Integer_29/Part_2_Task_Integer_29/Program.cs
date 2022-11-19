using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task_Integer_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 8;
            int B = 6;
            int C = 2;
            int R1;
            int R2;
            int K;

            R1 = A * B;
            R2 = C * C;
            K = R1 / R2;

            Console.WriteLine($"Количество квадратов: {K}");
        }
    }
}
