using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular el factorial de 4: " + Factorial(4));

            Console.WriteLine("Fibonacci: El valor en su posición : " + Fibonacci(6));

        }

        private static int Factorial(int n)
        {
            int r = 0;
            // Parte inductiva
            if (n > 1)
                r = n * Factorial(n - 1);

            // Caso base
            if (n == 1)
                r = 1;

            return r;
        }

        // Retorna el valor de la serie de Fibo en la posición dada
        private static int Fibonacci(int n)
        {
            int r = 0;

            // 1, 1, 2, 3, 5, 8, 13, 21...
            // Las cemillas son 1, 1

            // Caso inductivo
            if (n > 1)
                r = Fibonacci(n - 1) + Fibonacci(n - 2);

            // Caso Base
            if (n <= 1)
                r = 1;

            return r;
        }
    }
}
