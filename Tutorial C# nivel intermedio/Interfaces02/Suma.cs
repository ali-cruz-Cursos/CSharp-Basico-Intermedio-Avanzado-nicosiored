using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces02
{
    class Suma : IOperaciones
    {
        private double resultado = 0;
        private ArrayList listaResultados = new ArrayList();

        public void Calcular(double a, double b)
        {
            resultado = a + b;
        }

        public void Mostrar()
        {
            Console.WriteLine($"El resultado de la suma es: {resultado}.");
            listaResultados.Add(resultado);
        }

        public void MostrarResultadosSuma()
        {
            foreach (double res in listaResultados)
            {
                Console.WriteLine(res);
            }
        }
    }
}
