using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _124_Ejer6
{
    class Program
    {
        static void Main(string[] args)
        {

            int car1 = 'A', car2 = 65, car3 = 0;

            car3 = car1 + 'a' - 'A';                 // La operacion esta realizando una concatenación
            Console.WriteLine((char)car3 + "" + car3);
            
            car3 = car2 + 32;
            Console.WriteLine((char)car3 + "" + car3);


            Console.ReadKey();
        }
    }
}
