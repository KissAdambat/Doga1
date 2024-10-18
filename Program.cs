using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga1
{
    internal class Program
    {
        static void ertekeles()
        {
            Console.WriteLine("Kérem adja meg a pont számot");
            int    pontszam = Convert.ToInt32(Console.ReadLine());

            if (pontszam < 0 || pontszam > 100)
            {
                Console.WriteLine("Érvénytelen pontszám.");
            }
            else if (pontszam > 0 && pontszam < 50)
            {
                Console.WriteLine("Elégtelen");
            }
            else if (pontszam > 49 && pontszam < 60)
            {
                Console.WriteLine("Elégséges");
            }
            else if (pontszam > 59 && pontszam < 80)
            {
                Console.WriteLine("Közepes");
            }
            else if (pontszam > 79 && pontszam < 90)
            {
                Console.WriteLine("Jó");
            }
            else if (pontszam > 89 && pontszam < 101)
            {
                Console.WriteLine("Jeles");
            }
        }


        static void Main(string[] args)
        {
            ertekeles();
        }
    }
}
