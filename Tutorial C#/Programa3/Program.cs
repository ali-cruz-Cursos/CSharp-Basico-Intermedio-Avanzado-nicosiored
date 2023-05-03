using System;
using System.Collections.Generic;
using System.Text;

namespace Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1  = 1.5;
            double valor2 = 3.7;
            double valor3 = 6.7;
            double resultado = 0.0;

            resultado = 5.6 + 2;

            Console.WriteLine(resultado);

            resultado = valor1 + 10.5;

            Console.WriteLine(resultado);

            // Jerarquia de operadores

            // 5 + 6 * 2

            // * / %
            // + -

            resultado = 5 + 6 * 2;

            Console.WriteLine(resultado);

            resultado = 5 + (6 * 2);
            Console.WriteLine(resultado);

            resultado = (5 + 6) * 2;
            Console.WriteLine(resultado);

            resultado = ((valor1 + valor2) * (valor2 / valor3));
            Console.WriteLine(resultado);

            // Problemas comunes con variables.


            //5.2 + 2 = resultado;





        }
    }
}
