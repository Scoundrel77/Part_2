using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__Boolean_39
{
    class Program
    {
        static void Main(string[] args)
        {
			int x1 = 4;
			int y1 = 8;
			int x2 = 12;
			int y2 = 3;

			if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2) || (x1 == x2) || (y1 == y2))
			{
				Console.WriteLine("Истинно");
			}

			else
			{
				Console.WriteLine("Ложь");
			}
		}
	}
}
