﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2For
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            for (int i = 1; i <= 10; i++)
            {
                s = s + i;
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
