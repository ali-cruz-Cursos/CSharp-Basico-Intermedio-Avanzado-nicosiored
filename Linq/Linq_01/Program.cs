using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Video 01
            // https://www.youtube.com/watch?v=CSRMkExmogQ&list=PLM-p96nOrGcYGyfYpStN3jnaTuIosO3V5&ab_channel=nicosiored

            int[] numeros = { 1, 5, 7, 3, 5, 9, 8 };


            IEnumerable<int> valores = from item in numeros
                                       where item > 3 && item < 8
                                       select item;

            foreach (int num in valores)
            {
                Console.WriteLine($"num: {num}");
            }

            Console.WriteLine("----------------");

            string[] postres = { "Pay de manzana", "Pastel de chocolate", "manzana caramelizada", "Fresas con crema" };

            IEnumerable<string> res = from item in postres
                                          where item.Contains("manzana")
                                          orderby item
                                          select item;

            foreach (string item in res)
            {
                Console.WriteLine($"item: {item}");
            }

            Console.WriteLine("----------------");
            // reflexion
            InformacionResultados(valores); // Enteros
            Console.WriteLine("----------------");
            InformacionResultados(res); // Postres

            Console.WriteLine("----------------");

            // Video 2

            int[] numeros2 = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };

            // Hacemos el query y usamos un tipo implicito por medio de var
            var valores2 = from n in numeros2
                           where n % 2 == 0
                           select n;


            foreach (int num in valores2)
            {
                Console.WriteLine($"num: {num}");
            }

            Console.WriteLine("----------------");

            // Reflexion
            InformacionResultados(valores2);

            Console.WriteLine("----------------");


            // ejecucion diferida - Solo se ejecuta el query cuando se itera sobre la coleccion

            // modificamos arreglo
            numeros2[1] = 12;
            foreach (int num in valores2)
            {
                Console.WriteLine($"num: {num}");
            }

            Console.WriteLine("----------------");

            // Ejecucion inmediata

            // Guardamos los resultados como un arreglo
            int[] arrayValores = (from n in numeros2
                                  where n % 2 == 0
                                  select n).ToArray<int>();

            // Guardamos los resultados como list
            List<int> listValores = (from n in numeros2
                                     where n % 2 == 0
                                     select n).ToList<int>();


            Console.WriteLine("Arreglo");

            foreach (int num in arrayValores)
            {
                Console.WriteLine($"num {num}");
            }
            Console.WriteLine("----------------");

            numeros2[0] = 28;
            Console.WriteLine($"numeros2[0] = 28");

            foreach (int num in arrayValores)
            {
                Console.WriteLine($"num {num}");
            }

            Console.WriteLine("Lista");

            foreach (int num in listValores)
            {
                Console.WriteLine($"num {num}");
            }

            Console.WriteLine("----------------");


            Console.WriteLine("----------------");
            Console.ReadLine();

        }

        static void InformacionResultados(object pResultados)
        {
            Console.WriteLine($"Tipo {pResultados.GetType().Name}");
            Console.WriteLine($"Locacion {pResultados.GetType().Assembly.GetName().Name}");
        }
    }
}
