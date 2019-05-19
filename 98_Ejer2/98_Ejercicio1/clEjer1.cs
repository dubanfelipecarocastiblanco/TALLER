using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98_Ejercicio2
{
    class clEjer2
    {
        const int LimInferior = -20;//30             //Se modifico el limInferior ,LimSuperior y el Incremento(Segun lo Planteado en el ejecicio)
        const int LimSuperior = 90;//100
        const int Incremento = 5;//6

        public float ObtenerFahrenheit(float gradosC)
        {
            return 9F / 5F * gradosC + 32;
        }

        public void Main(string[] args)
        {
            int gradosCent = LimInferior;
            float gradosFahr = 0;

            while (gradosCent <= LimSuperior)
            {
                gradosFahr = ObtenerFahrenheit(gradosCent);
                System.Console.WriteLine("{0,8:d} C {1,8:f2} F", gradosCent, gradosFahr);
                gradosCent += Incremento;
            }
        }
    }
}
