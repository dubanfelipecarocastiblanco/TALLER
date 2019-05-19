using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98_Ejercicio2
{
    class clEjer2
    {
        const int LimInferior = -30; 
        const int LimSuperior = 100;
        const int Incremento = 6;

        public float ObtenerFahrenheit(float gradosC)
        {
            return 9 / 5 * gradosC + 32;                 //Se modificaron las sentencias que corresponden al metodo ObtenerFahrenheit, retirandoles f a 9 y 5.
        }                                                

        public void Main(string[] args)
        {
            int gradosCent = LimInferior;
            float gradosFahr = 0;

            while (gradosCent <= LimSuperior)
            {
                gradosFahr = ObtenerFahrenheit(gradosCent);
                System.Console.WriteLine("{0,8:d} C {1,8:f2} F", gradosCent, gradosFahr);  //Anteponemos f ,para formatear los datos de tipo float y que estos obtengan un valor formateado.   
                gradosCent += Incremento;
            }
        }
    }
}
