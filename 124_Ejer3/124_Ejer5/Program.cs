using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _124_Ejer5
{
    class Program
    {
        static void Main(string[] args)
        {

            char car = '\0';      //El caracter digitado por el usuario solo toma una letra o numero de una cadena
                                                                  
            Console.WriteLine(" caracter: ");
            car = (char)Console.Read();
            Console.WriteLine(car.ToString());
            Console.ReadKey();
        
        }
    }
}
