using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _159_Ejer_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next();
            Console.WriteLine(" Numeros a evaluar: {0} ", num );

            Console.WriteLine(" Digite un numero ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(" \n ");

            int num1 = rnd.Next(0, 10);
            Console.WriteLine(" Número entre 0 y 10: {0} ", num1 );

            if (n==num1)
            {
                Console.WriteLine(" -- Gano -- ");

            }
            else
            {
                Console.WriteLine(" -- Perdio -- ");
            }


            Console.ReadKey();

        }
    }
}
