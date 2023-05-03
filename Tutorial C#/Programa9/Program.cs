using System;
using System.Collections.Generic;
using System.Text;

namespace Programa9
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            int valor = 0;
            double valorD = 0.0;

            Console.WriteLine("Escribe un numero");
            dato = Console.ReadLine();
            valor = Convert.ToInt32(dato);

            Console.WriteLine("El numero es {0}", valor);

            Console.WriteLine("Escribe un valor decimal");
            dato = Console.ReadLine();
            valorD = Convert.ToDouble(dato);

            Console.WriteLine("El valor decimal es {0}", valorD);
        }
    }
}
