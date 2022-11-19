using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__String_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            char c1 = 'q';
            char c2 = 'w';
            int n = 4;

            for (int i = 0; i < n; i++)
            {
                if ((i + 1) % 2 == 0)
                    a += c1;

                else
                    a += c2;
            }

            Console.WriteLine(a);
        }
    }
}
