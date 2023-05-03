using System;
using System.Collections.Generic;
using System.Text;

namespace Programa10_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular el promedio de 3 numeros

            double num1, num2, num3, resultado;

            Console.WriteLine("Escribe el valor del primer número");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el valor del segundo número");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el valor del tercer número");
            num3 = Convert.ToDouble(Console.ReadLine());

            resultado = (num1 + num2 + num3) / 3;

            Console.WriteLine("El promedio de {0}, {1}, {2} es {3}", num1, num2, num3, resultado);
        }
    }
}
