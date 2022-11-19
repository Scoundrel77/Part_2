using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__Array_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 124, 43, 124 };
            int maxNumber = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    if (a[i] > maxNumber)
                        maxNumber = a[i];
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
