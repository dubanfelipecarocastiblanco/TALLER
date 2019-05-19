using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98_Ejercicio2
{
    class Ejecicio2
    {
        static void Main(string[] args)
        {
            float gradosC = 0;

            Console.WriteLine(" Digite Los grados Centigrados   ");
            gradosC = int.Parse(Console.ReadLine());

            clEjer2 grados = new clEjer2();
            Console.WriteLine(grados.ObtenerFahrenheit(gradosC));

            Console.ReadKey();
        }
    }
}
