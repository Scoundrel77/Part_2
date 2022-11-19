using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task_Begin_19
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1 = 3;
            float y1 = 4;
            float x2 = 6;
            float y2 = 1;

            Console.Write("P:{0:f}\n", 2 * (Math.Abs(x1 - x2) + Math.Abs(y1 - y2)));
            Console.Write("S:{0:f}\n", Math.Abs(x1 - x2) * Math.Abs(y1 - y2));
        }
    }
}
