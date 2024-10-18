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
            pontszam = Convert.ToInt32(Console.ReadLine());

            if (pontszam < 0 || pontszam > 100)
            {
                Console.WriteLine("Érvénytelen pontszám.");
            }
        }


        static void Main(string[] args)
        {

        }
    }
}
