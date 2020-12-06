using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {

        static void CzyPrzystepny(int rok) {

            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
            {

                Console.WriteLine("Rok {0} jest przestępny", rok);
            }

            else
            {

                Console.WriteLine("Rok {0} NIE jest przestępny", rok);
            }
        }
        static void Main(string[] args)
        {
            // rok przestępny
            //Console.WriteLine("Podaj rok: ");
            //int rok = int.Parse(Console.ReadLine());

            CzyPrzystepny(2020); // true
            CzyPrzystepny(2021); // false
            CzyPrzystepny(1900); // false
            CzyPrzystepny(2000); // true

            

            Console.ReadKey();
        }
    }
}
