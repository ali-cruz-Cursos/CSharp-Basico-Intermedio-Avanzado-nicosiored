using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator01
{
    class Contenedora:IEnumerable
    {
        private int[] valores = new int[10];

        public Contenedora()
        {
            for (int n = 0; n < 10; n++)
                valores[n] = n * n;
        }

        // Implementamos el GetEnumerator necesario por el IEnumerable
        // Retorna un IEnumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (new ContenedorEnum(valores));

        }
    }


    // Implementa a IEnumerator
    class ContenedorEnum : IEnumerator
    {
        // Arreglo local para trabajarlo
        public int[] arreglo;
        // Posición inicial para considerar al cero.
        private int posicion = -1;

        public ContenedorEnum(int[] arreglo)
        {
            this.arreglo = arreglo;
        }

        // Implementa a MoveNext por implementar a IEnumerator
        public bool MoveNext()
        {
            posicion++;
            if (posicion < arreglo.Length)
                return true;
            else
                return false;
        }

        // Implementa a Reset por implementar a IEnumerator
        public void Reset()
        {
            posicion = -1;
        }

        // Implementa a Current por implementar a IEnumerator. Regresa object
        public object Current
        {
            // Se debe hacer uso de excepciones para la seguridad
            get { return arreglo[posicion]; }
        }
    }

}
