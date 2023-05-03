using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados01
{
    class Radio
    {

        // Este metodo actuara como delegado
        public static void MetodoRadio(string msgRadio)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la clase radio");
            Console.WriteLine("Este es tu mensaje {0}", msgRadio);
        }



    }
}
