using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            // Video 7 Queue

            Queue miQueue = new Queue(); // FIFO

            // Adicionar elementos
            miQueue.Enqueue("Manzana");
            miQueue.Enqueue("Fresa");
            miQueue.Enqueue("Pera");

            foreach (string fruta in miQueue)
            {
                Console.WriteLine($"-> {fruta}");
            }

            // Sacar objetos
            Console.WriteLine($"Dequeue {miQueue.Dequeue()}");
            Console.WriteLine($"Dequeue {miQueue.Dequeue()}");

            foreach (string fruta in miQueue)
            {
                Console.WriteLine($"Despues dequeue -> {fruta}");
            }

            // Adicionar objetos
            miQueue.Enqueue("Limon");
            miQueue.Enqueue("Mango");
            miQueue.Enqueue("Ciruela");

            // Observamos el objeto (No lo saca)
            Console.WriteLine($"Peek {miQueue.Peek()}");

            // Contar elementos
            Console.WriteLine("Total de elementos: " + miQueue.Count);

            // Validar si existe un elemento
            Console.WriteLine(miQueue.Contains("Mango"));
            Console.WriteLine(miQueue.Contains("Manzana"));

            SortedList sss = new SortedList();



            Console.ReadLine();
        }
    }
}
