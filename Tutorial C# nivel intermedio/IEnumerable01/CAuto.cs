﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable01
{
    class CAuto:IAutomovil
    {
        double costo;
        double tenencia;
        string modelo;

        public CAuto(string pModelo, double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;
        }

        public void CalculaTenencia(double pImpuesto)
        {
            tenencia = 5000.0 + costo * pImpuesto;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("Automovil {0}", modelo);
            Console.WriteLine("Costo {0}, con tenencia de {1}", costo, tenencia);
            Console.WriteLine("Total: {0}", costo + tenencia);
            Console.WriteLine("------------");
        }
    }
}
