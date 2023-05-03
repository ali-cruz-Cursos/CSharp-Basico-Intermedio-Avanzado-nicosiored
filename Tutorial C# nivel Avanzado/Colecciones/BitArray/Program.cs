using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray01
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray miArreglo = new BitArray(new byte[] { 1, 2, 4, 8, 16 });

            // Cantidad de elementos, 5 bytes * 8 = 40 bits
            Console.WriteLine("Longitud de mi arreglo. 5 Bytes = {0} bits. [1, 2, 4, 8, 16]", miArreglo.Count);
            Console.WriteLine("Muestro arreglo bits");
            MuestraArreglo(miArreglo);

            Console.WriteLine("Obtener bit en particular. arreglo.Get(9)");
            Console.WriteLine(miArreglo.Get(9));

            Console.WriteLine("Agregar bit. arreglo.Set(3)");
            miArreglo.Set(3, true);
            MuestraArreglo(miArreglo);
            Console.WriteLine($"Valor miArreglo.Get(3): {miArreglo.Get(3)}");

            // Clonar el bitarray
            Console.WriteLine("Clonado BitArray.");
            BitArray arreglo2 = (BitArray)miArreglo.Clone();
            MuestraArreglo(arreglo2, "arreglo2\n");

            // Invertir el arreglo con NOT
            Console.WriteLine("Convierto a not BitArray.");
            arreglo2.Not();
            MuestraArreglo(arreglo2);

            // Crear otro arreglo
            BitArray arreglo3 = new BitArray(new byte[] { 5, 7, 9, 13, 15 });
            MuestraArreglo(arreglo3, "arreglo 3\n");
            Console.WriteLine("---");

            // Hacemos OR entre arreglos
            Console.WriteLine("OR entre arreglos BitArray.");
            arreglo3.Or(miArreglo);
            MuestraArreglo(miArreglo, "miArreglo\n");
            MuestraArreglo(arreglo3, "arreglo3\n");
            Console.WriteLine("=======");


            // Hacemos AND entre arreglos
            Console.WriteLine("AND entre arreglos BitArray.");
            arreglo3.And(miArreglo);
            MuestraArreglo(arreglo3, "Resulato miArreglo AND arreglo3\n");
            Console.WriteLine("-----");

            // Hacemos XOR entre arreglo3 y miArreglo
            arreglo3 = new BitArray(new byte[] { 5, 7, 9, 13, 21 });
            Console.WriteLine("XOR entre arreglo3 [5,7,9,13,21] y miArreglo\n");
            MuestraArreglo(miArreglo, "miArreglo\n");
            MuestraArreglo(arreglo3, "arreglo3\n");
            Console.WriteLine("============");

            arreglo3.Xor(miArreglo);
            MuestraArreglo(miArreglo, "miArreglo\n");
            MuestraArreglo(arreglo3, "arreglo3\n");
            Console.WriteLine("============");

            Console.ReadKey();            

        }

        public static void MuestraArreglo(BitArray pArreglo, string pNombre = "")
        {
            int c = 0;
            Console.Write("{0}\t", pNombre);

            foreach (bool b in pArreglo)
            {
                c++;
                if (b)
                    Console.Write("1");
                else
                    Console.Write("0");
                if (c % 8 == 0)
                    Console.Write(",");
            }

            Console.WriteLine();
        }
    }
}
