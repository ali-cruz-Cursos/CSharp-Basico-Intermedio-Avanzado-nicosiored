using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            // Video 9

            Stack miStack = new Stack();

            miStack.Push("Manzana");
            miStack.Push("Pera");
            miStack.Push("Ciruela");
            miStack.Push("Mango");

            foreach (string fruta in miStack)
                Console.WriteLine($"Fruta: {fruta}");

            Console.WriteLine($"\nPOP {miStack.Pop()} \n");


            foreach (string fruta in miStack)
                Console.WriteLine($"Fruta: {fruta}");


            Console.WriteLine($"\nPeek {miStack.Peek()}\n");

            foreach (string fruta in miStack)
                Console.WriteLine($"Fruta: {fruta}");


            Console.WriteLine($"miStack: count {miStack.Count}");

            Console.ReadLine();
        }
    }
}
