using System;
using System.Collections.Generic;
using System.Text;

namespace Programa5_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convertir de C a F
            double C = 38.3;
            double F = 0;

            // Convertir
            F = C * 1.8 + 32;

            // Mostrar resultado

            Console.WriteLine("La temperatura de {0} grados Celcius es equivalente a {1} grados Faherenhei", C, F);
        }
    }
}
