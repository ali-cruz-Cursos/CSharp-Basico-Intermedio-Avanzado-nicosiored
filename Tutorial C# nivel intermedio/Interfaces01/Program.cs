using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces01
{
    class Program
    {
        // Tutorial C# nivel intermedio 2 --- Interfaces
        // https://www.youtube.com/watch?v=KbveVrFqqK0&list=PLM-p96nOrGcY3KBk1k-I9eMUs4HpZAy5U&index=3&ab_channel=nicosiored

        static void Main(string[] args)
        {
            int opcion = 0;
            double valA = 0.0;
            double valB = 0.0;

            string valor = "";

            IOperacion operacion = new CResta();

            while (opcion != 5)
            {
                Console.WriteLine("1: Suma, 2: Resta, 3: Multiplicacion, 4: Division, 5: Salir");
                

                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                Console.WriteLine("Dame el valor para A:");
                valor = Console.ReadLine();
                valA = Convert.ToDouble(valor);

                Console.WriteLine("Dame el valor para B:");
                valor = Console.ReadLine();
                valB = Convert.ToDouble(valor);

                if (opcion == 1)                
                    operacion = new CSuma();
                if (opcion == 2)
                    operacion = new CResta();
                if (opcion == 3)
                    operacion = new CMultiplicacion();
                if (opcion == 4)
                    operacion = new CDivision();                

                operacion.calcular(valA, valB);
                operacion.mostrar();
            }

            
        }
    }
}
