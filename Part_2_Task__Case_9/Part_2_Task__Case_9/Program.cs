using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__Case_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 5, m = 8;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (d == 31)
                        d = 0;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (d == 30)
                        d = 0;
                    break;
                case 2:
                    if (d == 28)
                        d = 0;
                    break;
            }

            if (d == 0)
            {
                if (m == 12)
                    m = 1;
                else m++;
            }

            d++;
            Console.WriteLine($"{d}{m}");
        }
    }
}
