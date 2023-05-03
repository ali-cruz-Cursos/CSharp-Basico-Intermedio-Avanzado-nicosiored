using System;
using System.Collections.Generic;
using System.Text;

namespace Programa4_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que calcula el área y perímetro de un cuadrado.

            double lado = 7.5;
            double area = 0;
            double perimetro = 0.0;

            // Calcular área
            area = lado * lado;

            // Calcular perimetro
            perimetro = lado * 4;

            // Mostrar resultados
            Console.WriteLine("El área del cuadrado con {2} de medida es de {0} y su perímetro es de {1}", area, perimetro, lado);
        }
    }
}
