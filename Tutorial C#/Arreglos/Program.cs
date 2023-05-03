using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa las calificaciones solicitadas:\n");

            int[] calificacion = new int[5];

            int[] arreglo;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese calificación: ");
                calificacion[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("El promedio es: ");
            int promedio = 0;
            for (int j = 0; j < calificacion.Length; j++)
            {
                promedio += calificacion[j];
            }

            Console.WriteLine(promedio / calificacion.Length);

            int[,] matriz1 = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matriz1[i, j] = 2;
                }
            }

            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine(matriz1[k,k]);
            }

            int[] vector1 = new int[10];
            int elMayor = 0;
            Console.WriteLine("Llene el vector1 con valores entre 0 y 10:\n");
            
            for (int i = 0; i < vector1.Length; i++)
            {
                vector1[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int j = 0; j < vector1.Length; j++)
            {
                int sumatoria = 0;

                for (int k = 0; k < vector1.Length; k++)
                {
                    if (j == vector1[k])
                        sumatoria++;
                }

                if (sumatoria > elMayor)
                {
                    elMayor = j;
                }
                Console.WriteLine($"El numero {j} apareció {sumatoria} veces.\n");
            }

            Console.WriteLine($"El numero con mas repeticiones fue: {elMayor}\n");
            
        }
    }
}
