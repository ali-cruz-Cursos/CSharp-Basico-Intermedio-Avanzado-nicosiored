using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator01
{
    class Program
    {
        static void Main(string[] args)
        {
            TiendaAutos tienda = new TiendaAutos();
            

            // al hacer uso de tienda en el foreach estamos trabajando con el IEnumerator
            foreach (Auto miAuto in tienda)
            {
                miAuto.CalculaTenencia(0.05);
                miAuto.MuestraInformacion();
            }


            // Parte 2 IEnumerator

            // IEnumerator 'a mano' 
            Contenedora contenedor = new Contenedora();

            foreach (int valor in contenedor)
            {
                Console.WriteLine(valor);
            }

        }
    }
}
