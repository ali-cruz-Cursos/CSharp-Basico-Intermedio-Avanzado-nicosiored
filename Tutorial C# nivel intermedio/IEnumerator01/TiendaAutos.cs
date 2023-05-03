using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator01
{
    class TiendaAutos
    {
        // Arreglo de tipo Auto
        private Auto[] disponibles;

        public TiendaAutos()
        {
            // Se define tamaño del arreglo
            disponibles = new Auto[4];

            // Se llena el arreglo pasando los parametros al constructor de Auto
            disponibles[0] = new Auto("Soul", 220000.50);
            disponibles[1] = new Auto("Fit", 175600.70);
            disponibles[2] = new Auto("March", 168900.00);
            disponibles[3] = new Auto("Spark", 160400.40);
        }

        // Se define GetEnumerator para poder hacer uso de IEnumerator al llamar a esta clase,
        // al ser arreglo de C# ya esta definido, solo le damos el acceso desde el exterior.
        public IEnumerator GetEnumerator()
        {
            return disponibles.GetEnumerator();
        }

    }
}
