using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__Boolean_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, x1, x2, y, y1, y2;
            Console.Write("X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("X1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("X2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            if (x1 < x && x < x2 && y2 < y && y < y1) Console.WriteLine(true);

            else Console.WriteLine(false);

        }
    }
}
