using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            // program oblicza sumę 1+2+... +10;
            int s = 0;
            int i = 1;

            while (i<=10)
            {
                // s += i++;

                // s+= ++i;

                s = s + i; 
                Console.WriteLine("Aktualna wartość i: {0}. Aktualna wartość s: {1}", i, s);
                i = i + 1;
            }

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
