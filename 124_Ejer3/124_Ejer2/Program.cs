using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _124_Ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    >> Que edad tendras en el 2030 <<   ");
            Console.WriteLine($"\n");

            Console.WriteLine("Digite su Nombre");
            string nom = Console.ReadLine();

            Console.WriteLine("Digite su Anio de nacimiento");
            int anio = int.Parse(Console.ReadLine());

            int a = 2030 - anio;
            Console.WriteLine($"\n");
            Console.WriteLine($"Hola {nom}, en el anio 2030 tendras {a} anios");

            Console.ReadKey();
        }
    }
}
