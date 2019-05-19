using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98_Ejercicio3
{
    class CApGrados
    {
        const int LimInferior = -30;
        const int LimSuperior = 100;
        const int Incremento = 6;

        public float ObtenerFahrenheit(float gradosC)
        {
            return 9 / 5 * gradosC + 32;                 
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

    class CGrados
    {
        //Se reconstruyo el programa CApGrados.cs para que las clases CGrados y CApGrados esten almacendas en un mismo fichero.
    }
       
}
