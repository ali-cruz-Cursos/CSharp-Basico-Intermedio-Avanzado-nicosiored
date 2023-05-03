using System;
using System.Collections.Generic;
using System.Text;

namespace Programa10_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convierte de pesos a dolares

            double pesos, dolares, tc;

            Console.WriteLine("Escribe la tasa de cambio de conversion del día de hoy");
            tc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe tu valor en pesos a convertir");
            pesos = Convert.ToDouble(Console.ReadLine());

            dolares = pesos / tc;

            Console.WriteLine("El valor de {0} pesos es igual a {1} dolares", pesos, dolares);
            
        }
    }
}
