using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _124_Ejer_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" p = 3x^5 - 5x^3 + 2x - 7 ");
            Console.WriteLine(" Digite el valor de x  ");
            double n = double.Parse(Console.ReadLine());
            double x =0;

            x = 3 * Math.Pow(n, 5) - 5 * Math.Pow(n, 3) + 2 * Math.Pow(n, 0) - 7;

            Console.WriteLine($" para x = {n},  3x^5 - 5x^3 + 2x - 7 = {x} ");

            Console.ReadKey();
        }
    }
}
