using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comentario
            Console.WriteLine("Hola a todos desde C# Console");
            Console.WriteLine("1");
            Console.WriteLine("Dos");
            Console.WriteLine("Adios");

            // Sin salto de linea
            Console.Write("Texto ");
            Console.Write("Sin salto de linea");
            Console.WriteLine();


            // Variables

            // bool - Booleanos V / F
            // char - caracteres - letras / numeros / caracteres - solo un caracter
            // int - valores numericos de tipo entero
            // float - valores de punto flotante, con decimal
            // double - valores con punto decimal, numeros mas pequeños y mas grandes que float
            // string - cadenas, coleccion de caracteres. Frases/ palabrs, etc


            // Ciclo de vida de las variables

            // Declaracion - Se crea la variable
            // Inicializacion - Su primer valor
            // Asignacion - Se le da un valor

            // Declaracion
            int valor;

            // Inicializacion
            valor = 5;
            Console.WriteLine("Valor de inicio es: {0}", valor);

            // Asignacion
            valor = 7;
            Console.WriteLine("El valor de {0} es colocado en la variable", valor);

            // Declaracion con inicializacion

            double impuesto = 1.13;

            bool encendido = true;

            char letra = 'A';
            string palabra = "Hola";
            int numeroNuevo = 19;

            Console.WriteLine("Impuesto = {0}, numero = {1}", impuesto, numeroNuevo);

            Console.WriteLine("Se tiene {1} en el bool y {0} en la letra", letra, encendido);

            Console.WriteLine("La cadena dice {0}", palabra);

            // Asignacion
            encendido = false;
            letra = '*';
            impuesto = -387.986;
            palabra = "Adiós";



            Console.WriteLine("Impuesto = {0}, numero = {1}", impuesto, numeroNuevo);

            Console.WriteLine("Se tiene {1} en el bool y {0} en la letra", letra, encendido);

            Console.WriteLine("La cadena dice {0}", palabra);




        }
    }
}
