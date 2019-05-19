using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _124_Ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Ax^5 - Bx^3 + Cx - 7 ");
            Console.WriteLine(" Digite el valor de A  ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite el valor de B  ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite el valor de C  ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite el valor de X  ");
            double n3 = double.Parse(Console.ReadLine());
            double x = 0;

            x = n * Math.Pow(n3, 5) - n1 * Math.Pow(n3, 3) + n2 * Math.Pow(n3, 0) - 7;

            Console.WriteLine($"    Ax^5 - Bx^3 + Cx - 7   =   {n} ");

            Console.ReadKey();
        }
    }
}
