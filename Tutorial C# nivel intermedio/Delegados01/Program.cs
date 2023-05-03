using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados01
{
    // Definimos delegado con las características que nos interesan
    public delegate void MiDelegado(string msg);

    class Program
    {
        static void Main(string[] args)
        {
            // Video 9 - Delegados
            // https://www.youtube.com/watch?v=GQbJH6HRenE&ab_channel=nicosiored

            // Creamos objeto delegado y lo referenciamos a un método
            MiDelegado delegado = new MiDelegado(Radio.MetodoRadio);

            // Ahora por medio del delegado hacemos uso del metodo
            delegado("Mensaje para Radio");

            // Apuntamos a otro método
            delegado = new MiDelegado(Pastel.MostrarPastel);

            // Ahora invocamos al metodo 
            delegado("Anuncio pastel");

            Console.ReadLine();

        }
    }
}
