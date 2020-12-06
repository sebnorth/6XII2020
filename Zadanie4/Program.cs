using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj lewy kraniec przedziału: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj prawy kraniec przedziału: ");
            int b = int.Parse(Console.ReadLine());

            int c;
            if (a > b) {

                c = a;
                a = b;
                b = c;
            }

            int i = a;

            if (i % 2 == 1) i++;

            while (i<=b)
            {
                // if (i % 2 == 0) Console.Write("{0} ", i);
                Console.Write("{0} ", i);

                i+=2;
            }

            Console.ReadKey();

        }
    }
}
