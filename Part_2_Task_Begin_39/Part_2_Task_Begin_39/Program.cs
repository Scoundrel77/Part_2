using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task_Begin_39
{
    class Program
    {
        static void Main(string[] args)
        {
			double A = 4;
			double B = 3;
			double C = 7;
			double D;
			D = (Math.Pow(B, 2) - 4 * A * C);

			double x1;
			double x2;
			x1 = ((-1) * B + Math.Sqrt(D)) / (2 * A);
			x2 = ((-1) * B - Math.Sqrt(D)) / (2 * A);

			if (x1 < x2)
			{
				Console.Write("x1:{0:f}\nx2:{1:f}\n", x1, x2);
			}
			else
			{
				Console.Write("x2:{0:f}\nx1:{1:f}\n", x2, x1);
			}
		}
	}
}
