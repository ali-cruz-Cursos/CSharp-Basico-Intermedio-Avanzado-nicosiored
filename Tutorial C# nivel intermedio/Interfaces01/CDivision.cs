using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces01
{
    class CDivision:IOperacion
    {
        private double r = 0;

        public void calcular(double a, double b)
        {
            r = a / b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la division es {0}", r);
        }
    }
}
