using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_Ejercicio3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            //Ejercicio 3

            int a = 5, c = 2, k = 3;
            double b = -1.7, d = 3.5, x = 10.5;
            double res1 = 0.0, res2 = 0.0, res3 = 0.0, rest = 0.0;
            res1 = Math.Pow(x, 4);
            res2 = Math.Pow(x, 3);
            res3 = Math.Pow(x, 2);
            rest = (a * res1) + (b * res2) + (c - res3) + (d * x) + k;

            Console.WriteLine("Ecuacion:    ax^4+bx^3-cx^2+dx+k ");
            Console.WriteLine("\n");
            Console.WriteLine($"{a}  ({res1})  +  {b}  ({res2})  -  {c}  ({res3})  +  {d} ({x})  +  {k}");
            Console.WriteLine("\n");
            Console.WriteLine(rest);

            Console.ReadKey();
        }
    }
}
