/* Hashtable I y II Video 5 y 6
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tutorial C# nivel Avanzado 5 --- HashTable I

            Hashtable miTabla = new Hashtable();

            // Adicionar elementos
            miTabla.Add(123, "Hola");
            miTabla.Add(234, "Saludos");
            miTabla.Add(45, "Adios");
            miTabla.Add(567, "C#");
            miTabla.Add(12763, "Programacion");

            // Mostramos los elementos del Hastable
            foreach (DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
            }

            // Intentamos ingresar una llave duplicada
            //miTabla.Add(123, "Otro");

            // Cantidad Elementos
            Console.WriteLine(miTabla.Count);

            // Obtener elementos del Hashtable 
            Console.WriteLine(miTabla[45]);

            // Colocar elementos en una llave
            miTabla[45] = "Cambio Valor";
            miTabla[699] = "Nuevo valor";

            foreach (DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
            }

            // Validar si existe algun elemento especificaod en mi Hashtable
            Console.WriteLine(miTabla.Contains(567));
            Console.WriteLine(miTabla.Contains(999));


            // Remover elemento del Hashtable
            // Si se intenta remover un elemento que no existe no pasa nada, no truena el programa.
            Console.WriteLine("Remover elemento:");
            miTabla.Remove(567);

            foreach (DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
            }

            // Recorrer llaves
            Console.WriteLine("Recorrer las llaves del Hashtable");
            foreach (int llave in miTabla.Keys)
            {
                Console.WriteLine(llave);
            }

            // Recorrer values
            Console.WriteLine("Recorrer values");

            foreach (string values in miTabla.Values)
            {
                Console.WriteLine(values);
            }


            Console.ReadLine();


        }
    }
}
