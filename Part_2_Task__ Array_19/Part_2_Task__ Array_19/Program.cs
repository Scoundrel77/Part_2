using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task___Array_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            Random rnd = new Random();
            int i = 0;

            while (i < 10)
            {
                int temp = rnd.Next(10);
                if (A[temp] == 0)
                {
                    A[temp] = i;
                    i++;
                }
            }
            Array.Sort(A);

            for (int j = 0; j < A.Length; j++)
            {
                Console.Write(A[j] + "\t");
            }
            Console.Write("\n");
            Console.WriteLine("Индекс элемента по условию: {0}", A.Length - 1);
            Console.ReadKey(true);
        }
    }
}
