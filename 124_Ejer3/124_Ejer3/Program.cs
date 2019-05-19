using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _124_Ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0;
            double pi = 3.1416;
            double v = 0;

            Console.WriteLine(" Introduzca el radio de la esfera ");
            r = double.Parse(Console.ReadLine());
            v = (4  * pi * Math.Pow(r, 3)/3);

            Console.WriteLine(" el volumen de la esfera es de :"+v);



            Console.ReadKey();


        }1
    }
}
