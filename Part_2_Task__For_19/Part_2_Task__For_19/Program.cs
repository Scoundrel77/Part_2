using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__For_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            float rez = 1;
            int i;

            for (i = 1; i <= n; ++i)
                rez *= (float)i;

            Console.WriteLine($"Rez: {rez}");
        }
    }
}
