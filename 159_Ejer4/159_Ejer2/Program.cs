using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _159_Ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite numero ");

            int Num, sum = 0;
            Num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= Num; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);



            Console.ReadKey();


        }
    }
}
