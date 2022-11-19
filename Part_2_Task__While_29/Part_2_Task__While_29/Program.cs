using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_Task__While_29
{
    class Program
    {
        static void Main(string[] args)
        {
			float e = 2;
			float ak1 = 1F;
			float ak = 2F;
			float ak2;
			int k = 2;

			while (Math.Abs(ak - ak1) >= e)
			{
				ak2 = ak1;
				ak1 = ak;
				ak = (ak2 + 2 * ak1) / 3;
				++k;
			}

			Console.Write("k:");
			Console.WriteLine(k);
			Console.Write("A(k-1):");
			Console.WriteLine(ak1);
			Console.Write("Ak:");
			Console.WriteLine(ak);
		}
	}
}
