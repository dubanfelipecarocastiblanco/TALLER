using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_Ejercicio4
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite el valor de a:");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de b:");
            double a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de c:");
            double a3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de d:");
            double a4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            clEjer4 cls = new clEjer4(a1, a2, a3, a4);
            Console.WriteLine("Su resultado es: "+cls.ValorPara(x));

            Console.ReadKey();

        }

    }
}
