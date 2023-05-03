using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable01
{
    class Program
    {
        static void Main(string[] args)
        {
            CTiendaAutos tienda = new CTiendaAutos();

            foreach (CAuto miAuto in tienda)
            {
                miAuto.CalculaTenencia(0.05);
                miAuto.MuestraInformacion();
            }

            Console.ReadKey();
        }
    }
}
