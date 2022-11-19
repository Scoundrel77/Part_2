using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__Proc_39
{
    class Program
    {
        static double Power1(double A, double B)
        {
            double result;

            if (A <= 0)
            {
                { return 0; }
            }

            else
            {
                result = Math.Exp(B * Math.Log(A));
            }
            return result;
        }
        static double Power2(double A, int N)
        {
            double rezult = 1;

            if (N < 0)
            {
                for (int i = 0; i > Math.Abs(N); i--)
                {
                    rezult *= A;
                }
                return 1 / rezult;
            }

            else
            {
                if (N == 0) { return 1; }

                else
                {
                    for (int i = 0; i < N; i++) { rezult *= A; }
                    return rezult;
                }
            }
        }
        static double Power3(double A, double B)
        {
            double result;
            double x1 = Math.Floor(B);
            double x2 = B - Math.Floor(B);

            if (x2 == 0)
            {
                result = Power2(A, (int)Math.Round(B));
                { return result; }
            }

            else
            {
                result = Power1(A, B);
            }
            return result;
        }

        static void Main(string[] args)
        {
            double d;
            Console.Write("Press P: ");
            double P = double.Parse(Console.ReadLine());
            Console.Write("Press A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Press B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Press C: ");
            double C = double.Parse(Console.ReadLine());
            d = Power3(A, P);
            Console.WriteLine("AP: " + d);
            d = Power3(B, P);
            Console.WriteLine("BP: " + d);
            d = Power3(C, P);
            Console.WriteLine("CP: " + d);
            Console.ReadKey();
        }
    }
}
