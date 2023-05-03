using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Video 8

            SortedList miSortedList = new SortedList();

            miSortedList.Add(754, "Honda");
            miSortedList.Add(123, "Volvo");
            miSortedList.Add(587, "Nissan");
            miSortedList.Add(323, "Fiat");

            // Quedan ordenados por el key
            foreach (DictionaryEntry elemento in miSortedList)
            {
                Console.WriteLine($"({elemento.Key}, {elemento.Value})");
            }

            Console.WriteLine($"No elementos {miSortedList.Count}");


            // Validar si contiene elemento, retorna true o false
            Console.WriteLine($"Contains 123 {miSortedList.Contains(123)}");
            Console.WriteLine($"Contains 678 {miSortedList.Contains(678)}");


            Console.WriteLine($"Busca llave 587 {miSortedList.ContainsKey(587)}");
            Console.WriteLine($"Busca valor 678 {miSortedList.ContainsValue(678)}");

            // Obtener elementos por indice
            Console.WriteLine($"GETKEY(2){miSortedList.GetKey(2)}");
            Console.WriteLine($"GETBYINDEX(2) {miSortedList.GetByIndex(2)}");

            Console.ReadLine();

        }
    }
}
