using System;
using System.Collections.Generic;
using System.Text;

namespace Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operdores aritmeticos
            // Suma - +
            // Resta - -
            // Multiplicacion - *
            // Division - /
            // Modulo - %
            // Asignacion - =
            // Agrupacion - ()

            double valor1 = 1.5;
            double valor2 = 4.7;
            double resultado = 0.0;

            resultado = valor1 + valor2;

            Console.WriteLine("{0} + {1} = {2}", valor1, valor2, resultado);

            resultado = valor1 - valor2;

            Console.WriteLine("{0} - {1} = {2}", valor1, valor2, resultado);

            resultado = valor1 * valor2;

            Console.WriteLine("{0} * {1} = {2}", valor1, valor2, resultado);

            resultado = valor1 / valor2;

            Console.WriteLine("{0} / {1} = {2}", valor1, valor2, resultado);

            resultado = valor1 % valor2;

            Console.WriteLine("El residuo de {0} % {1} = {2}", valor1, valor2, resultado);




        }
    }
}
