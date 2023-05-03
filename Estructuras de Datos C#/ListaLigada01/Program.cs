using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada01
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaLigada listaLigada = new ListaLigada();

            listaLigada.Adicionar(3);
            listaLigada.Adicionar(5);
            listaLigada.Adicionar(7);
            listaLigada.Adicionar(7);
            listaLigada.Adicionar(9);
            listaLigada.Adicionar(11);
            listaLigada.Adicionar(7);
            listaLigada.Adicionar(15);

            Console.WriteLine("Esta vacia: " + listaLigada.EsVacia());
            listaLigada.Transversa();

            //listaLigada.Vaciar();
            //Console.WriteLine("Esta vacia: " + listaLigada.EsVacia());

            listaLigada.Transversa();

            Nodo encontrado = listaLigada.Buscar(9);

            Console.WriteLine("Encontrar el elemento 9 " + encontrado);

            Console.WriteLine($"Buscar el índice del elemento 9: [{ listaLigada.BuscarIndice(9) }] ");

            Console.WriteLine($"Buscar el nodo anterior al 11 {listaLigada.BuscarAnterior(11)}");

            listaLigada.BorrarNodo(7);

            Console.WriteLine($"Borrar nodo 7:");
            listaLigada.Transversa();

            listaLigada.InsertarNodo(9, 99);
            Console.WriteLine("Insertar nodo en la posicion 9: ");
            listaLigada.Transversa();

            Console.WriteLine("Insertar nodo al inicio.");
            listaLigada.InsertarNodoAlInicio(111);
            listaLigada.Transversa();

            Console.WriteLine("Buscar por el índice 3: ");
            Console.WriteLine("::" + listaLigada.ObtenerPorIndice(3));
            listaLigada.Transversa();
        }
    }
}
