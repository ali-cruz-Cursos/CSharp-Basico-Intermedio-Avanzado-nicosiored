using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator01
{
    class Auto:IAutomovil
    {
        double costo;
        double tenencia;
        string modelo;

        public Auto(string modelo, double costo)
        {
            this.costo = costo;
            this.modelo = modelo;
        }

        public void CalculaTenencia(double impuesto)
        {
            tenencia = 5000.0 + costo * impuesto;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine($"Tu automovil modelo {modelo}");
            Console.WriteLine($"Costo {costo}, con una tenencia de {tenencia}");
            Console.WriteLine($"Total {costo + tenencia} \n------------------------");
        }
    }
}
