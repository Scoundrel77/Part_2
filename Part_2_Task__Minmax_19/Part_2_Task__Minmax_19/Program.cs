using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__Minmax_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 124, 43, 124 };
            int minNumber = a[0];
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < minNumber)
                    minNumber = a[i];
            }

            foreach (var n in a)
            {
                if (n == minNumber)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
