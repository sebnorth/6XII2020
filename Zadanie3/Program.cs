using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            int s = 0;
            for (int i = 1; i <= n-1; i++)
            {

                s = s + i;
                Console.Write("{0} + ",i);
            }

            s += n;
            Console.Write("{0} ", n);
            Console.Write("= ");

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
