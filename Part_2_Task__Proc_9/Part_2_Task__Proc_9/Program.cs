using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__Proc_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = 2345;
            int D1 = 9;
            int D2 = 1;
            AddLeftDigit(D1, ref K);
            Console.WriteLine(K);
            AddLeftDigit(D2, ref K);
            Console.WriteLine(K);
        }

        public static void AddLeftDigit(int D, ref int K)
        {
            if (D <= 0 || D > 9 || K <= 0)
                throw new ArgumentException("Неверное значение параметров");
            int n = K;

            while (n != 0)
            {
                n /= 10;
                D *= 10;
            }
            K += D;
        }
    }
}
