using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_Ejer1
{
    class Ejercicio2
    {
        static void Main(string[] arg)
        {
            //Ejercicio 2

            string str = "q";
            foreach (byte b in System.Text.Encoding.UTF8.GetBytes(str.ToCharArray()))       //Valor Unicode de "q".
                Console.Write(b.ToString());

            string str1 = "Q";
            foreach (byte b in System.Text.Encoding.UTF8.GetBytes(str1.ToCharArray()))      //Valor Unicode de "Q".
                Console.Write(b.ToString());

        }
    }
}
