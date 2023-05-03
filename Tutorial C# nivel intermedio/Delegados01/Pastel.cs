using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados01
{
    class Pastel
    {

        // Este metodo actuará como delegado
        public static void MostrarPastel(string anuncioPastel)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El pastel llevara el mensaje {0}:", anuncioPastel);
        }


    }
}
