using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada01
{
    class Nodo
    {
        // Aqui se coloca los datos a guardar en el nodo
        private int dato;

        // Variable de referencia que apunta al siguiente nodo
        private Nodo siguiente = null;

        // Propiedades que usaremos
        public int Dato { get => dato; set => dato = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }

        // Facilitar la impresion
        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
