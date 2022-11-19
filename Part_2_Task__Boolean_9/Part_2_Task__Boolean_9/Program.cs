using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__Boolean_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 10;
            int B = 6;

            if (A % 2 == 0 || B % 2 == 0)
            {
                Console.Write("Истинно");
            }

            else
            {
                Console.Write("Ложь");
            }
        }
    }
}
