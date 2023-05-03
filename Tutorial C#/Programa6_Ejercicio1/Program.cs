using System;
using System.Collections.Generic;
using System.Text;

namespace Programa6_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular el área total de una casa con 3 habitaciones

            // Variables
            double ancho1 = 4.3;
            double largo1 = 4.0;
            double area1 = 0;

            double ancho2= 5.0;
            double largo2 = 6.7;
            double area2 = 0;

            double ancho3 = 2.89;
            double largo3 = 3.54;
            double area3 = 0;

            double areaTotal = 0;

            // Calcular area de hab1

            area1 = largo1 * ancho1;

            // Calcular área de hab2

            area2 = largo2 * ancho2;

            // Calcular área de hab3

            area3 = ancho3 * largo3;

            // Calcular área total

            areaTotal = area1 + area2 + area3;

            // Mostrar el resultado.

            Console.WriteLine("El área total de la casa es {0}", areaTotal);

        }
    }
}
