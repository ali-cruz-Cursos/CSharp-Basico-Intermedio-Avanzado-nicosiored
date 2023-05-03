using System;
using System.Collections.Generic;
using System.Text;

namespace Programa7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string nombre = "";


            // Solicitar nombre
            Console.WriteLine("Dame tu nombre: ");
            nombre = Console.ReadLine();

            // Imprimir saludo
            Console.WriteLine("Hola {0}, mucho gusto", nombre);
        }
    }
}
