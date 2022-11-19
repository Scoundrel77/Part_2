using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__Proc_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 1231;
            Console.WriteLine(CountDegrees(s));
        }

        static int CountDegrees(int num)
        {
            return num.ToString().Length;
        }
    }
}
