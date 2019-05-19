using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _159_Ejer3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine( "Digite dia de nacimiento ");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite mes de nacimiento ");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite anio de nacimiento ");
            int anio = int.Parse(Console.ReadLine());

            int sum = dia + mes + anio;

            int res1 = sum / 10;
            int res2 = sum % 10;

            int res3 = res1 / 10;
            int res4 = sum % 10;

            int res5 = res3 / 10;
            int res6 = sum % 10;

            int suma = res1 + res2 + res3 + res4 + res5 + res6;

            int result1 = suma / 10;
            int result2 = suma % 10;

            int result3 = result1 + result2;

            int result4 = result3 / 10;
            int result5 = result3 % 10;

            int result6 = result4 + result5;
            int result7 = result6 ;

            Console.WriteLine(" \n ");
            Console.WriteLine($" Su numero de Tarot es: {result7} ");

            Console.ReadKey();

        }
    }
}
