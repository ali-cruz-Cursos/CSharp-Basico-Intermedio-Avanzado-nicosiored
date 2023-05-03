using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones_ColeccionesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Video 10 introduccion

            // Video 11
            List<int> valores = new List<int>();
            int n = 0;
            int r = 0;

            valores.Add(7);
            valores.Add(5);
            valores.Add(4);
            valores.Add(3);
            valores.Add(8);
            valores.Add(9);
            valores.Add(8);

            foreach (var item in valores)
            {
                Console.WriteLine($"item: {item}");
            }


            Console.WriteLine($"\ncontains 5: {valores.Contains<int>(5)}");
            Console.WriteLine($"Containts 17: {valores.Contains<int>(17)}");

            // Posición donde se encuentra el dato buscado
            Console.WriteLine($"\nIndexof 9: {valores.IndexOf(9)}\n");

            Console.WriteLine("\nInsert(2,55)\n");
            valores.Insert(2, 55);


            foreach (var item in valores)
            {
                Console.WriteLine($"item: {item}");
            }

            Console.WriteLine($"\nRemoveAt(3):\n");
            valores.RemoveAt(3);

            foreach (var item in valores)
            {
                Console.WriteLine($"item: {item}");
            }

            Console.WriteLine($"\nremove(8)\n");
            valores.Remove(8);

            foreach (var item in valores)
            {
                Console.WriteLine($"item: {item}");
            }

            // Video 12

            Console.WriteLine("\nvalores.Reverse()");
            valores.Reverse();

            foreach (var item in valores)
            {
                Console.WriteLine($"item : {item}");
            }

            // Ordenar Lista
            valores.Sort();

            Console.WriteLine("\n\nSORT\n");
            foreach (int val in valores)
            {
                Console.WriteLine($"val {val}");
            }


            // lista de nuestra clase
            Console.WriteLine("\ncpunto\n");

            List<CPunto> listaPuntos = new List<CPunto>();
            listaPuntos.Add(new CPunto(5, 3));
            listaPuntos.Add(new CPunto(7, 8));
            listaPuntos.Add(new CPunto(12, 5));
            listaPuntos.Add(new CPunto(6, 2));

            listaPuntos.Insert(1, new CPunto(100, 150));
            foreach (CPunto cpunto in listaPuntos)
            {
                Console.WriteLine("Punto: " + cpunto);

            }

            // Copiar listado a un arreglo
            Console.WriteLine("\nCopiar listado a arreglo\n");

            CPunto[] cPuntosArr = listaPuntos.ToArray();

            for (int i = 0; i < cPuntosArr.Length; i++)
            {
                Console.WriteLine($"cPuntosArr[{i}] = {cPuntosArr[i]}");
            }


            // Video 13 stack queue genericos

            Console.WriteLine("\nSTACK\n");
            Stack<CPunto> puntos = new Stack<CPunto>();
            puntos.Push(new CPunto(3, 4));
            puntos.Push(new CPunto(5, 7));
            puntos.Push(new CPunto(9, 11));
            puntos.Push(new CPunto(1, 4));

            foreach (CPunto p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("\n PEEK \n");
            Console.WriteLine($"Peek {puntos.Peek()}");

            foreach (CPunto p in puntos)
            {
                Console.WriteLine($"p {p}");
            }

            Console.WriteLine("\n POP \n");

            Console.WriteLine($"Pop {puntos.Pop()}");
            Console.WriteLine($"Pop {puntos.Pop()} \n");

            foreach (CPunto p in puntos)
            {
                Console.WriteLine($"p {p}");
            }

            Console.WriteLine("\npeek\n");

            foreach (CPunto p in puntos)
            {
                Console.WriteLine($"p {p}");
            }


            Console.WriteLine("\nQueue\n");
            Queue<CPunto> puntosQ = new Queue<CPunto>();

            puntosQ.Enqueue(new CPunto(3, 7));
            puntosQ.Enqueue(new CPunto(7, 9));
            puntosQ.Enqueue(new CPunto(11, 2));


            foreach (CPunto p in puntosQ)
            {
                Console.WriteLine($"p {p}");
            }


            Console.WriteLine($"\n Hacemos peek {puntosQ.Peek()}");

            foreach (CPunto p in puntosQ)
            {
                Console.WriteLine($" p {p}");
            }

            Console.WriteLine("\nDequeue\n");
            Console.WriteLine($"Dequeue {puntosQ.Dequeue()}");
            Console.WriteLine($"Dequeue {puntosQ.Dequeue()}");

            foreach (CPunto p in puntosQ)
            {
                Console.WriteLine($"p {p}");
            }






            Console.ReadLine();
        }
    }
}
