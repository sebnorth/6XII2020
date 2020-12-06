using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkrementacja
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("i++ = " + (i++)); // 0
            Console.WriteLine("++i = " + (++i)); // 2
            Console.WriteLine("i-- = " + (i--)); // 2
            Console.WriteLine("--i = " + (--i)); // 0

            Console.ReadKey();
        }
    }
}
