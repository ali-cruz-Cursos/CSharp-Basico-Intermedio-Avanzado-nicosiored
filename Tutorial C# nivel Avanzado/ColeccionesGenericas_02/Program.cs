using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesGenericas_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Video 14 SortedSet
            SortedSet<CPunto> puntos = new SortedSet<CPunto>();
            puntos.Add(new CPunto(3, 7));
            puntos.Add(new CPunto(8, 11));
            puntos.Add(new CPunto(2, 6));

            foreach(CPunto p in puntos)
            {
                Console.WriteLine(p);
            }

            // Adicionar mas puntos
            Console.WriteLine("\nAgregar mas puntos\n");

            puntos.Add(new CPunto(1, 15));

            puntos.Add(new CPunto(1, 2));

            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);
            }


            Console.WriteLine();


            // Colecciones 07

            ObservableCollection<CPunto> puntosObservable = new ObservableCollection<CPunto>()
            {
                new CPunto(4,55), 
                new CPunto(17,22)
            };

            puntosObservable.CollectionChanged += puntosObservable_CollectionChanged;

            puntosObservable.Add(new CPunto(2, 3));

            CPunto miPunto = new CPunto(5, 5);

            puntosObservable.Add(miPunto);

            puntosObservable.Remove(miPunto);

            Console.ReadLine();

        }

        static void puntosObservable_CollectionChanged(object sender, 
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine($"El evento es: {e.Action}");

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Elementos nuevos");
                foreach (CPunto p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Elementos afectados por el cambio");
                foreach (CPunto p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }


        }
    }
}
