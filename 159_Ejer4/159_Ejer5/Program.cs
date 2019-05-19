using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _159_Ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ax^2 + bx + c = 0 ");

            Console.WriteLine(" Valor de A ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(" Valor de B ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(" Valor de C ");
            int c = int.Parse(Console.ReadLine());

            if ((a == 0)&&( b == 0 ))
            {
                Console.WriteLine("     Que trata de hacer   - - Ecuacion degenerada- -     ");
            }

            if ((a == 0) && (b != 0))
            {
                int res = -c / b;
                Console.WriteLine( " La respuesta " + res );
            }


            Console.ReadKey();
        }
    }
}
