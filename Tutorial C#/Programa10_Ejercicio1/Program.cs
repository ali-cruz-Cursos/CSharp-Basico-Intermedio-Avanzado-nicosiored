using System;
using System.Collections.Generic;
using System.Text;

namespace Programa10_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que calcula área y perímetro de un rectangulo

            double ladoA, ladoB, area, perimetro;

            Console.WriteLine("Escribe el valor del lado menor");
            ladoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el valor del lado mayor");
            ladoB = Convert.ToDouble(Console.ReadLine());

            area = ladoA * ladoB;

            perimetro = 2 * (ladoA + ladoB);

            Console.WriteLine("El rectangulo con lados {0} y {1} tiene un área de {2} y un perimetro de {3}", ladoA, ladoB, area, perimetro);





        }
    }
}
