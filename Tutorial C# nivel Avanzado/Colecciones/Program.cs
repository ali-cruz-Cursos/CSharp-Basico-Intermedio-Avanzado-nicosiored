using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tutorial C# nivel Avanzado 1 --- ArrayList I
            // https://www.youtube.com/watch?v=GAal3fPN59g&list=PLM-p96nOrGcbwP-Z9SYyG3LV-KYwSffWL&index=2&ab_channel=nicosiored


            /*
             * Colecciones dentro de System.Collection
             * ArrayList
             * BitArray
             * Hashtable
             * Queue
             * SortedList
             * Stack
             */

            ArrayList palabras = new ArrayList();
            int n = 0;
            int r = 0;

            palabras.AddRange(new string[] { "Hola", "mundo" });
            Console.WriteLine("El ArrayList cuenta con {0} elementos.", palabras.Count);

            for (n = 0; n < palabras.Count; n++)
                Console.Write(" {0}", palabras[n]);

            palabras.Add("Mas elementos");

            foreach (string palabra in palabras)
            {
                Console.Write(" {0}", palabra);
            }

            ArrayList valores = new ArrayList();
            valores.Add(5);
            valores.Add(7);
            valores.Add(4);

            for (n = 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }

            Console.WriteLine("Existe el 5 dentro de valores: {0}", valores.Contains(5));
            Console.WriteLine("Existe el 17 dentro de valores: {0}", valores.Contains(17));

            valores.Insert(1, 55);

            Console.WriteLine("Insertar");

            for (n = 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }


            valores.Remove(7);

            Console.WriteLine("Remover");
            for (n = 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }

            Console.WriteLine("RemoveAt");

            valores.RemoveAt(1);

            for (n = 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }

            //System.Console.ReadKey();
            Console.Read();

        }
    }
}
