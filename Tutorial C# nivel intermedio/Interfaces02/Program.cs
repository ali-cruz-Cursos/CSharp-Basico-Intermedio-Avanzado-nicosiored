using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces02
{
    class Program
    {
        static void Main(string[] args)
        {

            // Uso de interfaces - Uso de ejemplo basico
            int opcion = 0;
            double a, b;

            IOperaciones misOperaciones = new Suma();

            while (opcion != -1)
            {
                Console.WriteLine("Cuál operación requieres realizar\n1:Suma\n2:Resta\n3:Multiplicacion\n4:Division\n-1: Salir\n");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Teclea el valor para A: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Teclea el valor para B: ");
                b = Convert.ToDouble(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        misOperaciones = new Suma();
                        break;
                    case 2:
                        misOperaciones = new Resta();
                        break;
                    case 3:
                        misOperaciones = new Multiplicacion();
                        break;
                    case 4:
                        misOperaciones = new Division();
                        break;                         
                }

                misOperaciones.Calcular(a, b);
                misOperaciones.Mostrar();
            }

        }
    }
}
