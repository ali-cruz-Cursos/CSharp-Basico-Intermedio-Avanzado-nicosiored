using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnidamientoCiclos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tablas de Multiplicar


            // Valores Primos
            bool isPrimo = false;

            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimo = false;
                        break;
                    }
                    isPrimo = true;
                }

                if (isPrimo)
                    Console.WriteLine(i);
            }
        }
    }
}
