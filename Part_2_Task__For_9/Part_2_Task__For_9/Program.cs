using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__For_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 6;
            int i, rez = 0;

            for (i = a; i <= b; ++i)
                rez += i * i;

            Console.WriteLine($"Rez: {rez}");
        }
    }
}
