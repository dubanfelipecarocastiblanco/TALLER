using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98_Ejercicio3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            float gradosC = 0;

            Console.WriteLine(" Digite Los grados Centigrados   ");
            gradosC = int.Parse(Console.ReadLine());

            CApGrados grados = new CApGrados();
            Console.WriteLine(grados.ObtenerFahrenheit(gradosC));     
            
            Console.ReadKey();

        }
    }
}
