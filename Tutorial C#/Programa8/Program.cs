using System;
using System.Collections.Generic;
using System.Text;

namespace Programa8
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido;

            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Escribe tu apellido");
            apellido = Console.ReadLine();

            Console.WriteLine("Hola {0}, tu apellido es {1}", nombre, apellido);
        }
    }
}
